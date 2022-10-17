# Venta Casas
## Diseño

La prueba se desarrollo pensada en arquitectura limpia, y de cómo es interacción con las diferentes reglas de negocio, para dar un buen mantenimiento a futuro, respetando fuertemente los principios SOLID.
La base de datos de realizo por CodeFirst, y finalmente se realizó la migración respectiva, creando el modelo de base de datos con sus respectivas relaciones.
![MERWeelo](https://user-images.githubusercontent.com/4923760/139115182-bc4e3b9e-d089-4adb-86ee-e91e4ded49aa.png)

A continuación, se presenta el cómo se implementó a nivel de código en la solución

![act6 clean](https://user-images.githubusercontent.com/18562142/196098832-fbfda23d-4442-46d4-871c-18f7c52be605.png)

## Ejecución

Para ejecución de proyecto, se requieres restaurar la base se datos que esta en la url https://github.com/yagoalexa/VentaCasas/blob/70e66f604412dfd811bdd11b67ba0d18b46e608b/BaseDeDatos/VentaCasas.bak, después de restaurada se verifica que exista el usuario pruebas y que tenga los permisos de lectura y escritura.
Para finalizar, debe clonar el proyecto en la maquina que se disponga, restaurar los paquetes Nuget y verificar que el proyecto por defecto sea [VentaCasas.Api] y ejecutarlo, al final vera la funcionalidad de las APIs.

![swagger](https://user-images.githubusercontent.com/18562142/196098899-d0b1b2b3-33d2-4c89-84c9-f3ecbbbd462e.jpeg)
