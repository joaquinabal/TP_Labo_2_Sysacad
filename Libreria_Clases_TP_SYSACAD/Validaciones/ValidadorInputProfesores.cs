using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Validaciones
{
    public class ValidadorInputProfesores : ValidadorInputs
    {
        public RespuestaValidacionInput ValidarDatosProfesor(Dictionary<string, string> diccionarioConCampos)
        {
            //Recibo el diccionario y meto sus valores a una lista
            List<string> listaCamposIngresados = ObtenerListaDeCamposDesdeDiccionario(diccionarioConCampos);
            List<string> listaErrores = new List<string>();

            //Valido si no hay campos vacios. Si todo esta bien devuelve true
            bool resultadoCamposVacios = ValidarCampos(listaCamposIngresados);

            if (resultadoCamposVacios)
            {
                //Valido que cumplan el regex. Si esta todo bien devuelve una lista vacia
                listaErrores = ValidarRegex(diccionarioConCampos);
            }

            //Compruebo si la lista de errores esta efectivamente vacia
            bool resultadoExistenciaErrores = ComprobarExistenciaErrores(listaErrores);

            //Creo una nueva instancia de clase RESPUESTA VALIDACION.
            RespuestaValidacionInput respuestaValidacion = new RespuestaValidacionInput(resultadoCamposVacios, resultadoExistenciaErrores, listaErrores);

            //Devuelvo la respuesta
            return respuestaValidacion;
        }

        protected override List<string> ValidarRegex(Dictionary<string, string> diccionarioConCamposIngresados)
        {
            List<string> listaErrores = new List<string>();

            // Valida el nombre (Alfanumerico)
            if (!Regex.IsMatch(diccionarioConCamposIngresados["nombre"], @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                listaErrores.Add("Nombre");
            }

            // Valida correo (Formato correo)
            if (!Regex.IsMatch(diccionarioConCamposIngresados["correo"], @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                listaErrores.Add("Correo");
            }

            //Valida direccion (Alfanumerico)
            if (!Regex.IsMatch(diccionarioConCamposIngresados["direccion"], @"^[a-zA-Z0-9\s]+$"))
            {
                listaErrores.Add("Dirección");
            }

            //Valida direccion (Alfanumerico)
            if (!Regex.IsMatch(diccionarioConCamposIngresados["especializacion"], @"^[a-zA-Z0-9\s]+$"))
            {
                listaErrores.Add("Especializacion");
            }

            // Valida telefono (8 a 10 digitos)
            if (!Regex.IsMatch(diccionarioConCamposIngresados["telefono"], @"^\d{8}(\d{2})?$"))
            {
                listaErrores.Add("Telefono");
            }

            return listaErrores;
        }
    }
}
