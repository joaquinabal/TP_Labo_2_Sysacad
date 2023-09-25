using System;
using System.IO;
using Newtonsoft.Json;


namespace Libreria_Clases_TP_SYSACAD
{
    public class SerializadorJson
    {
        public List<Estudiante> CargarAlumnosDesdeArchivoJson(string filePath)
        {
            try
            {
                string alumnosJson;

                List<Estudiante> listaEstudiantes = new List<Estudainte>();

                // Verificar si el archivo existe
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("El archivo JSON no existe.", filePath);
                }

                // Leer el contenido del archivo JSON
                alumnosJson = File.ReadAllText(filePath);

                // Deserializar el JSON en un objeto de tipo T
                listaEstudiantes = JsonConvert.DeserializeObject<T>(alumnosJson);

                return jsonObject;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al cargar el archivo JSON
                throw new Exception(ex);
            }
        }
    }
}