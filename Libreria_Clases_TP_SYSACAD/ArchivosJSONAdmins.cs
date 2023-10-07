using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    internal class ArchivosJsonAdmins : ArchivosJson
    {
        /// <summary>
        /// Carga la lista de administradores desde un archivo JSON, o crea uno nuevo si no existe.
        /// </summary>
        /// <returns>Una lista de objetos Administrador.</returns>
        internal static List<Administrador>? CargarAdminsDesdeArchivoJson()
        {

            List<Administrador> listaAdmins = new List<Administrador>();

            string stringAdmins = "";
            string fullPath = "";

            string pathName = CombinePath(GetPath(), directoryName);

            try
            {
                if (!ValidarSiExisteDirectorio(pathName))
                {
                    CrearDirectorio(pathName);
                }

                fullPath = CombinePath(pathName, fileAdmins);

                bool validacionExisteArchivo = false;
                validacionExisteArchivo = ValidarSiExisteArchivo(fullPath);


                if (!validacionExisteArchivo)
                {
                    CrearArchivo(fullPath, fileAdmins);

                    List<Administrador> primerAdmin = new List<Administrador>();
                    Administrador adminPorDefecto = new Administrador("johntravolta@hotmail.com", "666666");
                    adminPorDefecto.Contrasenia = Hash.HashPassword(adminPorDefecto.Contrasenia);

                    Debug.WriteLine($"Contrasenia Hasheada por defecto: {adminPorDefecto.Contrasenia}");

                    primerAdmin.Add(adminPorDefecto);
                    listaAdmins.Add(adminPorDefecto);
                    GuardarArchivoJSON(primerAdmin);

                }
                else
                {
                    stringAdmins = LeerArchivoJson(fullPath);
                    if (!string.IsNullOrEmpty(stringAdmins))
                    {
                        listaAdmins = JsonConvert.DeserializeObject<List<Administrador>>(stringAdmins);
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

            return listaAdmins;
        }

        /// <summary>
        /// Guarda una lista de administradores en un archivo JSON.
        /// </summary>
        /// <param name="admins">La lista de administradores a guardar.</param>
        private static void GuardarArchivoJSON(List<Administrador> admins)
        {
            try
            {
                string pathName = CombinePath(GetPath(), directoryName);

                string fullPath = CombinePath(pathName, fileAdmins);

                EscribirArchivoJSON(admins, fullPath);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        /// <summary>
        /// Escribe una lista de administradores en un archivo JSON en la ubicación especificada.
        /// </summary>
        /// <param name="admins">La lista de administradores a escribir.</param>
        /// <param name="fullPath">La ruta completa del archivo JSON.</param>
        private static void EscribirArchivoJSON(List<Administrador> admins, string fullPath)
        {
            using (var writer = new StreamWriter(fullPath))
            {
                var json = System.Text.Json.JsonSerializer.Serialize(admins);
                writer.Write(json);
            }
        }
    }
}