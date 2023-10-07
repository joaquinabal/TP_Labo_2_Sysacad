using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    internal class ArchivosJsonEstudiantes : ArchivosJson
    {
        /// <summary>
        /// Carga la lista de estudiantes desde un archivo JSON, o crea uno nuevo si no existe.
        /// </summary>
        /// <returns>Una lista de objetos Estudiante.</returns>
        internal static List<Estudiante>? CargarAlumnosDesdeArchivoJson()
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();

            string stringEstudiantes, fullPath;

            string pathName = CombinePath(GetPath(), directoryName);

            try
            {
                if (!ValidarSiExisteDirectorio(pathName))
                {
                    CrearDirectorio(pathName);
                }

                fullPath = CombinePath(pathName, fileEstudiantes);

                if (!ValidarSiExisteArchivo(fullPath))
                {
                    CrearArchivo(fullPath, fileEstudiantes);

                    List<Estudiante> primerEstudiante = new List<Estudiante>();
                    Estudiante estudiantePorDefecto = new Estudiante("Pepe Peposo", "12543658", "Av Santa Fe 1241", "1132519841", "aaaa@hotmail.com", "123456", false);
                    estudiantePorDefecto.AñadirConceptosDePagoIniciales();
                    estudiantePorDefecto.Contrasenia = Hash.HashPassword(estudiantePorDefecto.Contrasenia);

                    primerEstudiante.Add(estudiantePorDefecto);
                    listaEstudiantes.Add(estudiantePorDefecto);
                    GuardarArchivoJSON(primerEstudiante);

                }
                else
                {
                    stringEstudiantes = LeerArchivoJson(fullPath);

                    if (!string.IsNullOrEmpty(stringEstudiantes))
                    {
                        listaEstudiantes = JsonConvert.DeserializeObject<List<Estudiante>>(stringEstudiantes);
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

            return listaEstudiantes;
        }

        /// <summary>
        /// Guarda una lista de estudiantes en un archivo JSON.
        /// </summary>
        /// <param name="estudiantes">La lista de estudiantes a guardar.</param>
        internal static void GuardarArchivoJSON(List<Estudiante> estudiantes)
        {
            try
            {
                string pathName = CombinePath(GetPath(), directoryName);

                string fullPath = CombinePath(pathName, fileEstudiantes);

                EscribirArchivoJSON(estudiantes, fullPath);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        /// <summary>
        /// Escribe una lista de estudiantes en un archivo JSON en la ubicación especificada.
        /// </summary>
        /// <param name="estudiantes">La lista de estudiantes a escribir.</param>
        /// <param name="fullPath">La ruta completa del archivo JSON.</param>
        private static void EscribirArchivoJSON(List<Estudiante> estudiantes, string fullPath)
        {
            string jsonString = JsonConvert.SerializeObject(estudiantes, Formatting.Indented);

            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.Write(jsonString);
            }

        }
    }
}
    
    
