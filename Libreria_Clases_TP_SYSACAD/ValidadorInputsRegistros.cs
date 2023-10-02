using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class ValidadorInputsRegistros
    {
        public static string ValidarDatosEstudiante(List<string> listaDeCamposIngresados)
        {
            StringBuilder listaErrores = new();

            string mensajeADevolver = "";

            // Validar el nombre 
            if (!Regex.IsMatch(listaDeCamposIngresados[0], @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                listaErrores.AppendLine("Nombre");
            }

            // Validar el Legajo
            if (!Regex.IsMatch(listaDeCamposIngresados[1], @"^\d{8}$"))
            {
                listaErrores.AppendLine("Legajo");
            }

            //Validar Direccion
            if (!Regex.IsMatch(listaDeCamposIngresados[2], @"^[a-zA-Z0-9\s]+$"))
            {
                listaErrores.AppendLine("Dirección");
            }

            // Validar telefono
            if (!Regex.IsMatch(listaDeCamposIngresados[3], @"^\d{8}(\d{2})?$"))
            {
                listaErrores.AppendLine("Telefono");
            }

            // Validar correo 
            if (!Regex.IsMatch(listaDeCamposIngresados[4], @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                listaErrores.AppendLine("Correo");
            }

            //Verificar errores y devolverlos como mensajes
            if (listaErrores.Length > 1)
            {
                listaErrores.AppendLine("Revisar!!!");
                mensajeADevolver = listaErrores.ToString();
            }
            else
            {
                listaErrores.Clear();
                mensajeADevolver = listaErrores.Append("ALTA EXITOSA").ToString();
            }

            return mensajeADevolver;
        }

        public static string ValidarDatosCurso(List<string> listaDeCamposIngresados)
        {
            StringBuilder listaErrores = new();

            string mensajeADevolver = "";

            // Validar el nombre de la MATERIA 
            if (!Regex.IsMatch(listaDeCamposIngresados[0], @"^[a-zA-Z0-9\s]+$"))
            {
                listaErrores.AppendLine("Nombre de la materia");
            }

            // Validar el CODIGO
            if (!Regex.IsMatch(listaDeCamposIngresados[1], @"^[a-zA-Z0-9]+$"))
            {
                listaErrores.AppendLine("Codigo");
            }

            // Validar el numero de aula
            if (!Regex.IsMatch(listaDeCamposIngresados[2], @"^\d{3}$"))
            {
                listaErrores.AppendLine("Número de Aula");
            }

            // Validar Descripcion
            if (!Regex.IsMatch(listaDeCamposIngresados[3], @"^[a-zA-Z0-9ñÑ°\s.,-]+$"))
            {
                listaErrores.AppendLine("Descripcion");
            }

            // Validar Cupo maximo 
            if (!Regex.IsMatch(listaDeCamposIngresados[4], @"^[0-9]+$"))
            {
                listaErrores.AppendLine("Cupo maximo");
            }

            //Verificar errores y devolverlos como mensajes
            if (listaErrores.Length > 1)
            {
                listaErrores.AppendLine("Revisar!!!");
                mensajeADevolver = listaErrores.ToString();
            }
            else
            {
                listaErrores.Clear();
                mensajeADevolver = listaErrores.Append("ALTA EXITOSA").ToString();
            }

            return mensajeADevolver;
        }

        public static string ValidarNuevoAdmin(List<string> listaDeCamposIngresados)
        {
            StringBuilder listaErrores = new();

            string mensajeADevolver = "";

            // Validar correo 
            if (!Regex.IsMatch(listaDeCamposIngresados[4], @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                listaErrores.AppendLine("Correo");
            }

            //Verificar errores y devolverlos como mensajes
            if (listaErrores.Length > 1)
            {
                listaErrores.AppendLine("Revisar!!!");
                mensajeADevolver = listaErrores.ToString();
            }
            else
            {
                listaErrores.Clear();
                mensajeADevolver = listaErrores.Append("ALTA EXITOSA").ToString();
            }

            return mensajeADevolver;
        }
    }
}
