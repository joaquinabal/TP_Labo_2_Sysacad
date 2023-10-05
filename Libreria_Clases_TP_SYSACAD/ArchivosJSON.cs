using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class ArchivosJson
    {
        protected static readonly string fileEstudiantes = "Alumnos.json";
        protected static string fileCursos = "Cursos.json";
        protected static string fileAdmins = "Admins.json";
        protected static string directoryName = "archivos";



        protected static string LeerArchivoJson(string fullPath)
        {
            string stringJson;

            using (var reader = new StreamReader(fullPath))
            {
                stringJson = reader.ReadToEnd();
            }
            Debug.WriteLine(stringJson);
            return stringJson;
        }

        protected static bool ValidarSiExisteDirectorio(string path)
        {
            if (!Directory.Exists(path))
            {
                return false;
            }

            return true;
        }

        protected static bool ValidarSiExisteArchivo(string pathFile)
        {
            bool respuestaValidacion = false;
            bool valPathFile = File.Exists(pathFile); //ACA ESTA EL ERROR LPM
            if (valPathFile)
            {
                return respuestaValidacion = true;
            }

            return respuestaValidacion;
        }

        protected static void CrearArchivo(string pathArchivo, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(pathArchivo, true, Encoding.Default))
            {
                sw.WriteLine();
            }
        }

        protected static void CrearDirectorio(string path)
        {
            Directory.CreateDirectory(path);
        }

        protected static string CombinePath(string path, string fileName)
        {
            //string nombreSinExtension = fileName.Substring(0, fileName.LastIndexOf(".json"));
            return Path.Combine(path, fileName);
        }

        protected static string GetPath()
        {
            Environment.SpecialFolder folder = Environment.SpecialFolder.MyDocuments;

            return Environment.GetFolderPath(folder);
        }
    }
}