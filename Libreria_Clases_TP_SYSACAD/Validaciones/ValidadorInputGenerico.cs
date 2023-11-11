using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Validaciones
{
    public class ValidadorInputGenerico : ValidadorInputs
    {
        public RespuestaValidacionInput ValidarDatos(Dictionary<string, string> diccionarioConCampos, ModoValidacionInput modo)
        {
            //Recibo el diccionario y meto sus valores a una lista
            List<string> listaCamposIngresados = ObtenerListaDeCamposDesdeDiccionario(diccionarioConCampos);
            List<string> listaErrores = new List<string>();

            //Valido si no hay campos vacios. Si todo esta bien devuelve true
            bool resultadoCamposVacios = ValidarCampos(listaCamposIngresados);

            if (resultadoCamposVacios)
            {
                //Valido que cumplan el regex. Si esta todo bien devuelve una lista vacia
                listaErrores = ValidarRegex(diccionarioConCampos, modo);
            }

            //Compruebo si la lista de errores esta efectivamente vacia
            bool resultadoExistenciaErrores = ComprobarExistenciaErrores(listaErrores);

            //Creo una nueva instancia de clase RESPUESTA VALIDACION.
            RespuestaValidacionInput respuestaValidacion = new RespuestaValidacionInput(resultadoCamposVacios, resultadoExistenciaErrores, listaErrores);

            //Devuelvo la respuesta
            return respuestaValidacion;
        }

        protected override List<string> ValidarRegex(Dictionary<string, string> diccionarioConCamposIngresados, ModoValidacionInput modo)
        {
            List<string> listaErrores = new List<string>();

            switch (modo)
            {
                case ModoValidacionInput.CursoAgregarOEditar:
                    ValidarAlfanumerico("nombre", diccionarioConCamposIngresados, listaErrores, "Nombre de la materia");
                    ValidarAlfanumerico("codigo", diccionarioConCamposIngresados, listaErrores, "Codigo");
                    ValidarNumeroExacto("aula", diccionarioConCamposIngresados, 3, listaErrores, "Número de Aula");
                    ValidarAlfanumerico("descripcion", diccionarioConCamposIngresados, listaErrores, "Descripcion");
                    ValidarNumerico("cupoMax", diccionarioConCamposIngresados, listaErrores, "Cupo maximo");
                    break;
                case ModoValidacionInput.CursoRequisitos:
                    ValidarNumeroRango("creditos", diccionarioConCamposIngresados,0, 4, listaErrores, "Creditos");
                    ValidarNumeroConDecimal("promedio", diccionarioConCamposIngresados, 10, listaErrores, "Promedio");
                    break;
                case ModoValidacionInput.Estudiantes:
                    ValidarAlfanumerico("nombre", diccionarioConCamposIngresados, listaErrores, "Nombre");
                    ValidarNumeroExacto("legajo", diccionarioConCamposIngresados, 8, listaErrores, "Legajo");
                    ValidarAlfanumerico("direccion", diccionarioConCamposIngresados, listaErrores, "Dirección");
                    ValidarNumeroRango("telefono", diccionarioConCamposIngresados, 8, 10, listaErrores, "Telefono");
                    ValidarCorreo("correo", diccionarioConCamposIngresados, listaErrores, "Correo");
                    ValidarMinLongitud("contrasenia", diccionarioConCamposIngresados, 6, listaErrores, "Contrasenia");
                    break;
                case ModoValidacionInput.MediosPagoTarjeta:
                    ValidarAlfanumerico("nombre", diccionarioConCamposIngresados, listaErrores, "Nombre");
                    ValidarNumeroExacto("numero", diccionarioConCamposIngresados, 16, listaErrores, "Numero de Tarjeta");
                    ValidarFormatoFecha("vencimiento", diccionarioConCamposIngresados, listaErrores, "Fecha de Vencimiento");
                    ValidarNumeroExacto("codigo", diccionarioConCamposIngresados, 3, listaErrores, "Codigo de Seguridad");
                    break;
                case ModoValidacionInput.MediosPagoTransferencia:
                    ValidarAlfanumerico("nombre", diccionarioConCamposIngresados, listaErrores, "Nombre");
                    ValidarNumeroExacto("CBU", diccionarioConCamposIngresados, 22, listaErrores, "CBU");
                    break;
                case ModoValidacionInput.Profesores:
                    ValidarAlfanumerico("nombre", diccionarioConCamposIngresados, listaErrores, "Nombre");
                    ValidarCorreo("correo", diccionarioConCamposIngresados, listaErrores, "Correo");
                    ValidarAlfanumerico("direccion", diccionarioConCamposIngresados, listaErrores, "Dirección");
                    ValidarAlfanumerico("especializacion", diccionarioConCamposIngresados, listaErrores, "Especializacion");
                    ValidarNumeroRango("telefono", diccionarioConCamposIngresados, 8, 10, listaErrores, "Telefono");
                    break;
            }

            return listaErrores;
        }
    }
}
