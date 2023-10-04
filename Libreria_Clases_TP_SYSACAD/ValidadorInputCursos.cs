using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class ValidadorInputCursos : ValidadorInputs
    {
        public RespuestaValidacionInput ValidarDatosCurso(Dictionary<string, string> diccionarioConCampos)
        {
            //Recibo el diccionario y meto sus valores a una lista
            List<string> listaCamposIngresados = ObtenerListaDeCamposDesdeDiccionario(diccionarioConCampos);

            //Valido si no hay campos vacios. Si todo esta bien devuelve true
            bool resultadoCamposVacios = ValidarCampos(listaCamposIngresados);

            //Valido que cumplan el regex. Si esta todo bien devuelve una lista vacia
            List<string> listaErrores = ValidarRegex(diccionarioConCampos);

            //Compruebo si la lista de errores esta efectivamente vacia
            bool resultadoExistenciaErrores = ComprobarExistenciaErrores(listaErrores);

            //Creo una nueva instancia de clase RESPUESTA VALIDACION.
            RespuestaValidacionInput respuestaValidacion = new RespuestaValidacionInput(resultadoCamposVacios, resultadoExistenciaErrores ,listaErrores);

            //Devuelvo la respuesta
            return respuestaValidacion;
        }

        public override List<string> ValidarRegex(Dictionary<string, string> diccionarioConCamposIngresados)
        {
            List<string> listaErrores = new List<string>();
            
            // Validar el nombre de la MATERIA 
            if (!Regex.IsMatch(diccionarioConCamposIngresados["nombre"], @"^[a-zA-Z0-9\s]+$"))
            {
                listaErrores.Add("Nombre de la materia");
            }

            // Validar el CODIGO
            if (!Regex.IsMatch(diccionarioConCamposIngresados["codigo"], @"^[a-zA-Z0-9]+$"))
            {
                listaErrores.Add("Codigo");
            }

            // Validar el numero de aula
            if (!Regex.IsMatch(diccionarioConCamposIngresados["aula"], @"^\d{3}$"))
            {
                listaErrores.Add("Número de Aula");
            }

            // Validar Descripcion
            if (!Regex.IsMatch(diccionarioConCamposIngresados["descripcion"], @"^[a-zA-Z0-9ñÑ°\s.,-]+$"))
            {
                listaErrores.Add("Descripcion");
            }

            // Validar Cupo maximo 
            if (!Regex.IsMatch(diccionarioConCamposIngresados["cupoMax"], @"^[0-9]+$"))
            {
                listaErrores.Add("Cupo maximo");
            }

            return listaErrores;
        }

    }
}
