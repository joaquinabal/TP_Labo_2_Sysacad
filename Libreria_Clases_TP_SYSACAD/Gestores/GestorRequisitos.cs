using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Gestores
{
    public class GestorRequisitos
    {
        private ConsultasCursos _consultasCursos = new ConsultasCursos();

        /////////////////////////////// GESTION ANTE CONFIRMACION DE REQUISITOS ////////////////////////////////

        public async Task<RespuestaValidacionInput> GestionarConfirmacionRequisitos(Dictionary<string, string> camposIngresados, string CFCursoAModificar, List<string> CFcorrelatividades, string creditos, string promedio)
        {
            RespuestaValidacionInput respuestaValidacion = ValidarRequisitos(camposIngresados);

            if (respuestaValidacion.AusenciaCamposVacios && !respuestaValidacion.ExistenciaErrores)
            {
                await _consultasCursos.ActualizarRequisitosACursos(CFCursoAModificar, CFcorrelatividades, int.Parse(creditos), double.Parse(promedio));
            }

            return respuestaValidacion;
        }

        private RespuestaValidacionInput ValidarRequisitos(Dictionary<string, string> camposIngresados)
        {
            ValidadorInputGenerico validacionInputRequisitos = new ValidadorInputGenerico();
            RespuestaValidacionInput respuestaValidacion = validacionInputRequisitos.ValidarDatos(camposIngresados, ModoValidacionInput.CursoRequisitos);

            return respuestaValidacion;
        }
    }
}
