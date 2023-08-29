# Trabajo práctico número 3 - Arquitectura de Sistemas Distribuidos
---
## 1. Sistema distribuido simple

- Crear una red en docker

![Docker network create](https://github.com/AgusZanini/ejercicios-ingesoftw3/blob/master/03-arquitectura-sistemas-distribuidos/images/create_network.png)

- Instanciar una base de datos redis conectada a esa red

![Download redis](https://github.com/AgusZanini/ejercicios-ingesoftw3/blob/master/03-arquitectura-sistemas-distribuidos/images/download_redis_image.png)

- Levantar una aplicación web que use esa base de datos

![Download web app](https://github.com/AgusZanini/ejercicios-ingesoftw3/blob/master/03-arquitectura-sistemas-distribuidos/images/download_web_app.png)

- Abrir un navegador y acceder a la url

![url](https://github.com/AgusZanini/ejercicios-ingesoftw3/blob/master/03-arquitectura-sistemas-distribuidos/images/hello_from_redis.png)

- Verificar el estado de los contenedores y redes en docker
    - Estado de los contenedores
      ![docker ps](https://github.com/AgusZanini/ejercicios-ingesoftw3/blob/master/03-arquitectura-sistemas-distribuidos/images/docker_ps.png)

    - Estado de las redes
      ![docker network ls](https://github.com/AgusZanini/ejercicios-ingesoftw3/blob/master/03-arquitectura-sistemas-distribuidos/images/docker_network_ls.png)

    - Detalles de la red mybridge
      ![docker network inspect](https://github.com/AgusZanini/ejercicios-ingesoftw3/blob/master/03-arquitectura-sistemas-distribuidos/images/docker_network_inspect.png)

    - Puertos abiertos:
        - 5000 para la aplicación web.
        - 6379 para redis.

    - Comandos utilizados:
        - `docker ps` para ver el estado de los contenedores y ver en que puertos están corriendo.
        - `docker network ls` para ver el listado de las redes que tengo.
        - `docker network inspect <nombre de la red>` para ver el detalle de la red mybridge.

