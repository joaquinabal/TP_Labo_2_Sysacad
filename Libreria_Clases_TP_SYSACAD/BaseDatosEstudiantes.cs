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

            //Se hashea su contraseña
            //nuevoEstudiante.Contrasenia = Hash.GetHash(nuevoEstudiante.Contrasenia);
            //nuevoEstudiante.Contrasenia = Hash.HashearPassword(nuevoEstudiante.Contrasenia);



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

        public bool BuscarUsuarioCredencialesBD(string correo, string contrasenia)
        {
            bool resultadoBusqueda = false;

            //Hasheo la contrasenia que ingresa en el LogIn
            //string contraseniaHasheada = Hash.GetHash(contraseña);
            //string contraseniaHasheada = Hash.HashearPassword(contrasenia);

            foreach (Estudiante estudiante in listaEstudiante)
            {
                //Comparo la contrasenia ingresada en el LogIn con la existente en la BD
                // bool comparacionContrasenias = Hash.CompararHash(contraseniaHasheada, estudiante.Contrasenia);
                //bool comparacionContrasenias = Hash.VerificarHasheo(contraseniaHasheada, estudiante.Contrasenia);

                if (estudiante.Correo == correo && estudiante.Contrasenia == contrasenia /*comparacionContrasenias*/)
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

        public bool BuscarSiUsuarioDebeCambiarContrasenia (string correo)
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

        public void CambiarContraseñaAEstudiante (string correo, string nuevaContrasenia)
        {
            //Hasheo la contrasenia que ingresa en el LogIn
            //string nuevaContraseniaHasheada = Hash.HashearPassword(nuevaContrasenia);

            foreach (Estudiante estudiante in listaEstudiante)
            {
                if (estudiante.Correo == correo && estudiante.DebeCambiarContrasenia == true)
                {
                    //estudiante.Contrasenia = nuevaContraseniaHasheada;
                    estudiante.Contrasenia = nuevaContrasenia;
                    estudiante.DebeCambiarContrasenia = false;
                }
            }

            ArchivosJson.GuardarArchivoJSON(listaEstudiante);
        }

        //Getters y setters
        public List<Estudiante> Estudiantes { get { return listaEstudiante; } }
    }
}
