using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_Clases_TP_SYSACAD.Persistencia;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Herramientas;

namespace Libreria_Clases_TP_SYSACAD.Tablas
{
    public class BaseDatosEstudiantes
    {
        //Lista que contiene todos los estudiantes
        private List<Estudiante> listaEstudiante = new List<Estudiante>();

        /// <summary>
        /// Constructor de la clase BaseDatosEstudiantes.
        /// Inicializa la lista de estudiantes cargándola desde un archivo JSON.
        /// </summary>
        internal BaseDatosEstudiantes()
        {
            listaEstudiante = ArchivosJsonEstudiantes.CargarAlumnosDesdeArchivoJson();
        }

        ////////////////////////////////CRUD DEL ESTUDIANTE/////////////////////////////////////////////////

        ///////////////////////CREATE

        /// <summary>
        /// Agrega un nuevo estudiante a la base de datos.
        /// </summary>
        /// <param name="nuevoEstudiante">El estudiante a ser agregado.</param>
        internal void IngresarUsuarioBD(Estudiante nuevoEstudiante)
        {
            //Se genera un identificador unico para el estudiante
            Guid nuevoGuid = Guid.NewGuid();
            //Se le asigna el resultado en su atributo "identificador unico"
            nuevoEstudiante.IdentificadorUnico = nuevoGuid;

            //Se hashea su contraseña
            nuevoEstudiante.Contrasenia = Hash.HashPassword(nuevoEstudiante.Contrasenia);
            //Se agrega los conceptos de pago.
            nuevoEstudiante.AñadirConceptosDePagoIniciales();

            //Agrego el estudiante a la lista
            listaEstudiante.Add(nuevoEstudiante);
            ArchivosJsonEstudiantes.GuardarArchivoJSON(listaEstudiante);
        }

        ///////////////////////READ

        /// <summary>
        /// Busca un usuario en la base de datos por correo y contraseña.
        /// </summary>
        /// <param name="correo">El correo del usuario.</param>
        /// <param name="contrasenia">La contraseña del usuario.</param>
        /// <returns>True si se encuentra un usuario con las credenciales proporcionadas, False si no.</returns>
        internal bool BuscarUsuarioCredencialesBD(string correo, string contrasenia)
        {
            bool resultadoBusqueda = false;

            foreach (Estudiante estudiante in listaEstudiante)
            {
                bool comparacionContrasenias = Hash.VerifyPassword(contrasenia, estudiante.Contrasenia);

                if (estudiante.Correo == correo && comparacionContrasenias)
                {
                    resultadoBusqueda = true;
                }
            }

            return resultadoBusqueda;
        }

        /// <summary>
        /// Busca un usuario en la base de datos por correo y legajo.
        /// </summary>
        /// <param name="correo">El correo del usuario.</param>
        /// <param name="legajo">El legajo del usuario.</param>
        /// <returns>True si se encuentra un usuario con las credenciales proporcionadas, False si no.</returns>
        internal bool BuscarUsuarioExistenteBD(string correo, string legajo)
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

        /// <summary>
        /// Busca si un usuario debe cambiar su contraseña.
        /// </summary>
        /// <param name="correo">El correo del usuario.</param>
        /// <returns>True si el usuario debe cambiar su contraseña, False si no.</returns>
        public bool BuscarSiUsuarioDebeCambiarContrasenia(string correo)
        {
            bool resultadoBusqueda = false;

            foreach (Estudiante estudiante in listaEstudiante)
            {
                if (estudiante.Correo == correo && estudiante.DebeCambiarContrasenia == true)
                {
                    resultadoBusqueda = true;
                }
            }

            return resultadoBusqueda;
        }

        public Estudiante ObtenerEstudianteSegunLegajo(string legajo)
        {
            Estudiante estudianteADevolver = null;

            foreach (Estudiante estudiante in listaEstudiante)
            {
                if (estudiante.Legajo == legajo)
                {
                    estudianteADevolver = estudiante;
                }
            }

            return estudianteADevolver;
        }

        ///////////////////////UPDATE

        /// <summary>
        /// Agrega un curso a la lista de cursos en los cuales se encuentra inscrito un estudiante.
        /// </summary>
        /// <param name="estudianteQueSeInscribe">El estudiante al que se le agrega el curso.</param>
        /// <param name="curso">El curso a ser agregado al estudiante.</param>
        internal void AgregarCursoAEstudiante(Estudiante estudianteQueSeInscribe, Curso curso)
        {
            foreach (Estudiante estudiante in listaEstudiante)
            {
                if (estudiante.IdentificadorUnico == estudianteQueSeInscribe.IdentificadorUnico)
                {
                    estudiante.CursosInscriptos.Add(curso);
                }
            }
            ArchivosJsonEstudiantes.GuardarArchivoJSON(listaEstudiante);
        }



        /// <summary>
        /// Cambia la contraseña de un estudiante y marca que no debe cambiarla nuevamente.
        /// </summary>
        /// <param name="correo">El correo del estudiante.</param>
        /// <param name="nuevaContrasenia">La nueva contraseña del estudiante.</param>
        public void CambiarContraseñaAEstudiante(string correo, string nuevaContrasenia)
        {
            string nuevaContraseniaHasheada = Hash.HashPassword(nuevaContrasenia);

            foreach (Estudiante estudiante in listaEstudiante)
            {
                if (estudiante.Correo == correo && estudiante.DebeCambiarContrasenia == true)
                {
                    estudiante.Contrasenia = nuevaContraseniaHasheada;
                    estudiante.DebeCambiarContrasenia = false;
                }
            }

            ArchivosJsonEstudiantes.GuardarArchivoJSON(listaEstudiante);
        }

        /// <summary>
        /// Elimina un curso de inscripción de todos los estudiantes que lo tengan inscrito.
        /// </summary>
        /// <param name="codigo">El código del curso que se desea eliminar.</param>
        internal void EliminarCursoAEstudiante(string codigo)
        {
            foreach (Estudiante estudiante in listaEstudiante)
            {
                // Creo una lista temporal para almacenar los cursos que serán eliminados.
                List<Curso> cursosAEliminar = new List<Curso>();

                foreach (Curso curso in estudiante.CursosInscriptos)
                {
                    // Verifico si el curso tiene el código que deseamos eliminar.
                    if (curso.Codigo == codigo)
                    {
                        cursosAEliminar.Add(curso);
                    }
                }

                foreach (Curso cursoAEliminar in cursosAEliminar)
                {
                    estudiante.CursosInscriptos.Remove(cursoAEliminar);
                }
            }
        }

        //Getters y setters
        public List<Estudiante> Estudiantes { get { return listaEstudiante; } }
    }
}
