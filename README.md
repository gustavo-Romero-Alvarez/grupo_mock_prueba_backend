Prueba Backend
Descripción
Este proyecto es una API desarrollada en .NET Core C# que implementa el patrón MVC para realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) en una entidad de libros. Además, se ha implementado la autenticación mediante JWT para proteger las operaciones del CRUD.

Requerimientos
.NET Core SDK 3.1 o superior
Visual Studio o Visual Studio Code
Entidad de Libro
La entidad de libro tiene los siguientes campos:

Id (int)
Title (string)
Author (string)
Genre (string)
PublishDate (DateTime)
Operaciones CRUD
Se han implementado controladores y servicios para realizar las siguientes operaciones CRUD en la entidad de libros:

Crear un nuevo libro
Obtener todos los libros
Obtener un libro por su ID
Actualizar un libro existente
Eliminar un libro
Autenticación JWT
La API implementa la autenticación JWT de la siguiente manera:

Un usuario debe autenticarse mediante un endpoint de login y recibir un token JWT.
Los endpoints del CRUD requieren un token JWT válido en el encabezado de la solicitud (Bearer Token).
Documentación
Para ejecutar la aplicación localmente, sigue estos pasos:

Clona el repositorio en tu máquina local.
Abre la solución en Visual Studio o Visual Studio Code.
Construye y ejecuta la aplicación.
Una vez que la aplicación esté en ejecución, puedes probar los endpoints de la API utilizando una herramienta como Postman.
Para usar los endpoints de la API, debes autenticarte primero mediante el endpoint de login. Una vez que hayas recibido el token JWT, debes incluirlo en el encabezado "Authorization" de tus solicitudes a los endpoints del CRUD con el formato "Bearer {token}".

Puntos Extra (Opcionales)
Manejo de Errores
La API implementa un manejo adecuado de errores para las diversas situaciones que pueden ocurrir durante las operaciones CRUD.

Utilización de POSTMAN
Se ha adjuntado un archivo collection.json de Postman con cada uno de los métodos del API y datos de ejemplo. Puedes importar esta colección en Postman y ejecutar los endpoints localmente.

Validaciones
Se han agregado validaciones para asegurar que los datos proporcionados en las solicitudes sean válidos.

Entrega
El código fuente de la aplicación se encuentra disponible en un repositorio de GitHub.

Evaluación
La calidad del código, la organización del proyecto, la implementación correcta de las operaciones CRUD y la autenticación JWT, así como la atención a los puntos opcionales, han sido cuidadosamente revisadas.
