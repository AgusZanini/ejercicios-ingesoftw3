# Trabajo Practico 9 - Pruebas Unitarias

Clonacion de repositorio

![1](1_clone_repo.png)

Revision de codigo

![2](2_revisar_codigo.png)

Creacion de simpleapptests

![3](3_crear_simpleapptests.png)

Agregamos paquetes

![4](4_add_package_NUnit.png)

![5](5_add_packages_otros.png)

Instalacion de extension .NET Core Test Explorer

![6](6_install_netcoretestexplorer.png)

Edicion de settings.json

![7](7_settings_json.png)

Run de tests

![8](8_play_tests.png)

## Creacion de nuestros tests

Edicion de UnitTest1.cs

![9](9_new_tests.png)

Run de los nuevos tests

![11](11_running_new_tests.png)

Edicion del codigo bajo prueba para que falle

![12](12_modify_line_9.png)

Comprobacion de la falla

![13](13_test_fail_after_modification.png)

Refactorizacion del codigo

![14](14_refactor_code.png)

Dotnet test

![15](15_dotnet_test.png)

## Desarrollo de pruebas unitarias sobre una WebAPI

Creacion de proyecto de pruebas

![16](16_simple_web_api_tests.png)

Add Reference

![17](17_add_reference.png)

Edicion de settings.json

![18](18_settingsjson.png)

Reemplazo de UnitTest1.cs

![19](19_unit_test.png)

Resultados de los tests

## Tests con mocks

Resultados de los tests con mock

![20](20_test_results.png)

Por consola

![21](21_dotnet_tests.png)

En el archivo de test se reemplaza el servicio real de HttpClient por el mock `mockHttpMessageHandler`. El cual da la posibilidad de probar la logica del servicio sin tener que hacer llamadas HTTP reales. Tambien se usa una respuesta HTTP mock con las lineas
`new HttpResponseMessage(HttpStatusCode.OK)
    {
        Content = new StringContent("[{ \"UserId\": 1, \"Id\": 1, \"Title\": \"Test Title\", \"Body\": \"Test Body\" }]")
    };`

Fallo en el test luego de modificar el codigo de estado de la respuesta a `NotFound`

![22](21_test_fail.png)

Nuevo test con el mock modificado 

`
[Test]
        public async Task GetMyModelsAsync_ReturnsExpectedNumberOfItems()
        {
            // Arrange
            var serviceCollection = new ServiceCollection();

            // Define a collection of Post objects with a different length
            var posts = new List<Post>
            {
                new Post { UserId = 1, Id = 1, Title = "Test Title 1", Body = "Test Body 1" },
                new Post { UserId = 2, Id = 2, Title = "Test Title 2", Body = "Test Body 2" },
            };

            var mockResponse = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(JsonSerializer.Serialize(posts))
            };

            var mockHttpMessageHandler = new Mock<HttpMessageHandler>();
            mockHttpMessageHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(mockResponse);

            serviceCollection.AddTransient<IApiService>(_ => new ApiService(new HttpClient(mockHttpMessageHandler.Object)));
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var apiService = serviceProvider.GetRequiredService<IApiService>();

            // Act
            var result = await apiService.GetMyModelsAsync();

            // Assert
            Assert.IsNotNull(result);

            // Verify that the number of items returned matches the expected count
            Assert.AreEqual(2, result.Count());
        }
`
