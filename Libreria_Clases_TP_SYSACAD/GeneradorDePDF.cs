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
        public static void GenerarPDF(string nombreArchivo, List<RegistroDeInscripcion> registros, int inscripcionesTotales, DateTime fechaPopular, double mediaPorDia)
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
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 12);

            // Agregar el contenido al PDF, incluyendo los registros de ListView y las estadísticas
            XTextFormatter tf = new XTextFormatter(gfx);
            tf.DrawString("Estadisticas:", font, XBrushes.Black, new XRect(100, 100, page.Width, page.Height), XStringFormats.TopLeft);

            // Agregar los registros de ListView
            int yPos = 130;
            foreach (RegistroDeInscripcion registro in registros)
            {
                tf.DrawString($"Carrera: {registro.Carrera}, Legajo: {registro.Legajo}, Nombre: {registro.NombreAlumno}, Código de Curso: {registro.CodigoCurso}, Nombre del Curso: {registro.NombreCurso}, Fecha de Inscripción: {registro.FechaInscripcion}", font, XBrushes.Black, new XRect(100, yPos, page.Width, page.Height), XStringFormats.TopLeft);
                yPos += 20;
            }

            // Agregar las estadísticas
            yPos += 20;
            tf.DrawString($"Inscripciones totales: {inscripcionesTotales}", font, XBrushes.Black, new XRect(100, yPos, page.Width, page.Height), XStringFormats.TopLeft);
            yPos += 20;
            tf.DrawString($"Fecha con mayor cantidad de inscripciones: {fechaPopular}", font, XBrushes.Black, new XRect(100, yPos, page.Width, page.Height), XStringFormats.TopLeft);
            yPos += 20;
            tf.DrawString($"Media de Inscripciones por día: {mediaPorDia}", font, XBrushes.Black, new XRect(100, yPos, page.Width, page.Height), XStringFormats.TopLeft);

            // Guardar el documento PDF en la ruta especificada
            document.Save(rutaPDF);
        }
    }
}
