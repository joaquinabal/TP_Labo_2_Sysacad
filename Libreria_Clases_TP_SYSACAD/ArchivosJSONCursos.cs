using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    internal class ArchivosJsonCursos : ArchivosJson
    {
        /// <summary>
        /// Carga la lista de cursos desde un archivo JSON, o crea uno nuevo si no existe.
        /// </summary>
        /// <returns>Una lista de objetos Curso.</returns>
        internal static List<Curso>? CargarCursosDesdeArchivoJson()
        {
            List<Curso> listaCursos = new List<Curso>();

            string stringCursos, fullPath;

            string pathName = CombinePath(GetPath(), directoryName);

            try
            {
                if (!ValidarSiExisteDirectorio(pathName))
                {
                    CrearDirectorio(pathName);
                }

                fullPath = CombinePath(pathName, fileCursos);

                if (!ValidarSiExisteArchivo(fullPath))
                {
                    CrearArchivo(fullPath, fileCursos);

                    List<Curso> listaCursosDefecto = GenerarCursosPorDefecto();
                    GuardarArchivoJSON(listaCursosDefecto);

                    foreach (Curso curso in listaCursosDefecto)
                    {
                        listaCursos.Add(curso);
                    }
                }
                else
                {
                    stringCursos = LeerArchivoJson(fullPath);
                    if (!string.IsNullOrEmpty(stringCursos))
                    {
                        listaCursos = JsonConvert.DeserializeObject<List<Curso>>(stringCursos);
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

            return listaCursos;

        }

        /// <summary>
        /// Guarda una lista de cursos en un archivo JSON.
        /// </summary>
        /// <param name="cursos">La lista de cursos a guardar.</param>
        internal static void GuardarArchivoJSON(List<Curso> cursos)
        {
            try
            {
                string pathName = CombinePath(GetPath(), directoryName);

                string fullPath = CombinePath(pathName, fileCursos);

                EscribirArchivoJSON(cursos, fullPath);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message, e.InnerException);
            }
        }

        /// <summary>
        /// Escribe una lista de cursos en un archivo JSON en la ubicación especificada.
        /// </summary>
        /// <param name="cursos">La lista de cursos a escribir.</param>
        /// <param name="fullPath">La ruta completa del archivo JSON.</param
        private static void EscribirArchivoJSON(List<Curso> cursos, string fullPath)
        {
            string jsonString = JsonConvert.SerializeObject(cursos, Formatting.Indented);

            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.Write(jsonString);
            }
        }

        /// <summary>
        /// Genera una lista de cursos por defecto con datos aleatorios.
        /// </summary>
        /// <returns>Una lista de cursos por defecto.</returns>
        private static List<Curso> GenerarCursosPorDefecto()
        {
            string[] nombresCursos =
            {"Matematica", "Sistemas de Procesamiento de Datos", "Ingles 1",
            "Programacion 1", "Laboratorio 1", "Arquitectura y Sistemas Operativos",
            "Estadistica", "Ingles 2", "Programacion 2", "Laboratorio 2", "Metodologia de Investigacion"};

            string[] turnos = { "Mañana", "Tarde", "Noche" };

            List<Curso> cursos = new List<Curso>();

            Random random = new Random();

            foreach (string nombreCurso in nombresCursos)
            {
                foreach (string turno in turnos)
                {
                    int cupoMaximo = random.Next(80, 160);
                    string codigo = GenerarCodigo(nombreCurso, turno);
                    string descripcion = $"1° año {nombreCurso.ToLower()} {turno.ToLower()}";
                    int aula = (turno == "Tarde") ? random.Next(100, 199) : (turno == "Mañana") ? random.Next(200, 299) : random.Next(300, 399);
                    string dia = GenerarDiaAleatorio();

                    Curso curso = new Curso(nombreCurso, codigo, descripcion, cupoMaximo, turno, aula.ToString(), dia);
                    cursos.Add(curso);
                }
            }

            foreach (Curso curso in cursos)
            {
                Debug.WriteLine(curso);
            }

            return cursos;
        }

        /// <summary>
        /// Genera un código de curso a partir del nombre del curso y el turno.
        /// </summary>
        /// <param name="nombreCurso">El nombre del curso.</param>
        /// <param name="turno">El turno del curso.</param>
        /// <returns>El código de curso generado.</returns>
        private static string GenerarCodigo(string nombreCurso, string turno)
        {
            string codigo = $"{nombreCurso.Substring(0, 4)}{turno.Substring(0, 1)}";
            return codigo;
        }

        /// <summary>
        /// Genera un día de la semana aleatorio.
        /// </summary>
        /// <returns>Un día de la semana aleatorio.</returns>
        private static string GenerarDiaAleatorio()
        {
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            Random random = new Random();
            int indice = random.Next(0, dias.Length);
            return dias[indice];
        }
    }
}