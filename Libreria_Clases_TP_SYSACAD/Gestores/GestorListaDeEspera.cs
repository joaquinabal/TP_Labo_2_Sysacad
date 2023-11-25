using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Gestores
{
    internal class GestorListaDeEspera
    {
        private ConsultasCursos _consultasCursos = new ConsultasCursos();

        public RespuestaValidacionInput ValidarInputListaEspera(string legajoDelEstudianteAAgregar, Curso cursoSeleccionado)
        {
            ValidadorAdicionDeAlumnoEnListaDeEspera validadorDelInputLegajo = new ValidadorAdicionDeAlumnoEnListaDeEspera();
            RespuestaValidacionInput respuestaValidacion = validadorDelInputLegajo.ValidarAdicionAlumnoEnLista(legajoDelEstudianteAAgregar, cursoSeleccionado);

            return respuestaValidacion;
        }

        public async Task<bool> GestionarActualizacionListaEspera(Curso cursoSeleccionado, Dictionary<string, DateTime> alumnosEnListaDeEspera)
        {
            bool resultadoActualizacion = false;

            if (cursoSeleccionado != null)
            {
                await _consultasCursos.ActualizarListaDeEsperaDeCurso(cursoSeleccionado, alumnosEnListaDeEspera);
                resultadoActualizacion = true;
            }

            return resultadoActualizacion;
        }
    }
}
