using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{

    public class ArchivosJsonCursos : ArchivosJson
    {

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


        public static void GuardarArchivoJSON(List<Curso> cursos)
        {
            string pathName = CombinePath(GetPath(), directoryName);

            string fullPath = CombinePath(pathName, fileCursos);

            EscribirArchivoJSON(cursos, fullPath);

        }


        private static void EscribirArchivoJSON(List<Curso> cursos, string fullPath)
        {
            string jsonString = JsonConvert.SerializeObject(cursos, Formatting.Indented);

            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.Write(jsonString);
            }

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