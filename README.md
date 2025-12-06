# 🎓 SYSACAD - Sistema de Gestión Académica

**SYSACAD** es una aplicación de escritorio desarrollada en **.NET 6 (C\#)** diseñada para la administración integral de una institución educativa. El sistema permite la gestión de alumnos, profesores, cursos, inscripciones y pagos, diferenciando roles entre administradores y estudiantes.

## 🚀 Características Principales

### 👨‍💻 Panel de Administrador

  * **Gestión de Cursos (ABM):** Crear, editar y eliminar materias. Control de cupos máximos y disponibles.
  * **Gestión de Listas de Espera:** Administración automática cuando los cursos están llenos.
  * **Gestión de Profesores:** Alta y asignación de docentes.
  * **Notificaciones Automáticas:** El sistema verifica fechas automáticamente y envía correos electrónicos para:
      * Inicio de períodos académicos.
      * Fechas límite de inscripción.
      * Vencimientos de pagos.
  * **Reportes:** Generación de documentos en formatos **PDF** y **Word**.

### 👨‍🎓 Panel de Estudiante

  * **Inscripción a Cursos:** Validación de correlatividades y cupos disponibles.
  * **Pagos:** Gestión de conceptos de pago (Matrícula, cuotas, bibliografía) e historial de transacciones.
  * **Autogestión:** Visualización de estado académico.

## 🛠 Tecnologías y Librerías Utilizadas

El proyecto utiliza una arquitectura en capas y las siguientes tecnologías:

  * **Lenguaje:** C\# (.NET 6.0).
  * **Base de Datos:** SQL Server (ADO.NET / System.Data.SqlClient).
  * **Librerías de Terceros:**
      * `PDFsharp-MigraDoc-GDI`: Para la generación de reportes en PDF.
      * `DocX`: Para la manipulación de documentos Word.
      * `Newtonsoft.Json`: Serialización y manejo de datos JSON.
      * `Moq` & `MSTest`: Para pruebas unitarias.

## ⚙️ Instalación y Configuración

### 1\. Clonar el repositorio

```bash
git clone https://github.com/tu-usuario/TP_Labo_2_Sysacad.git
```

### 2\. Base de Datos

El proyecto incluye un script SQL para generar la base de datos necesaria.

1.  Abre **Microsoft SQL Server Management Studio**.
2.  Ejecuta el archivo `dbSYSACAD.sql` ubicado en la raíz del proyecto.
3.  Esto creará la base de datos `TestSYSACAD` y poblará las tablas con datos de prueba (Carreras, Materias, Usuarios, etc.).

### 3\. Configuración de Conexión

Asegúrate de que la cadena de conexión en el proyecto (`App.config` o clase de conexión) apunte a tu instancia local de SQL Server.

## 🔑 Credenciales de Prueba

La base de datos viene precargada con usuarios para facilitar las pruebas:

| Rol | Correo | Contraseña (Hash) |
| :--- | :--- | :--- |
| **Administrador** | `johntravolta@hotmail.com` | (Ya configurada en BD) |
| **Estudiante** | `aaaa@hotmail.com` | (Ya configurada en BD) |

> **Nota:** El código de acceso maestro para registrar nuevos administradores en el sistema es: `ts5bf4`.

## 📂 Arquitectura del Proyecto

  * **Libreria\_Clases\_TP\_SYSACAD:** Contiene toda la lógica de negocio, entidades y acceso a datos.
      * `Entidades Primarias`: Clases core como `Sistema`, `Estudiante`, `Curso`.
      * `BaseDeDatos`: Consultas SQL y mapeo de objetos (`ConsultasCursos`, etc.).
      * `Gestores`: Lógica de control (`GestorCursos`, `GestorPagos`).
      * `Herramientas`: Utilidades como `GeneradorDePDF` y `EmisorCorreoElectronico`.
  * **Interfaz de Usuario:** (WinForms - Formulario principal).
  * **Pruebas:** Proyecto de Unit Testing.

## 📋 Estado del Proyecto

  * [x] Conexión a Base de Datos SQL Server.
  * [x] ABM de Cursos y Alumnos.
  * [x] Sistema de Correlatividades.
  * [x] Notificaciones por Email.
  * [x] Generación de Reportes.

-----

**Autor:** [Joaquin Abal]
**Materia:** Laboratorio de Computación II
