using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    internal class ArchivosJSONInscripciones : ArchivosJson
    {
        internal static List<RegistroDeInscripcion>? CargarInscripcionesDesdeArchivoJson()
        {
            List<RegistroDeInscripcion> listaInscripciones = new List<RegistroDeInscripcion>();

            string stringInscripciones = "";
            string fullPath = "";

            string pathName = CombinePath(GetPath(), directoryName);

            try
            {
                if (!ValidarSiExisteDirectorio(pathName))
                {
                    CrearDirectorio(pathName);
                }

                fullPath = CombinePath(pathName, fileRegistroInscripciones);

                bool validacionExisteArchivo = false;
                validacionExisteArchivo = ValidarSiExisteArchivo(fullPath);

                if (!validacionExisteArchivo)
                {
                    CrearArchivo(fullPath, fileRegistroInscripciones);
                }
                else
                {
                    // Configurar los ajustes de serialización y deserialización con el formato de fecha personalizado.
                    JsonSerializerSettings settings = new JsonSerializerSettings
                    {
                        DateFormatString = "yyyy-MM-ddTHH:mm:ss"
                    };

                    //stringInscripciones = LeerArchivoJson(fullPath);
                    //if (!string.IsNullOrEmpty(stringInscripciones))
                    //{
                    //    listaInscripciones = JsonConvert.DeserializeObject<List<RegistroDeInscripcion>>(stringInscripciones);
                    //}

                    stringInscripciones = LeerArchivoJson(fullPath);
                    if (!string.IsNullOrEmpty(stringInscripciones))
                    {
                        listaInscripciones = JsonConvert.DeserializeObject<List<RegistroDeInscripcion>>(stringInscripciones, settings);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                // Manejo específico de excepciones para archivo no encontrado.
                Console.WriteLine("Archivo no encontrado: " + ex.Message);
            }
            catch (JsonSerializationException ex)
            {
                // Manejo específico de excepciones para problemas de deserialización JSON.
                Console.WriteLine("Error de deserialización JSON: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones genéricas.
                Console.WriteLine("Error general: " + ex.Message);
            }

            return listaInscripciones;
        }

        internal static void GuardarArchivoJSON(List<RegistroDeInscripcion> registrosInscripcion)
        {
            try
            {
                string pathName = CombinePath(GetPath(), directoryName);

                string fullPath = CombinePath(pathName, fileRegistroInscripciones);

                EscribirArchivoJSON(registrosInscripcion, fullPath);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        private static void EscribirArchivoJSON(List<RegistroDeInscripcion> registrosInscripcion, string fullPath)
        {
            // Configurar los ajustes de serialización con el formato de fecha personalizado.
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                DateFormatString = "yyyy-MM-ddTHH:mm:ss"
            };

            string jsonString = JsonConvert.SerializeObject(registrosInscripcion, Formatting.Indented, settings);

            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.Write(jsonString);
            }

            //string jsonString = JsonConvert.SerializeObject(registrosInscripcion, Formatting.Indented);

            //using (StreamWriter writer = new StreamWriter(fullPath))
            //{
            //    writer.Write(jsonString);
            //}
        }

    }
}
