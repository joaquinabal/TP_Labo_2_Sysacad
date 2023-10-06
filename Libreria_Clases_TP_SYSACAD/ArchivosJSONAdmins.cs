using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{

    public class ArchivosJsonAdmins : ArchivosJson
    {

        public static List<Administrador>? CargarAdminsDesdeArchivoJson()
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

                //fullPath = pathName + "\\" + fileAdmins;
                fullPath = CombinePath(pathName, fileAdmins);

                bool validacionExisteArchivo = false;
                validacionExisteArchivo = ValidarSiExisteArchivo(fullPath);


                if (!validacionExisteArchivo)
                {
                    CrearArchivo(fullPath, fileAdmins);

                    //Creo estudiante por defecto para agilizar debug y testing
                    List<Administrador> primerAdmin = new List<Administrador>();
                    Administrador adminPorDefecto = new Administrador("johntravolta@hotmail.com", "666666");
                    //adminPorDefecto.Contrasenia = Hash.GetHash(adminPorDefecto.Contrasenia);
                    //adminPorDefecto.Contrasenia = Hash.HashearPassword(adminPorDefecto.Contrasenia);
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
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }        

            return listaAdmins;
        }

        public static void GuardarArchivoJSON(List<Administrador> admins)
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