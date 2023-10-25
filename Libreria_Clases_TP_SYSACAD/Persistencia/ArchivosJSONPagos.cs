using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Persistencia
{
    internal class ArchivosJSONPagos : ArchivosJson
    {
        internal static List<RegistroDePago>? CargarPagosDesdeArchivoJson()
        {

            List<RegistroDePago> listaPagos = new List<RegistroDePago>();

            string stringPagos = "";
            string fullPath = "";

            string pathName = CombinePath(GetPath(), directoryName);

            try
            {
                if (!ValidarSiExisteDirectorio(pathName))
                {
                    CrearDirectorio(pathName);
                }

                fullPath = CombinePath(pathName, fileRegistroPagos);

                bool validacionExisteArchivo = false;
                validacionExisteArchivo = ValidarSiExisteArchivo(fullPath);

                if (!validacionExisteArchivo)
                {
                    CrearArchivo(fullPath, fileRegistroPagos);
                }
                else
                {
                    JsonSerializerSettings settings = new JsonSerializerSettings
                    {
                        DateFormatString = "yyyy-MM-ddTHH:mm:ss"
                    };

                    stringPagos = LeerArchivoJson(fullPath);
                    if (!string.IsNullOrEmpty(stringPagos))
                    {
                        listaPagos = JsonConvert.DeserializeObject<List<RegistroDePago>>(stringPagos, settings);
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

            return listaPagos;
        }

        internal static void GuardarArchivoJSON(List<RegistroDePago> registrosPagos)
        {
            try
            {
                string pathName = CombinePath(GetPath(), directoryName);

                string fullPath = CombinePath(pathName, fileRegistroPagos);

                EscribirArchivoJSON(registrosPagos, fullPath);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        private static void EscribirArchivoJSON(List<RegistroDePago> registrosPagos, string fullPath)
        {
            // Configurar los ajustes de serialización con el formato de fecha personalizado.
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                DateFormatString = "yyyy-MM-ddTHH:mm:ss"
            };

            string jsonString = JsonConvert.SerializeObject(registrosPagos, Formatting.Indented, settings);

            using (var writer = new StreamWriter(fullPath))
            {
                writer.Write(jsonString);
            }
        }
    }
}
