using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Herramientas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Persistencia
{
    internal class RegistroExcepciones
    {
        private static string _pathArchivoJSON;

        public RegistroExcepciones() 
        {
            Environment.SpecialFolder directorioDocumentos = Environment.SpecialFolder.MyDocuments;
            string pathSYSACAD = Path.Combine(Environment.GetFolderPath(directorioDocumentos), "SYSACAD");
            string pathExcepciones = Path.Combine(pathSYSACAD, "Excepciones");
            _pathArchivoJSON = Path.Combine(pathExcepciones, "RegistroExcepciones.json");

            bool validacionExisteDirectorio = Directory.Exists(pathExcepciones);
            bool validacionExisteArchivo = File.Exists(_pathArchivoJSON);

            if (!validacionExisteDirectorio)
            {
                Directory.CreateDirectory(pathExcepciones);
            }

            if (!validacionExisteArchivo)
            {
                using (StreamWriter sw = new StreamWriter(_pathArchivoJSON, true, Encoding.Default))
                {
                    sw.WriteLine();
                }
            }
        }

        public static void RegistrarExcepcion(Exception excepcion)
        {
            var excepcionInfo = new
            {
                Codigo = excepcion.HResult,
                Tipo = excepcion.GetType().FullName,
                Descripcion = excepcion.Message,
                Fecha = DateTime.Now
            };

            // Configurar opciones de serialización para la indentación
            var opciones = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            // Guardar el JSON en un archivo utilizando StreamWriter
            using (var writer = new StreamWriter(_pathArchivoJSON, true, Encoding.Default))
            {
                // Serializar el objeto a JSON y escribirlo en el archivo
                var json = System.Text.Json.JsonSerializer.Serialize(excepcionInfo, opciones);
                writer.Write(json);
            }
        }
    }
}
