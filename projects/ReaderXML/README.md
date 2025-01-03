# ReaderXML

Este proyecto tiene como objetivo desarrollar una API REST para la gestión de comprobantes, permitiendo la lectura y manipulación de datos XML a través de diferentes módulos de backend.

## Estructura del Proyecto

### 1. Crear un nuevo controlador

Agrega un controlador API para gestionar los comprobantes:

- **Crear un controlador API vacío:** `ComprobanteController.cs`
- Ubicación: `Controllers/`

### 2. Crear nuevos proyectos de biblioteca de clases

Se recomienda estructurar el proyecto en varias capas según la arquitectura de capas, con los siguientes proyectos de biblioteca de clases:

- `ReaderXML.Backend.Application`: Para la lógica de aplicación.
- `ReaderXML.Backend.Domain`: Para los objetos de dominio y lógica de negocio.
- `ReaderXML.Backend.Infraestructure`: Para la capa de infraestructura (acceso a datos, conexiones, etc.).
- `ReaderXML.Backend.Shared`: Para los objetos compartidos y utilitarios.

### 3. Configurar Dependencias de Compilación

Configura las dependencias entre proyectos para asegurar la correcta integración de los módulos.

- **API** depende de **Application**
- **Application** depende de **Domain** y **Shared**
- **Infraestructure** depende de **Domain**

### 4. Crear Carpetas

Organiza las carpetas y clases dentro de cada proyecto:

- **Comprobante**: Crear carpeta `Comprobante` en `ReaderXML.Backend.Application`.
  - Clase: `ComprobanteApp.cs` para la lógica específica de los comprobantes.

### 5. Configuración de Base de Datos

Configura una base de datos SQL Server para almacenar los datos necesarios de los comprobantes.

---

## Instrucciones de Ejecución

Para ejecutar el proyecto:

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/hustavojhon/ReaderXML.git
