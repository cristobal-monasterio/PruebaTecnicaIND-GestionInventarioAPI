# Prueba Técnica IND - Gestión de Inventario API

API REST desarrollada con ASP.NET Core Web API para la gestión de productos e implementación de autenticación JWT.

## Tecnologías utilizadas

- ASP.NET Core 8
- Entity Framework Core
- SQL Server
- JWT Authentication
- BCrypt
- Swagger / OpenAPI

## Funcionalidades

- Autenticación mediante JWT
- Login de usuarios
- CRUD completo de productos
- Protección de endpoints mediante autorización
- Persistencia de datos con Entity Framework Core
- Documentación y pruebas mediante Swagger
- Validaciones mediante Data Annotations

## Configuración del proyecto

### 1. Clonar repositorio

```bash
git clone https://github.com/cristobal-monasterio/PruebaTecnicaIND-GestionInventarioAPI.git
```

### 2. Configurar cadena de conexión

Editar el archivo:

```txt
appsettings.json
```

Modificar:

```json
"ConnectionStrings": {
  "DefaultConnection": "Data Source=SERVIDOR;Initial Catalog=Inventario;IntegratedSecurity=True;TrustServerCertificate=True;"
}
```

## Base de datos

Ejecutar migraciones:

```powershell
Update-Database
```

## Usuario administrador por defecto

Al ejecutar las migraciones se crea automáticamente un usuario administrador para pruebas.

Usuario:

```txt
admin
```

Contraseña:

```txt
Admin123*
```

## Ejecución

Ejecutar el proyecto desde Visual Studio o mediante:

```bash
dotnet run
```

Swagger disponible en:

```txt
https://localhost:44366/swagger
```

## Endpoints principales

### Autenticación

```http
POST /api/Auth/login
```

### Productos

```http
GET    /api/Productos
POST   /api/Productos
GET    /api/Productos/{id}
PUT    /api/Productos/{id}
DELETE /api/Productos/{id}
```

## Autor

Cristobal Monasterio