using System;
using System.IO;
using Newtonsoft.Json;


namespace Libreria_Clases_TP_SYSACAD
{
    public class SerializadorJson
    {
        public static List<Estudiante> CargarAlumnosDesdeArchivoJson(string filePath)
        {
             string alumnosJson;

             List<Estudiante> listaEstudiantes = new List<Estudiante>();

                // Verificar si el archivo existe
             if (!File.Exists(filePath))
             {
                 return null;
             }

                // Leer el contenido del archivo JSON
             alumnosJson = File.ReadAllText(filePath);

                // Deserializar el JSON en un objeto de tipo T
             listaEstudiantes = JsonConvert.DeserializeObject<List<Estudiante>>(alumnosJson);

             return listaEstudiantes;

        }

        public List<Curso> CargarCursosDesdeArchivoJson(string filePath)
        {
            string cursosJson;

            List<Curso> listaCursos = new List<Curso>();

            // Verificar si el archivo existe
            if (!File.Exists(filePath))
            {
                return null;
            }

            // Leer el contenido del archivo JSON
            cursosJson = File.ReadAllText(filePath);

            // Deserializar el JSON en un objeto de tipo T
            listaCursos = JsonConvert.DeserializeObject<List<Curso>>(cursosJson);

            return listaCursos;

        }

        public List<Administrador> CargarAdminsDesdeArchivoJson(string filePath)
        {
            string adminsJson;

            List<Administrador> listaAdmins = new List<Administrador>();

            // Verificar si el archivo existe
            if (!File.Exists(filePath))
            {
                return null;
            }

            // Leer el contenido del archivo JSON
            adminsJson = File.ReadAllText(filePath);

            // Deserializar el JSON en un objeto de tipo T
            listaAdmins = JsonConvert.DeserializeObject<List<Administrador>>(adminsJson);

            return listaAdmins;

        }
    }
}