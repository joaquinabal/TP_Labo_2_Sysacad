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

            return GenerarPDF(nombreArchivo, titulo, fechaEmision, fechaDesde, fechaHasta, datos, encabezados, estadisticas);
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

            return GenerarPDF(nombreArchivo, "Reporte de Ingresos", fechaEmision, fechaDesde, fechaHasta, datos, encabezados, estadisticas);
        }

        public static bool GenerarPDF(string nombreArchivo, string titulo, string fechaEmision,
            string fechaDesde, string fechaHasta, List<List<string>> datos, List<string> encabezados,
            List<string> estadisticas)
        {
            try
            {
                // Obtiene la ruta de la carpeta "Documentos" del usuario actual
                string documentosPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Combina la ruta de "Documentos" con "Reportes Sistema" y el nombre del archivo PDF
                string carpetaReportes = Path.Combine(documentosPath, "Reportes Sistema");
                string rutaPDF = Path.Combine(carpetaReportes, nombreArchivo);

                // Verificar si la carpeta de reportes existe, y si no, crearla
                if (!Directory.Exists(carpetaReportes))
                {
                    Directory.CreateDirectory(carpetaReportes);
                }

                // Crear un nuevo documento PDF
                Document document = new Document();

                // Agregar una sección al documento
                Section section = document.AddSection();

                // Configurar la página
                section.PageSetup.PageFormat = PageFormat.A4;
                section.PageSetup.Orientation = Orientation.Portrait;

                // Agregar un título al documento con espacio antes y después
                Paragraph title = section.AddParagraph($"{titulo}  \nPeriodo: {fechaDesde} a {fechaHasta}");
                title.Format.Alignment = ParagraphAlignment.Center;
                title.Format.Font.Size = 16;
                title.Format.SpaceBefore = "1cm"; // Agrega espacio antes del título
                title.Format.SpaceAfter = "0.5cm"; // Agrega espacio después del título

                // Agregar un párrafo para la fecha de emisión
                Paragraph emisionParagraph = section.AddParagraph($"Fecha de Emisión: {fechaEmision}");
                emisionParagraph.Format.Alignment = ParagraphAlignment.Left;
                emisionParagraph.Format.Font.Size = 14;
                emisionParagraph.Format.SpaceAfter = "0.5cm"; // Agrega espacio después del párrafo

                // Crear una tabla para los registros con espacio antes y después
                Table table = section.AddTable();
                table.Borders.Width = 0.75;
                table.Format.Alignment = ParagraphAlignment.Left;
                table.Format.SpaceBefore = "1cm"; // Agrega espacio antes de la tabla
                table.Format.SpaceAfter = "1cm"; // Agrega espacio después de la tabla

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

                // Agregar las estadísticas con espacio antes y después
                Paragraph statistics = section.AddParagraph();
                statistics.AddText("Estadísticas:");
                statistics.Format.Font.Size = 12;
                statistics.Format.SpaceBefore = "1cm"; // Agrega espacio antes de las estadísticas
                statistics.Format.SpaceAfter = "0.5cm"; // Agrega espacio después de las estadísticas

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
                Console.WriteLine("Error al generar el PDF: " + ex.Message);
                return false;
            }
        }
    }
}
