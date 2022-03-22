# Challenge para creacion API con .NET Core 3.1

## Controlador 
Mediante un unico controlador (api/Contacts) se puede acceder al total de registros por ID x ejemplo, filtrar determinados registros, borrar algun registro, actualizar.

### DB
Con respecto a la base de datos, se creo dentro de VS Community una pequeña DB (con SQL Server) para facilitar la visualizacion de las pruebas en Postman. 
Detalle de la creacion de la DB: 

CREATE TABLE [dbo].[Contacts] (
   - [Id]          INT          IDENTITY (1, 1) NOT NULL,
   - [FirstName]   VARCHAR (30) NOT NULL,
   - [LastName]    VARCHAR (30) NOT NULL,
   - [Company]     VARCHAR (30) NOT NULL,
   - [Email]       VARCHAR (50) NOT NULL,
   - [PhoneNumber] VARCHAR (30) NULL,
   - CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED ([Id] ASC)
);



