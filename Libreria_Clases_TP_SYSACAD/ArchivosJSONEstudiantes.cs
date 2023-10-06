using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{

    public class ArchivosJsonEstudiantes : ArchivosJson
    {

        public static List<Estudiante>? CargarAlumnosDesdeArchivoJson()
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

                    //Creo estudiante por defecto para agilizar debug y testing
                    List<Estudiante> primerEstudiante = new List<Estudiante>();
                    Estudiante estudiantePorDefecto = new Estudiante("Pepe Peposo", "12543658", "Av Santa Fe 1241", "1132519841", "aaaa@hotmail.com", "123456", true);
                    estudiantePorDefecto.AñadirConceptosDePagoIniciales();
                    //estudiantePorDefecto.Contrasenia = Hash.GetHash(estudiantePorDefecto.Contrasenia);
                    //estudiantePorDefecto.Contrasenia = Hash.HashearPassword(estudiantePorDefecto.Contrasenia);
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
            catch (Exception e)
            {

                throw new Exception(e.Message, e.InnerException);
            }         

            return listaEstudiantes;
        }



        public static void GuardarArchivoJSON(List<Estudiante> estudiantes)
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
    
    
