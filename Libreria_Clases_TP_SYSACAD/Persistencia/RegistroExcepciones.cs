using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Herramientas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Persistencia
{
    internal class RegistroExcepciones : ArchivosJson
    {
        private static string _fullpath; 

        public RegistroExcepciones() 
        {
            string pathName = CombinePath(GetPath(), directoryName);

            string fullPath = CombinePath(pathName, fileRegistroExcepciones);
            _fullpath = fullPath;

            bool validacionExisteArchivo = ValidarSiExisteArchivo(fullPath);

            if (!validacionExisteArchivo)
            {
                CrearArchivo(fullPath, fileRegistroExcepciones);
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
            using (var writer = new StreamWriter(_fullpath, true))
            {
                // Serializar el objeto a JSON y escribirlo en el archivo
                var json = System.Text.Json.JsonSerializer.Serialize(excepcionInfo, opciones);
                writer.Write(json);
            }
        }
    }
}
