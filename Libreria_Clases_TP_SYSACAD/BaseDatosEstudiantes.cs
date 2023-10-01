using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class BaseDatosEstudiantes
    {
        //Lista que contiene todos los estudiantes
        private List<Estudiante> listaEstudiante = new List<Estudiante>();

        //Al instanciarse un estudiante se llama a este metodo para ingresarlo a la BD

        public BaseDatosEstudiantes()
        {
            this.listaEstudiante = ArchivosJson.CargarAlumnosDesdeArchivoJson();
        }

        public void IngresarUsuarioBD(Estudiante nuevoEstudiante)
        {
            //Se genera un identificador unico para el estudiante
            Guid nuevoGuid = Guid.NewGuid();
            //Se le asigna el resultado en su atributo "identificador unico"
            nuevoEstudiante.IdentificadorUnico = nuevoGuid;

            //Agrego el estudiante a la lista
            listaEstudiante.Add(nuevoEstudiante);
            ArchivosJson.GuardarArchivoJSON(listaEstudiante);
        }

        //Agrego el curso a la lista de cursos en los cuales se encuentra inscripto el estudiante
        public void AgregarCursoAEstudiante(Estudiante estudianteQueSeInscribe, Curso curso)
        {
            foreach (Estudiante estudiante in listaEstudiante)
            {
                if (estudiante.IdentificadorUnico == estudianteQueSeInscribe.IdentificadorUnico)
                {
                    estudiante.CursosInscriptos.Add(curso);
                }
            }
            ArchivosJson.GuardarArchivoJSON(listaEstudiante);
        }

        public bool BuscarUsuarioCredencialesBD(string correo, string contraseña)
        {

            bool resultadoBusqueda = false;

            foreach (Estudiante estudiante in listaEstudiante)
            {
                if (estudiante.Correo == correo && estudiante.Contrasenia == contraseña)
                {
                    resultadoBusqueda = true;
                }
            }

            return resultadoBusqueda;
        }

        public bool BuscarUsuarioExistenteBD(string correo, string legajo)
        {
            bool resultadoBusqueda = false;

            foreach (Estudiante estudiante in listaEstudiante)
            {
                if (estudiante.Correo == correo && estudiante.Legajo == legajo)
                {
                    resultadoBusqueda = true;
                }
            }
            return resultadoBusqueda;
        }

        //Getters y setters
        public List<Estudiante> Estudiantes { get { return listaEstudiante; } }
    }
}
