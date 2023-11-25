using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Entidades_Secundarias
{
    public class GestorEstudiantes
    {
        private ConsultasEstudiantes _consultasEstudiantes = new ConsultasEstudiantes();

        public bool BuscarSiUsuarioDebeCambiarContrasenia(string correo)
        {
            return _consultasEstudiantes.BuscarSiUsuarioDebeCambiarContrasenia(correo);
        }

        public Estudiante ObtenerEstudianteSegunLegajo(string legajo)
        {
            return _consultasEstudiantes.ObtenerEstudianteSegunLegajo(legajo);
        }
    }
}
