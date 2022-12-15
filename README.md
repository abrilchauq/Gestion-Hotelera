# Gestión Hotelera

## Acciones 
- Abrir la carpeta del proyecto identificada como _**Gestion-Hotelera**_ con el VSCode. 
- Una vez en el proyecto, debe hacerse click derecho a la opción _**abrir en terminal integrado**_ en la carpeta nombrada **src**. 
- Dentro de la terminal, debe escribirse **dotnet build**, al finalizar el proceso, debe mostrarnos el mensaje _**Compilación correcta**_. 

## Correr el programa
- Abrir la carpeta **Presentación**.
- Hacer click derecho sobre la carpeta y seleccionar la opción **Abrir en terminal integrado**. 
- Dentro de la terminal escribimos **dotnet run**. 
- Una vez finalizado el proceso nos devolverá una serie de URLs. Debemos ingresar en la primera haciendo (**ctrl + clic**), una vez que nos dirija a la página, escribilemos **/swagger** al final. Y finalmente podremos probar nuestra aplicación. 

## Migraciones 
- Para crear la base de datos en MySQL se debe traducir desde nuestro contexto (C#) a SQL, para ello debemos realizar una migracion. Esto se debe realizar una unica vez al momento de crear la base de datos.
- Dentro de la terminal se introducirá el siguiente comando: 

```
dotnet ef migrations add NOMBRE_MIGRACION --context NOMBRE_CONTEXTO --output-dir DIRECTORIO_MIGRACIONES --project NOMBRE_PROYECTO --startup-project NOMBRE_PROYECTO_EJECUTABLE
```
### Ejemplo 
```
dotnet ef migrations add UnNuevoCambio --context HotelDbContext --output-dir Persistencia/Migraciones --project Presentacion --startup-project Presentacion
```
- Cada vez que se ingresen cambios en el contexto, se debe realizar una nueva migración. 

## Swagger
### Methods 
- GET: Se utiliza para consultar información como una **SELECT** a la base de datos, se puede filtrar datos empleando los datos enviados por la URL.
- POST: Envía datos al servidor por medio del cuerpo (body) y nada a través de la URL como se emplea en el método GET. Se utiliza para registrar información, similar al **INSERT** de datos a nivel de base de datos.
- PUT: Se utiliza para la actualización de información que ya existe, es semejante a un **UPDATE** de datos a nivel de base de datos. 
- DELETE: se utiliza para eliminar de información existente, es semejante a un **DELETE** de datos a nivel de base de datos. Se elimina con el ID de los elementos que querramos borrar. 

### How it works   
- Para poder utilizar el swagger, primero debemos activar el servicio de base de datos. Una vez hecho esto, podemos continuar. 
- En la aplicación, vamos a hacer click sobre el **POST**; en el cual nos va a aparecer una función llamada **try out**. Damos click en dicha función, y ahí nos permitirá ingresar los valores de la tabla, para probar oprimiremos el botón **Execute**. 
- Iremos a el método **GET** para visualizar si se efectuaron los cambios con los valores que ingresamos anteriormente. 

- Cuando queremos realizar cambios en los valores que ingresamos, utilizaremos el método **PUT**. Como hicimos anteriormente, vamos a clickear sobre **try out**. 
- Este método nos va a permitir modificar todos los parámetros que necesitemos.
- Copiaremos el **id** que nos devolvió anteriormente el **GET**, y lo pegaremos en el espacio que nos deja el PUT para el **id**. Le damos a **Execute** y nos devolverá los cambios que hemos realizado (Para visualizar estos cambios iremos a nuestro GET y le daremos **Execute** una vez más). 

- Para borrar algún elemento, utilizaremos el método **DELETE**. Como se mencionó en todos los procesos anteriores, daremos click en **try out**. 
- Este método nos mostrará solamente una acción para poder eliminar. Tal y como lo hicimos en el **PUT**, debemos que copiar y pegar el **id** del elemento a eliminar.   Cuando le demos al **Execute** eliminará dichos elementos. 
- Para visualizar la acción realizada por el método **DELETE**, iremos al **GET**, clickeamos en **Execute**. Y veremos como los valores que ingresamos/actualizamos, fueron eliminados. 
