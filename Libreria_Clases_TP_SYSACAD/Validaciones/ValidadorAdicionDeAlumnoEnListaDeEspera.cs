using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Gestores;

namespace Libreria_Clases_TP_SYSACAD.Validaciones
{
    public class ValidadorAdicionDeAlumnoEnListaDeEspera : ValidadorInputs
    {
        bool camposCompletadosCorrectamente;
        List<string> listaErrores = new List<string>();
        bool existenciaDeErrores;
        bool existenciaDelAlumno;
        bool existenciaEnListaDeEspera;
        private GestorEstudiantes gestorEstudiantes = new GestorEstudiantes(); 

        public RespuestaValidacionInput ValidarAdicionAlumnoEnLista(string legajoDelAlumno, Curso cursoRecibido)
        {
            //Paso el campo recibido a una lista para ejecutar validaciones
            List<string> campoRecibido = new List<string>();
            campoRecibido.Add(legajoDelAlumno);

            //Guardo el resultado de la validacion de espacios en blanco
            camposCompletadosCorrectamente = ValidarCampos(campoRecibido);

            //Si los campos se completaron correctamente
            if (camposCompletadosCorrectamente)
            {
                //Paso el campo a un diccionario para ejecutar validaciones regex
                Dictionary<string, string> diccionarioConCampo = new Dictionary<string, string>();
                diccionarioConCampo["legajo"] = legajoDelAlumno;

                //Valido y verifico si hay errores Regex
                listaErrores = ValidarRegex(diccionarioConCampo);
                existenciaDeErrores = ComprobarExistenciaErrores(listaErrores);

                //Si no hay errores busco al estudiante en la BD segun el legajo que se ha ingresado correctamente
                if (!existenciaDeErrores)
                {
                    //Guardo el resultado de la busqueda
                    //Estudiante estudianteEncontrado = Sistema.BaseDatosEstudiantes.ObtenerEstudianteSegunLegajo(legajoDelAlumno);
                    Estudiante estudianteEncontrado = gestorEstudiantes.ObtenerEstudianteSegunLegajo(legajoDelAlumno);

                    //Verifico si se encontro al estudiante
                    if (estudianteEncontrado != null)
                    {
                        existenciaDelAlumno = true;

                        //Si existe, me fijo si ya se encuentra en la lista de espera
                        existenciaEnListaDeEspera = VerificarSiElAlumnoSeEncuentreEnLaLista(estudianteEncontrado, cursoRecibido);
                    }
                }
            }

            RespuestaValidacionInput respuesta = new RespuestaValidacionInput(camposCompletadosCorrectamente,
                existenciaDeErrores, listaErrores, existenciaDelAlumno, existenciaEnListaDeEspera);

            return respuesta;
        }

        protected override List<string> ValidarRegex(Dictionary<string, string> diccionarioConCamposIngresados)
        {
            List<string> listaErrores = new List<string>();

            // Valida el legajo (8 digitos)
            if (!Regex.IsMatch(diccionarioConCamposIngresados["legajo"], @"^\d{8}$"))
            {
                listaErrores.Add("Legajo");
            }

            return listaErrores;
        }

        private static bool VerificarSiElAlumnoSeEncuentreEnLaLista(Estudiante estudiante, Curso curso)
        {
            bool resultadoVerificacion = false;

            foreach (string legajo in curso.ListaDeEspera.Keys)
            {
                if (legajo == estudiante.Legajo)
                {
                    resultadoVerificacion = true;
                }
            }

            return resultadoVerificacion;
        }
    }
}
