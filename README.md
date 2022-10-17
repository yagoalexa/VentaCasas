# Venta Casas
## Diseño

La prueba se desarrollo pensada en arquitectura limpia, y de cómo es interacción con las diferentes reglas de negocio, para dar un buen mantenimiento a futuro, respetando fuertemente los principios SOLID.
La base de datos de realizo por CodeFirst, y finalmente se realizó la migración respectiva, creando el modelo de base de datos con sus respectivas relaciones.
![MERWeelo](https://user-images.githubusercontent.com/4923760/139115182-bc4e3b9e-d089-4adb-86ee-e91e4ded49aa.png)

A continuación, se presenta el cómo se implementó a nivel de código en la solución

![weelo](https://user-images.githubusercontent.com/4923760/139114818-4f351d32-40de-4d01-838d-528799a056f3.png)

## Ejecución

Para ejecución de proyecto, se requieres restaurar la base se datos que esta en la url https://github.com/yagoalexa/VentaCasas/blob/70e66f604412dfd811bdd11b67ba0d18b46e608b/BaseDeDatos/VentaCasas.bak, después de restaurada se verifica que exista el usuario pruebas y que tenga los permisos de lectura y escritura.
Para finalizar, debe clonar el proyecto en la maquina que se disponga, restaurar los paquetes Nuget y verificar que el proyecto por defecto sea [VentaCasas.Api] y ejecutarlo, al final vera la funcionalidad de las APIs.

![Swagger](https://user-images.githubusercontent.com/4923760/139115435-ce0e1d68-7efb-4c54-b66c-bee4a289d765.jpg)
