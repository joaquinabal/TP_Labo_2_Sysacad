using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Libreria_Clases_TP_SYSACAD.Persistencia
//{
//    internal class ArchivosJson
//    {
//        protected static string fileRegistroExcepciones = "RegistroExcepciones.json";
//        protected static string generalDirectoryName = "SYSACAD";
//        protected static string excepcionesDirectoryName = "Excepciones";

//        /// <summary>
//        /// Lee el contenido de un archivo JSON.
//        /// </summary>
//        /// <param name="fullPath">La ruta completa del archivo JSON.</param>
//        /// <returns>El contenido del archivo como una cadena JSON.</returns>
//        protected static string LeerArchivoJson(string fullPath)
//        {
//            string stringJson;

//            using (var reader = new StreamReader(fullPath))
//            {
//                stringJson = reader.ReadToEnd();
//            }
//            return stringJson;
//        }

//        /// <summary>
//        /// Verifica si un directorio existe en el sistema de archivos.
//        /// </summary>
//        /// <param name="path">La ruta del directorio a verificar.</param>
//        /// <returns>True si el directorio existe, False si no existe.</returns>
//        protected static bool ValidarSiExisteDirectorio(string path)
//        {
//            if (!Directory.Exists(path))
//            {
//                return false;
//            }

//            return true;
//        }


//        /// <summary>
//        /// Crea un archivo vacío en la ubicación especificada.
//        /// </summary>
//        /// <param name="pathArchivo">La ruta completa del archivo a crear.</param>
//        /// <param name="fileName">El nombre del archivo a crear.</param>
//        protected static void CrearArchivo(string pathArchivo, string fileName)
//        {
//            using (StreamWriter sw = new StreamWriter(pathArchivo, true, Encoding.Default))
//            {
//                sw.WriteLine();
//            }
//        }

//        /// <summary>
//        /// Combina una ruta de directorio y un nombre de archivo para formar una ruta completa de archivo.
//        /// </summary>
//        /// <param name="path">La ruta del directorio.</param>
//        /// <param name="fileName">El nombre del archivo.</param>
//        /// <returns>La ruta completa del archivo combinado.</returns>
//        protected static string CombinePath(string path, string fileName)
//        {
//            return Path.Combine(path, fileName);
//        }

//        /// <summary>
//        /// Obtiene la ruta del directorio de documentos especiales del usuario actual.
//        /// </summary>
//        /// <returns>La ruta del directorio de documentos del usuario.</returns>
//        protected static string GetPath()
//        {
//            Environment.SpecialFolder folder = Environment.SpecialFolder.MyDocuments;

//            return Environment.GetFolderPath(folder);
//        }
//    }
//}