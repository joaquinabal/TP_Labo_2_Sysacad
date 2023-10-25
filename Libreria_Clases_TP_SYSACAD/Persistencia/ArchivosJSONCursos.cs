using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Persistencia
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
        //private static void EscribirArchivoJSON(List<Curso> cursos, string fullPath)
        //{
        //    string jsonString = JsonConvert.SerializeObject(cursos, Formatting.Indented);

        //    using (StreamWriter writer = new StreamWriter(fullPath))
        //    {
        //        writer.Write(jsonString);
        //    }
        //}

        private static void EscribirArchivoJSON(List<Curso> cursos, string fullPath)
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(cursos, Formatting.Indented);

                using (StreamWriter writer = new StreamWriter(fullPath))
                {
                    writer.Write(jsonString);
                }
            }
            catch (JsonSerializationException ex)
            {
                Console.WriteLine("Error de deserialización JSON: " + ex.Message);
                throw;  // Relanza la excepción para que puedas ver el stack trace completo en la consola
            }
        }

        private static List<Curso> GenerarCursosPorDefecto()
        {
            List<string> materiasIniciales = new List<string>
            {
                "MATEMATICA", "SISTEMASDEPROCESAMIENTODEDATOS", "INGLES1",
                "PROGRAMACION1", "LABORATORIO1"
            };

            List<string> materiasIntermedias = new List<string>
            {
                "ARQUITECTURAYSISTEMASOPERATIVOS", "ESTADISTICA", "INGLES2",
                "PROGRAMACION2", "LABORATORIO2", "METODOLOGIADELAINVESTIGACION",
            };

            List<string> materiasFinales = new List<string>
            {
                "METODOLOGIADESISTEMAS1", "PROGRAMACIONAVANZADA1", "REDES", "INGLESTECNICOAVANZADO1",
                "PROYECTOSINFORMATICOS", "SEMINARIO", "INGLESTECNICOAVANZADO2"
            };

            string[] nombresCursos =
            {
                "Matematica", "Sistemas de Procesamiento de Datos", "Ingles 1",
                "Programacion 1", "Laboratorio 1", "Arquitectura y Sistemas Operativos",
                "Estadistica", "Ingles 2", "Programacion 2", "Laboratorio 2", "Metodologia de la Investigacion",
                "Metodologia de Sistemas 1", "Programacion Avanzada 1", "Redes", "Ingles Tecnico Avanzado 1",
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
                    string descripcion = $"{nombreCurso.ToLower()} {turno.ToLower()}";
                    int aula = turno == "Tarde" ? random.Next(100, 199) : turno == "Mañana" ? random.Next(200, 299) : random.Next(300, 399);
                    string dia = GenerarDiaAleatorio();
                    Carrera carrera = ObtenerCarrera(nombreCurso);
                    string codigo = ObtenerCodigoDeCurso(nombreCurso, turno);

                    Curso curso = new Curso(nombreCurso, codigo, descripcion, cupoMaximo, turno, aula.ToString(), dia, carrera);

                    //Solo asigno creditos y promedio a aquellas materias intermedias y finales
                    int creditosRequeridos = 0;
                    double promedioRequerido = 0;

                    if (materiasIntermedias.Contains(curso.CodigoFamilia) || materiasFinales.Contains(curso.CodigoFamilia))
                    {
                        creditosRequeridos = random.Next(1, 1000);  // Rango diferente para cursos intermedios y finales
                        promedioRequerido = Math.Round(random.NextDouble() * 10, 2);
                    }

                    curso.CreditosRequeridos = creditosRequeridos;
                    curso.PromedioRequerido = promedioRequerido;

                    List<string> codigosCursosCorrelatividades = new List<string>();

                    // Si la materia iterada se encuentra entre las iniciales
                    if (materiasIniciales.Contains(curso.CodigoFamilia))
                    {
                        //No hago nada
                    }
                    // Si la materia iterada se encuentra entre las intermedias
                    else if (materiasIntermedias.Contains(curso.CodigoFamilia))
                    {
                        // Asignar correlatividades intermedias (basadas en materias iniciales)
                        codigosCursosCorrelatividades = materiasIniciales;
                    }
                    // Si la materia iterada se encuentra entre las finales
                    else if (materiasFinales.Contains(curso.CodigoFamilia))
                    {
                        // Asignar correlatividades finales (basadas en todas las materias)
                        codigosCursosCorrelatividades = materiasIntermedias;
                    }

                    curso.Correlatividades = codigosCursosCorrelatividades;

                    cursos.Add(curso);
                }
            }

            return cursos;
        }

        private static string ObtenerCodigoDeCurso(string nombre, string turno)
        {
            // Divido el nombre del curso en palabras
            string[] palabras = nombre.Split(' ');
            string codigo = "";

            if (palabras.Length == 1)
            {
                codigo = palabras[0].Substring(0, Math.Min(4, palabras[0].Length)); ;
            }
            else if (palabras.Length > 1)
            {
                bool contieneNumero = palabras.Any(palabra => int.TryParse(palabra, out _));

                if (!contieneNumero)
                {
                    string iniciales = "";

                    foreach (string palabra in palabras)
                    {
                        iniciales += palabra[0];
                    }
                    codigo = iniciales;
                }
                else
                {
                    List<string> palabrasSinNumeros = new List<string>();

                    foreach (string palabra in palabras)
                    {
                        if (Regex.IsMatch(palabra, "^[A-Za-z]+$"))
                        {
                            palabrasSinNumeros.Add(palabra);
                        }
                    }

                    if (palabrasSinNumeros.Count == 1)
                    {
                        codigo = palabrasSinNumeros[0].Substring(0, Math.Min(4, palabras[0].Length)); ;
                    }
                    else if (palabrasSinNumeros.Count > 1)
                    {
                        string iniciales = "";

                        foreach (string palabra in palabrasSinNumeros)
                        {
                            iniciales += palabra[0];
                        }
                        codigo = iniciales;
                    }
                }
            }

            // Verificar si hay un número en el nombre del curso y agregarlo
            if (nombre.Any(char.IsDigit))
            {
                string numero = new string(nombre.Where(char.IsDigit).ToArray());
                codigo += numero;
            }

            // Agregar la primera letra del turno
            codigo += turno[0];

            return codigo;
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
        /// Genera un día de la semana aleatorio.
        /// </summary>
        /// <returns>Un día de la semana aleatorio.</returns>
        private static string GenerarDiaAleatorio()
        {
            string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
            Random random = new Random();
            int indice = random.Next(0, dias.Length);
            return dias[indice];
        }
    }
}