using System;
using System.Collections.Generic;
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
        public void IngresarUsuarioBD(Estudiante nuevoEstudiante)
        {
            //Se genera un identificador unico para el estudiante
            Guid nuevoGuid = Guid.NewGuid();
            //Se le asigna el resultado en su atributo "identificador unico"
            nuevoEstudiante.IdentificadorUnico = nuevoGuid;

            //Agrego el estudiante a la lista
            listaEstudiante.Add(nuevoEstudiante);
        }

        public List<Estudiante> Estudiantes
        {
            get
            {
                return listaEstudiante;
            }
        }

        //Muevo este metodo a la base de datos para que impacte sobre los registros de la lista
        public void AgregarCursoAEstudiante(Estudiante estudianteQueSeInscribe, Curso curso)
        {
            foreach (Estudiante estudiante in listaEstudiante)
            {
                if (estudiante.IdentificadorUnico == estudianteQueSeInscribe.IdentificadorUnico)
                {
                    estudiante.CursosInscriptos.Add(curso);
                }
            }
        }

    }
}
