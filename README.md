# Gestión Hotelera

# Acciones 
- Abrir la carpeta del proyecto identificada como _**Gestion-Hotelera**_ con el VSCode. 
- Una vez en el proyecto, debe hacerse click derecho a la opción _**abrir en terminal integrado**_ en la carpeta nombrada **src**. 
- Dentro de la terminal, debe escribirse **dotnet build**, al finalizar el proceso, debe mostrarnos el mensaje _**Compilación correcta**_. 

# Correr el programa
- Abrir la carpeta **Presentación**.
- Hacer click derecho sobre dicha carpeta y seleccionar la opción **Abrir en terminal integrado**. 
- Dentro de la terminal escribimos **dotnet run**. 
- Una vez finalizado el proceso nos devolverá una serie de URLs en las cuales debemos ingresar haciendo (**ctrl + clic**). E ingresaremos al localhost. 

# Migraciones 
- Para crear la base de datos en MySQL se debe traducir desde nuestro contexto (C#) a SQL, para ello debemos realizar una migracion. Esto se debe realizar una unica vez al momento de crear la base de datos.
- Dentro de la terminal se introducirá el siguiente comando: 

<!-- dotnet ef migrations add NOMBRE_MIGRACION --context NOMBRE_CONTEXTO --output-dir DIRECTORIO_MIGRACIONES --project NOMBRE_PROYECTO --startup-project NOMBRE_PROYECTO_EJECUTABLE -->
