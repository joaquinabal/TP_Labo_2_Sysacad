using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public static class ArchivosJson
    {
        private static readonly string fileEstudiantes = "Alumnos.json";
        private static readonly string fileCursos = "Cursos.json";
        private static readonly string fileAdmins = "Admins.json";
        private static readonly string directoryName = "archivos";

        public static List<Estudiante>? CargarAlumnosDesdeArchivoJson()
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();

            string stringEstudiantes, fullPath;

            string pathName = CombinePath(GetPath(), directoryName);

            if (!ValidarSiExisteDirectorio(pathName))
            {
                CrearDirectorio(pathName);
            }

            fullPath = CombinePath(pathName, fileEstudiantes);

            if (!ValidarSiExisteArchivo(fullPath))
            {
                CrearArchivo(fullPath, fileEstudiantes);

                List<Estudiante> primerEstudiante = new List<Estudiante>();

                Estudiante estudiantePorDefecto = new Estudiante("pepe", "11", "asda", "51984", "aa", "11", false);
                estudiantePorDefecto.AñadirConceptosDePagoIniciales();
                primerEstudiante.Add(estudiantePorDefecto);

                GuardarArchivoJSON(primerEstudiante);
                listaEstudiantes.Add(estudiantePorDefecto);
            }
            else
            {
                stringEstudiantes = LeerArchivoJson(fullPath);

                if (!string.IsNullOrEmpty(stringEstudiantes))
                {
                    listaEstudiantes = JsonConvert.DeserializeObject<List<Estudiante>>(stringEstudiantes);
                }
            }

            return listaEstudiantes;
        }

        public static List<Curso>? CargarCursosDesdeArchivoJson()
        {
            List<Curso> listaCursos = new List<Curso>();

            string stringCursos, fullPath;

            string pathName = CombinePath(GetPath(), directoryName);

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

            return listaCursos;

        }
        public static List<Administrador>? CargarAdminsDesdeArchivoJson()
        {
            List<Administrador> listaAdmins = new List<Administrador>();

            string stringAdmins, fullPath;

            string pathName = CombinePath(GetPath(), directoryName);

            if (!ValidarSiExisteDirectorio(pathName))
            {
                CrearDirectorio(pathName);
            }

            fullPath = CombinePath(pathName, fileAdmins);

            if (!ValidarSiExisteArchivo(fullPath))
            {
                CrearArchivo(fullPath, fileAdmins);

                GuardarArchivoJSON(new List<Administrador>());
            }
            else
            {
                stringAdmins = LeerArchivoJson(fullPath);
                if (!string.IsNullOrEmpty(stringAdmins))
                {
                    listaAdmins = JsonConvert.DeserializeObject<List<Administrador>>(stringAdmins);
                }

            }

            return listaAdmins;

        }

        public static void GuardarArchivoJSON(List<Estudiante> estudiantes)
        {
            string pathName = CombinePath(GetPath(), directoryName);

            string fullPath = CombinePath(pathName, fileEstudiantes);

            EscribirArchivoJSON(estudiantes, fullPath);

        }

        public static void GuardarArchivoJSON(List<Curso> cursos)
        {
            string pathName = CombinePath(GetPath(), directoryName);

            string fullPath = CombinePath(pathName, fileCursos);

            EscribirArchivoJSON(cursos, fullPath);

        }

        public static void GuardarArchivoJSON(List<Administrador> admins)
        {
            string pathName = CombinePath(GetPath(), directoryName);

            string fullPath = CombinePath(pathName, fileAdmins);

            EscribirArchivoJSON(admins, fullPath);

        }

        private static void EscribirArchivoJSON(List<Curso> cursos, string fullPath)
        {
            string jsonString = JsonConvert.SerializeObject(cursos, Formatting.Indented);

            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.Write(jsonString);
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

        private static void EscribirArchivoJSON(List<Administrador> admins, string fullPath)
        {
            using (var writer = new StreamWriter(fullPath))
            {
                var json = System.Text.Json.JsonSerializer.Serialize(admins);
                writer.Write(json);
            }

        }

        private static string LeerArchivoJson(string fullPath)
        {
            string stringCursos;

            using (var reader = new StreamReader(fullPath))
            {
                stringCursos = reader.ReadToEnd();
            }

            return stringCursos;
        }

        private static bool ValidarSiExisteDirectorio(string path)
        {
            if (!Directory.Exists(path))
            {
                return false;
            }

            return true;
        }

        private static bool ValidarSiExisteArchivo(string pathFile)
        {
            if (!File.Exists(pathFile))
            {
                return false;
            }

            return true;
        }

        private static void CrearArchivo(string pathArchivo, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(pathArchivo, true, Encoding.Default))
            {
                sw.WriteLine();
            }
        }

        private static void CrearDirectorio(string path)
        {
            Directory.CreateDirectory(path);
        }

        private static string CombinePath(string path, string fileName)
        {
            //string nombreSinExtension = fileName.Substring(0, fileName.LastIndexOf(".json"));
            return Path.Combine(path, fileName);
        }

        private static string GetPath()
        {
            Environment.SpecialFolder folder = Environment.SpecialFolder.MyDocuments;

            return Environment.GetFolderPath(folder);
        }

        public static List<Curso> GenerarCursosPorDefecto()
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

        public static string GenerarCodigo(string nombreCurso, string turno)
        {
            string codigo = $"{nombreCurso.Substring(0, 4)}{turno.Substring(0, 1)}";
            return codigo;
        }

        public static string GenerarDiaAleatorio()
        {
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            Random random = new Random();
            int indice = random.Next(0, dias.Length);
            return dias[indice];
        }

    }
}
