    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class ValidadorInputEstudiantes : ValidadorInputs
    {
        public RespuestaValidacionInput ValidarDatosEstudiantes(Dictionary<string, string> diccionarioConCampos)
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
            RespuestaValidacionInput respuestaValidacion = new RespuestaValidacionInput(resultadoCamposVacios, resultadoExistenciaErrores, listaErrores);

            //Devuelvo la respuesta
            return respuestaValidacion;
        }

        public override List<string> ValidarRegex(Dictionary<string, string> diccionarioConCamposIngresados)
        {
            List<string> listaErrores = new List<string>();

            // Validar el nombre 
            if (!Regex.IsMatch(diccionarioConCamposIngresados["nombre"], @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                listaErrores.Add("Nombre");
            }

            // Validar el Legajo
            if (!Regex.IsMatch(diccionarioConCamposIngresados["legajo"], @"^\d{8}$"))
            {
                listaErrores.Add("Legajo");
            }

            //Validar Direccion
            if (!Regex.IsMatch(diccionarioConCamposIngresados["direccion"], @"^[a-zA-Z0-9\s]+$"))
            {
                listaErrores.Add("Dirección");
            }

            // Validar telefono
            if (!Regex.IsMatch(diccionarioConCamposIngresados["telefono"], @"^\d{8}(\d{2})?$"))
            {
                listaErrores.Add("Telefono");
            }

            // Validar correo 
            if (!Regex.IsMatch(diccionarioConCamposIngresados["correo"], @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                listaErrores.Add("Correo");
            }

            // Validar contrasenia
            if (!Regex.IsMatch(diccionarioConCamposIngresados["contrasenia"], @"^[a-zA-Z0-9]{6,}$"))
            {
                listaErrores.Add("Contrasenia");
            }

            return listaErrores;
        }
    }
}
