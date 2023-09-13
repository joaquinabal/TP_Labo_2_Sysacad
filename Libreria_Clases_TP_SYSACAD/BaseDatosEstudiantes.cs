using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class BaseDatosEstudiantes
    {
        private List<Estudiante> listaEstudiante = new List<Estudiante>();

        public void IngresarUsuarioBD(Estudiante nuevoEstudiante)
        {
            Guid nuevoGuid = Guid.NewGuid();
            nuevoEstudiante.IdentificadorUnico = nuevoGuid;

            listaEstudiante.Add(nuevoEstudiante);
        }

        public List<Estudiante> Estudiantes
        {
            get
            {
                return listaEstudiante;
            }
        }
    }
}
