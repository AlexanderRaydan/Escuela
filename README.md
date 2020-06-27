# Escuela
 
Esta es la versión 2.0 de mi primer proyecto en .NET core, consiste en hacer un sistema de una escuela
Este nuevo proyecto consiste en mejorar el sistema que tenía anteriormente , añadiendo sistema de usuarios,
una base de datos real , mejorar las entidades , definir mejor las clases y sus atributos , añadir vistas bonitas
etc etc
 
Todo el proyecto está hecho con ASP.NET core MVC, la base de datos la administro con el ORM que nos administra
Entity framework core y el sistema de usuarios usé Identity framework, la base de datos está hecha en MSSQL
 
# Creación de usuarios
 
Las entidades principales (que están en la carpeta "models") la separé del sistema de usuario evitar problemas,
la lógica que hice fué que al crear un usuario se creaba un nuevo alumno automáticamente y en la tabla de datos
las 2 entidades estaban relacionadas con una FK , después el usuario llena los datos faltantes. De esta manera tenía
el proyecto mucho mas ordenado, Si tenía que cambiar algo en los las entídades (los modelos) no tenia que tocar el
sistema de usuarios y trabajaba de manera mas cómoda.
 
# Vistas 
 
Están hechas con razor pages , para se pueden implementar lógicas dentro de las páginas para tener un código legible,
escalable y reutilizable , los diseños de las mismas están hechos con bootstrap principalmente (aún me falta completar 
mucho del diseño de la página).


**ESTE PROYECTO SIGUE EN DESARROLLO**
