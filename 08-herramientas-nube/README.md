# Trabajo Practico 8 - Herramientas de construccion de software en la nube

Creacion de un nuevo workflow

![1](1_new_workflow.png)

Guardado del nuevo workflow

![2](2_saved_workflow.png)

Ejecucion correcta

![3](3_build_and_publish.png)

---
* El pipeline mostrado divide al workflow en dos etapas, `build` que se encarga de la construccion y `deploy` que se encarga del publicado del deployment del proyecto al servidor
---

## Github Actions para generar una imagen Docker de SimpleWebAPI

Secretos creados

![4](4_secrets_created.png)

Workflow guardado

![5](5_create_image.png)

Imagen publicada en Docker Hub

![6](6_docker_hub.png)

Se descarga y se corre la imagen

![7](7_docker_pull.png)

Visualizacion

![8](8_localhost.png)

## Github Actions para el proyecto de React

Archivo .yml

![10](10_workflow_file.png)

## Github Actions para generar una imagen Docker y subirla a Docker Hub

Archivo .yml

![11](11_build_and_publish.png)