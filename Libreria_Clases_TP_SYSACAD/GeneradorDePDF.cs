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

namespace Libreria_Clases_TP_SYSACAD
{
    public static class GeneradorDePDF
    {
        public static void GenerarPDFInscripciones(string nombreArchivo, List<RegistroDeInscripcion> registros, int inscripcionesTotales, DateTime fechaPopular, double mediaPorDia)
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
            Paragraph title = section.AddParagraph("Reporte de Inscripciones");
            title.Format.Alignment = ParagraphAlignment.Center;
            title.Format.Font.Size = 16;
            title.Format.SpaceBefore = "1cm"; // Agrega espacio antes del título
            title.Format.SpaceAfter = "0.5cm"; // Agrega espacio después del título

            // Crear una tabla para los registros
            Table table = section.AddTable();
            table.Borders.Width = 0.75;
            table.Format.Alignment = ParagraphAlignment.Left;

            // Definir el ancho de las columnas
            double columnWidth = Unit.FromCentimeter(3.0);
            table.AddColumn().Width = columnWidth;
            table.AddColumn().Width = columnWidth;
            table.AddColumn().Width = columnWidth;
            table.AddColumn().Width = columnWidth;
            table.AddColumn().Width = columnWidth;
            table.AddColumn().Width = columnWidth;

            // Agregar encabezados de columna a la tabla
            Row headerRow = table.AddRow();
            headerRow.Cells[0].AddParagraph("Carrera");
            headerRow.Cells[1].AddParagraph("Legajo");
            headerRow.Cells[2].AddParagraph("Nombre");
            headerRow.Cells[3].AddParagraph("Código de Curso");
            headerRow.Cells[4].AddParagraph("Nombre del Curso");
            headerRow.Cells[5].AddParagraph("Fecha de Inscripción");

            // Agregar los registros de ListView a la tabla
            foreach (RegistroDeInscripcion registro in registros)
            {
                Row dataRow = table.AddRow();
                dataRow.Cells[0].AddParagraph(registro.Carrera.ToString());
                dataRow.Cells[1].AddParagraph(registro.Legajo);
                dataRow.Cells[2].AddParagraph(registro.NombreAlumno);
                dataRow.Cells[3].AddParagraph(registro.CodigoCurso);
                dataRow.Cells[4].AddParagraph(registro.NombreCurso);
                dataRow.Cells[5].AddParagraph(registro.FechaInscripcion.ToString("dd/MM/yyyy"));
            }

            // Agregar las estadísticas con espacio antes y después
            Paragraph statistics = section.AddParagraph();
            statistics.AddText("Estadísticas:");
            statistics.Format.Font.Size = 12;
            statistics.Format.SpaceBefore = "1cm"; // Agrega espacio antes de las estadísticas
            statistics.Format.SpaceAfter = "0.5cm"; // Agrega espacio después de las estadísticas

            section.AddParagraph("Inscripciones totales: " + inscripcionesTotales);
            section.AddParagraph("Fecha con mayor cantidad de inscripciones: " + fechaPopular.ToString("dd/MM/yyyy"));
            section.AddParagraph("Media de Inscripciones por día: " + mediaPorDia);

            // Guardar el documento PDF en la ruta especificada
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(true);
            pdfRenderer.Document = document;
            pdfRenderer.RenderDocument();
            pdfRenderer.PdfDocument.Save(rutaPDF);
        }

        public static void GenerarPDFIngresos(string nombreArchivo, List<RegistroDePago> registros, int pagosTotales, double ingresosTotales, DateTime fechaPopular)
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
            Paragraph title = section.AddParagraph("Reporte de Ingresos");
            title.Format.Alignment = ParagraphAlignment.Center;
            title.Format.Font.Size = 16;
            title.Format.SpaceBefore = "1cm"; // Agrega espacio antes del título
            title.Format.SpaceAfter = "0.5cm"; // Agrega espacio después del título

            // Crear una tabla para los registros con espacio antes y después
            Table table = section.AddTable();
            table.Borders.Width = 0.75;
            table.Format.Alignment = ParagraphAlignment.Left;
            table.Format.SpaceBefore = "1cm"; // Agrega espacio antes de la tabla
            table.Format.SpaceAfter = "1cm"; // Agrega espacio después de la tabla

            // Definir el ancho de las columnas
            double columnWidth = Unit.FromCentimeter(3.0);
            table.AddColumn().Width = columnWidth;
            table.AddColumn().Width = columnWidth;
            table.AddColumn().Width = columnWidth;
            table.AddColumn().Width = columnWidth;
            table.AddColumn().Width = columnWidth;

            // Agregar encabezados de columna a la tabla
            Row headerRow = table.AddRow();
            headerRow.Cells[0].AddParagraph("Concepto");
            headerRow.Cells[1].AddParagraph("Nombre del Estudiante");
            headerRow.Cells[2].AddParagraph("Legajo");
            headerRow.Cells[3].AddParagraph("Ingreso");
            headerRow.Cells[4].AddParagraph("Fecha de Pago");

            // Agregar los registros de ListView a la tabla
            foreach (RegistroDePago registro in registros)
            {
                Row dataRow = table.AddRow();
                dataRow.Cells[0].AddParagraph(registro.Concepto);
                dataRow.Cells[1].AddParagraph(registro.NombreEstudiante);
                dataRow.Cells[2].AddParagraph(registro.Legajo);
                dataRow.Cells[3].AddParagraph(registro.Ingreso.ToString());
                dataRow.Cells[4].AddParagraph(registro.FechaPago.ToString("dd/MM/yyyy"));
            }

            // Agregar las estadísticas con espacio antes y después
            Paragraph statistics = section.AddParagraph();
            statistics.AddText("Estadísticas:");
            statistics.Format.Font.Size = 12;
            statistics.Format.SpaceBefore = "1cm"; // Agrega espacio antes de las estadísticas
            statistics.Format.SpaceAfter = "0.5cm"; // Agrega espacio después de las estadísticas

            section.AddParagraph("Pagos totales: " + pagosTotales);
            section.AddParagraph("Ingresos totales del concepto: " + ingresosTotales);
            section.AddParagraph("Fecha con mayor cantidad de pagos: " + fechaPopular.ToString("dd/MM/yyyy"));

            // Guardar el documento PDF en la ruta especificada
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(true);
            pdfRenderer.Document = document;
            pdfRenderer.RenderDocument();
            pdfRenderer.PdfDocument.Save(rutaPDF);
        }
    }
}
