using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
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


        //private static List<Curso> GenerarCursosPorDefecto()
        //{
        //    string[] nombresCursos =
        //    {
        //    "Matematica", "Sistemas de Procesamiento de Datos", "Ingles 1",
        //    "Programacion 1", "Laboratorio 1", "Arquitectura y Sistemas Operativos",
        //    "Estadistica", "Ingles 2", "Programacion 2", "Laboratorio 2", "Metodologia de Investigacion",
        //    "Metodologia de Sistemas 2", "Programacion Avanzada 1", "Redes", "Ingles Tecnico Avanzado 1",
        //    "Proyectos Informaticos", "Seminario", "Ingles Tecnico Avanzado 2"
        //    };

        //    string[] turnos = { "Mañana", "Tarde", "Noche" };

        //    List<Curso> cursos = new List<Curso>();

        //    Random random = new Random();

        //    foreach (string nombreCurso in nombresCursos)
        //    {
        //        foreach (string turno in turnos)
        //        {
        //            int cupoMaximo = random.Next(80, 160);
        //            string codigo = GenerarCodigo(nombreCurso, turno);
        //            string descripcion = $"1° año {nombreCurso.ToLower()} {turno.ToLower()}";
        //            int aula = (turno == "Tarde") ? random.Next(100, 199) : (turno == "Mañana") ? random.Next(200, 299) : random.Next(300, 399);
        //            string dia = GenerarDiaAleatorio();
        //            Carrera carrera = ObtenerCarrera(nombreCurso);

        //            Curso curso = new Curso(nombreCurso, codigo, descripcion, cupoMaximo, turno, aula.ToString(), dia, carrera);
        //            cursos.Add(curso);
        //        }
        //    }

        //    return cursos;
        //}

        private static List<Curso> GenerarCursosPorDefecto()
        {
            List<string> materiasIniciales = new List<string>
            {
                "Matematica", "Sistemas de Procesamiento de Datos", "Ingles 1",
                "Programacion 1", "Laboratorio 1"
            };

            List<string> materiasIntermedias = new List<string>
            {
                "Arquitectura y Sistemas Operativos", "Estadistica", "Ingles 2",
                "Programacion 2", "Laboratorio 2", "Metodologia de Investigacion"
            };

            List<string> materiasFinales = new List<string>
            {
                "Metodologia de Sistemas 2", "Programacion Avanzada 1", "Redes",
                "Ingles Tecnico Avanzado 1", "Proyectos Informaticos", "Seminario",
                "Ingles Tecnico Avanzado 2"
            };

            string[] nombresCursos =
            {
                "Matematica", "Sistemas de Procesamiento de Datos", "Ingles 1",
                "Programacion 1", "Laboratorio 1", "Arquitectura y Sistemas Operativos",
                "Estadistica", "Ingles 2", "Programacion 2", "Laboratorio 2", "Metodologia de Investigacion",
                "Metodologia de Sistemas 2", "Programacion Avanzada 1", "Redes", "Ingles Tecnico Avanzado 1",
                "Proyectos Informaticos", "Seminario", "Ingles Tecnico Avanzado 2"
            };

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
                    Carrera carrera = ObtenerCarrera(nombreCurso);
                    int creditosRequeridos = random.Next(0, 1000);
                    double promedioRequerido = random.NextDouble() * 10;

                    Curso curso = new Curso(nombreCurso, codigo, descripcion, cupoMaximo, turno, aula.ToString(), dia, carrera);

                    curso.CreditosRequeridos = creditosRequeridos;
                    curso.PromedioRequerido = promedioRequerido;

                    List<Curso> cursosCorrelatividades = new List<Curso>();

                    if (materiasIniciales.Contains(nombreCurso))
                    {
                        //No hago nada
                    }
                    else if (materiasIntermedias.Contains(nombreCurso))
                    {
                        // Asignar correlatividades intermedias (basadas en materias iniciales)
                        cursosCorrelatividades = cursos.Where(c => materiasIniciales.Contains(c.Nombre)).ToList();
                    }
                    else if (materiasFinales.Contains(nombreCurso))
                    {
                        // Asignar correlatividades finales (basadas en todas las materias)
                        cursosCorrelatividades = cursos.ToList();
                    }

                    curso.Correlatividades = cursosCorrelatividades;

                    cursos.Add(curso);
                }
            }

            return cursos;
        }

        private static Carrera ObtenerCarrera(string nombreMateria)
        {
            if (nombreMateria == "Matematica" || nombreMateria == "Sistemas de Procesamiento de Datos" || nombreMateria == "Ingles 1" ||
                nombreMateria == "Programacion 1" || nombreMateria == "Laboratorio 1" || nombreMateria == "Arquitectura y Sistemas Operativos" ||
                nombreMateria == "Estadistica" || nombreMateria == "Ingles 2" || nombreMateria == "Programacion 2" || nombreMateria == "Laboratorio 2" ||
                nombreMateria == "Metodologia de Investigacion")
            {
                return Carrera.TUP;
            }
            else
            {
                return Carrera.TUSI;
            }
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