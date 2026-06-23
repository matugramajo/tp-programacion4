# Cerrajería - TP Programación 4 (UNLZ)

# 

# Sistema de gestión para cerrajería desarrollado con ASP.NET MVC, Entity Framework y SQL Server.

# 

# Integrantes

# \- Alvarez Martina

# \- Gramajo Matilde

# \- Pulcini Camila

# 

# Requisitos previos

# \- .NET 8.0 SDK

# \- SQL Server Express (SQLEXPRESS)

# \- Visual Studio 2022

# 

# Instalación

# 1\. Clonar el repositorio

# 2\. Restaurar la base de datos desde `CerrajeriaDB.bak`:

# &#x20;  - Abrir SQL Server Management Studio

# &#x20;  - Click derecho en "Databases" → "Restore Database..."

# &#x20;  - Seleccionar "Device" → Buscar el archivo `CerrajeriaDB.bak`

# &#x20;  - Confirmar y restaurar

# 3\. Verificar el connection string en `appsettings.json`

# 4\. Ejecutar el proyecto desde Visual Studio

# 

# Cómo asignar y desasignar roles

# 

# \-Asignar rol de Administrador

# Desde SQL Server Management Studio, ejecutar:

# ```sql

# \-- Buscar el Id del usuario

# SELECT Id, Email FROM AspNetUsers;

# 

# \-- Buscar el Id del rol Administrador

# SELECT Id FROM AspNetRoles WHERE Name = 'Administrador';

# 

# \-- Asignar el rol (reemplazar los IDs)

# INSERT INTO AspNetUserRoles (UserId, RoleId)

# VALUES ('<Id-del-usuario>', '<Id-del-rol>');

# ```

# 

# \-Desasignar un rol

# ```sql

# DELETE FROM AspNetUserRoles

# WHERE UserId = '<Id-del-usuario>' AND RoleId = '<Id-del-rol>';

# ```

# 

# \-Roles disponibles

# | Rol: Administrador | Permisos:Gestionar clientes, servicios y todas las reservas |

# | Rol: Cliente | Permisos: Crear y ver sus propias reservas |

# 

# \-Autenticación

# El sistema utiliza autenticación con Google OAuth 2.0.

