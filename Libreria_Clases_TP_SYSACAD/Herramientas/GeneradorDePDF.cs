using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Persistencia;

namespace Libreria_Clases_TP_SYSACAD.Herramientas
{
    public static class GeneradorDePDF
    {
        public static bool GenerarPDFInscripciones(string nombreArchivo, List<RegistroDeInscripcion> registros,
        int inscripcionesTotales, DateTime fechaPopular, double mediaPorDia, string titulo,
        string fechaEmision, string fechaDesde, string fechaHasta)
        {
            List<List<string>> datos = new List<List<string>>();

            foreach (RegistroDeInscripcion registro in registros)
            {
                List<string> datosRegistro = new List<string>
                {
                    registro.Carrera.ToString(),
                    registro.Legajo,
                    registro.NombreAlumno,
                    registro.CodigoCurso,
                    registro.NombreCurso,
                    registro.Fecha.ToString("dd/MM/yyyy")
                };
                datos.Add(datosRegistro);
            }

            List<string> encabezados = new List<string>
            {"Carrera", "Legajo", "Nombre", "Código de Curso"
            , "Nombre del Curso", "Fecha de Inscripción"};

            List<string> estadisticas = new List<string>
            {
                "Inscripciones totales: " + inscripcionesTotales,
                "Fecha con mayor cantidad de inscripciones: " + fechaPopular.ToString("dd/MM/yyyy"),
                "Media de Inscripciones por día: " + mediaPorDia
            };

            return GenerarPDF(nombreArchivo, titulo, fechaEmision, fechaDesde, fechaHasta, datos, encabezados, estadisticas, "Inscripciones");
        }

        public static bool GenerarPDFIngresos(string nombreArchivo, List<RegistroDePago> registros,
            int pagosTotales, double ingresosTotales, DateTime fechaPopular, string fechaEmision,
            string fechaDesde, string fechaHasta)
        {
            List<List<string>> datos = new List<List<string>>();

            foreach (RegistroDePago registro in registros)
            {
                List<string> datosRegistro = new List<string>
                {
                    registro.Concepto,
                    registro.NombreEstudiante,
                    registro.Legajo,
                    registro.Ingreso.ToString(),
                    registro.Fecha.ToString("dd/MM/yyyy")
                };
                datos.Add(datosRegistro);
            }

            List<string> encabezados = new List<string>
            { "Concepto", "Nombre del Estudiante", "Legajo",
                "Ingreso", "Fecha de Pago" };

            List<string> estadisticas = new List<string>
            {
                "Pagos totales: " + pagosTotales,
                "Ingresos totales del concepto: " + ingresosTotales,
                "Fecha con mayor cantidad de pagos: " + fechaPopular.ToString("dd/MM/yyyy")
            };

            return GenerarPDF(nombreArchivo, "REPORTE DE INGRESOS", fechaEmision, fechaDesde, fechaHasta, datos, encabezados, estadisticas, "Ingresos");
        }

        public static bool GenerarPDF(string nombreArchivo, string titulo, string fechaEmision,
            string fechaDesde, string fechaHasta, List<List<string>> datos, List<string> encabezados,
            List<string> estadisticas, string directorioEspecifico)
        {
            try
            {
                Environment.SpecialFolder directorioDocumentos = Environment.SpecialFolder.MyDocuments;
                string pathSYSACAD = Path.Combine(Environment.GetFolderPath(directorioDocumentos), "SYSACAD");
                string pathReportes = Path.Combine(pathSYSACAD, "Reportes PDF");
                string carpetaEspecifica = Path.Combine(pathReportes, directorioEspecifico);
                string rutaPDF = Path.Combine(carpetaEspecifica, nombreArchivo);

                bool validacionExisteDirectorio = Directory.Exists(carpetaEspecifica);

                if (!validacionExisteDirectorio)
                {
                    Directory.CreateDirectory(carpetaEspecifica);
                }

                // Crear un nuevo documento PDF
                Document document = new Document();

                // Agregar una sección al documento
                Section section = document.AddSection();

                // Configurar la página
                section.PageSetup.PageFormat = PageFormat.A4;
                section.PageSetup.Orientation = Orientation.Portrait;

                //// Agregar un título al documento con espacio antes y después
                // Crear el párrafo para el título
                Paragraph title = section.AddParagraph($"{titulo}  \nPERIODO: {fechaDesde} A {fechaHasta}");

                // Definir un color rojo sangre
                Color rojoSangre = new Color(220, 20, 60);

                // Aplicar el color rojo sangre al título
                title.Format.Font.Color = rojoSangre;
                title.Format.Font.Bold = true;

                // Establecer el formato del título
                title.Format.Alignment = ParagraphAlignment.Center;
                title.Format.Font.Size = 16;
                title.Format.SpaceAfter = "1cm"; // Agrega espacio después del título
                title.Format.Font.Underline = Underline.Single;

                // Crear el párrafo
                Paragraph emisionParagraph = section.AddParagraph();

                // Definir un color azul personalizado
                Color miAzulPersonalizado = new Color(0, 100, 162);

                // Agregar el texto "FECHA DE EMISIÓN:" en negrita y el color personalizado
                FormattedText fechaEmisionText = emisionParagraph.AddFormattedText("FECHA DE EMISIÓN:");
                fechaEmisionText.Bold = true;
                fechaEmisionText.Color = miAzulPersonalizado;

                // Agregar la fecha después del texto
                emisionParagraph.AddText($" {fechaEmision}");

                // Establecer el formato del párrafo
                emisionParagraph.Format.Alignment = ParagraphAlignment.Left;
                emisionParagraph.Format.Font.Size = 13;
                emisionParagraph.Format.SpaceAfter = "0.5cm"; // Agrega espacio después del párrafo

                // Crear una tabla para los registros con espacio antes y después
                Table table = section.AddTable();
                table.Borders.Width = 0.75;
                table.Format.Alignment = ParagraphAlignment.Left;
                table.Format.SpaceBefore = "0.3cm"; // Agrega espacio antes de la tabla
                table.Format.SpaceAfter = "0.3cm"; // Agrega espacio después de la tabla

                // Definir el ancho de las columnas
                double columnWidth = Unit.FromCentimeter(3.0);
                foreach (var _ in encabezados)
                {
                    table.AddColumn().Width = columnWidth;
                }

                // Agregar encabezados de columna a la tabla
                Row headerRow = table.AddRow();
                foreach (var encabezado in encabezados)
                {
                    headerRow.Cells[encabezados.IndexOf(encabezado)].AddParagraph(encabezado);
                }

                // Agregar los registros a la tabla
                foreach (var datosRegistro in datos)
                {
                    Row dataRow = table.AddRow();
                    for (int i = 0; i < datosRegistro.Count; i++)
                    {
                        dataRow.Cells[i].AddParagraph(datosRegistro[i]);
                    }
                }

                // Crear el párrafo para las estadísticas con el mismo color azul y negrita que FECHA DE EMISIÓN
                Paragraph statistics = section.AddParagraph();
                FormattedText estadisticasText = statistics.AddFormattedText("ESTADÍSTICAS");
                estadisticasText.Color = miAzulPersonalizado; // Utiliza el mismo color que FECHA DE EMISIÓN
                estadisticasText.Bold = true; // Establece la negrita

                statistics.Format.Font.Size = 13;
                statistics.Format.SpaceBefore = "1cm"; // Agrega espacio antes de las estadísticas
                statistics.Format.SpaceAfter = "0.3cm"; // Agrega espacio después de las estadísticas

                foreach (var estadistica in estadisticas)
                {
                    section.AddParagraph(estadistica);
                }

                // Guardar el documento PDF en la ruta especificada
                PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(true);
                pdfRenderer.Document = document;
                pdfRenderer.RenderDocument();
                pdfRenderer.PdfDocument.Save(rutaPDF);

                return true;
            }
            catch (Exception ex)
            {
                // El programa no se detiene, sino que devuelve false al form
                // para que mostrar el error mediante un messageBox. Se registra
                // la excepcion en el JSON
                RegistroExcepciones.RegistrarExcepcion(ex);
                return false;
            }
        }
    }
}
