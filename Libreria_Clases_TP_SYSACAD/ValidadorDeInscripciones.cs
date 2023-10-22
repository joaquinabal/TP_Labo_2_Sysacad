using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class ValidadorDeInscripciones
    {
        private List<string> _cursosSinCupo = new List<string>();
        private List<string> _cursosProhibidos = new List<string>();

        //Fx que recibe cursos seleccionados
        //No hay ninguno seleccionado devuelve "SIN SELECCION"
        //Busca si de los seleccionados hay alguno sin cupo
        //Si todos tienen cupo devuelve "OK"
        //Si alguno no tiene cupo: 
        //-Si hay uno seleccionado devuelve "SIN CUPO: ABSOLUTO"
        //-Si hay varios seleccionados devuelve "SIN CUPO: PARCIAL"
        public string ValidarCursosSegunCupo(List<Curso> cursosSeleccionados)
        {
            string mensajeADevolver;

            if (cursosSeleccionados.Count > 0)
            {
                //Buscamos si hay cupos disponibles en aquellos cursos seleccionados
                //En caso de que no tenga cupo, se agrega a la lista de "cursos sin cupo"
                //En caso de que haya cupo, restamos un cupo al curso y agregamos el curso al estudiante
                foreach (Curso curso in cursosSeleccionados)
                {
                    bool resultadoValidacionCupos = ComprobarSiHayCuposDisponiblesEnCurso(curso);
                    bool resultadoValidacionRequisitosAcademicos = ComprobarSiCumpleRequisitosAcademicos(curso);

                    //Si no cumplio con los requisitos
                    if (resultadoValidacionRequisitosAcademicos == false)
                    {
                        _cursosProhibidos.Add(curso.Nombre);
                    }
                    // Si no hay cupos
                    else if (resultadoValidacionCupos == false)
                    {
                        _cursosSinCupo.Add(curso.Nombre);
                    }
                    // Si cumple con los requisitos y hay cupos
                    else
                    {
                        GestionarInscripcion(curso);
                    }
                }

                //SI NO CUMPLE REQUISITOS
                if(_cursosProhibidos.Count > 0)
                {
                    mensajeADevolver = "NO CUMPLE REQUISITOS";
                }
                //SI NO HAY CUPOS
                //Si hay cursos sin cupo y hay uno solo seleccionado, devolvemos "SIN CUPO: ABSOLUTO"
                //Si todos los cursos tiene cupo, devolvemos "OK"
                else if (_cursosSinCupo.Count > 0)
                {
                    if (cursosSeleccionados.Count == 1)
                    {
                        mensajeADevolver = "SIN CUPO: ABSOLUTO";
                    }
                    else
                    {
                        mensajeADevolver = "SIN CUPO: PARCIAL";
                    }
                }
                else
                {
                    mensajeADevolver = "OK";
                }
            }
            else
            {
                mensajeADevolver = "SIN SELECCION";
            }

            return mensajeADevolver;
        }

        private static void GestionarInscripcion(Curso curso)
        {
            RegistroDeInscripcion nuevoRegistro = GenerarNuevoRegistroDeInscripcion(curso);
            
            Sistema.BaseDatosCursos.RestarCupoDisponible(curso);
            Sistema.BaseDatosEstudiantes.AgregarCursoAEstudiante(Sistema.EstudianteLogueado, curso);
            Sistema.BaseDatosInscripciones.IngresarNuevoRegistro(nuevoRegistro);
        }

        private static RegistroDeInscripcion GenerarNuevoRegistroDeInscripcion(Curso curso)
        {
            Estudiante estudianteInscripto = Sistema.EstudianteLogueado;
            Curso cursoAlCualSeInscribe = curso;
            DateTime fechaInscripcion = DateTime.Now;

            RegistroDeInscripcion nuevoRegistro = new RegistroDeInscripcion(estudianteInscripto.Legajo, 
                estudianteInscripto.Nombre, cursoAlCualSeInscribe.Nombre, cursoAlCualSeInscribe.Codigo, 
                cursoAlCualSeInscribe.Carrera, fechaInscripcion);

            return nuevoRegistro;
        }

        /// <summary>
        /// Comprueba si hay cupos disponibles en un curso seleccionado.
        /// </summary>
        /// <param name="cursoSeleccionado">El curso seleccionado.</param>
        /// <returns>True si hay cupos disponibles; de lo contrario, false.</returns>
        private static bool ComprobarSiHayCuposDisponiblesEnCurso(Curso cursoSeleccionado)
        {
            List<Curso> lista_cursos_disponibles = Sistema.BaseDatosCursos.Cursos;
            bool respuestaCuposDisponibles = false;

            foreach (Curso cursoDisponible in lista_cursos_disponibles)
            {
                if (cursoSeleccionado.Codigo == cursoDisponible.Codigo)
                {
                    if (cursoDisponible.ChequearCuposDisponibles() == true)
                    {
                        respuestaCuposDisponibles = true;
                    }
                }
            }

            return respuestaCuposDisponibles;
        }

        private static bool ComprobarSiCumpleRequisitosAcademicos(Curso cursoSeleccionado)
        {
            List<string> cursosRequeridosParaLaInscripción = cursoSeleccionado.Correlatividades;
            List<string> codigosDeFamiliaDeCursosCompletados = Sistema.EstudianteLogueado.CursosCompletados;

            bool cumpleRequisitosAcademicos = true;

            foreach (string cursoRequerido in cursosRequeridosParaLaInscripción)
            {
                // Verifico si el código de familia del curso requerido no se encuentra en la lista de cursos completados
                if (!codigosDeFamiliaDeCursosCompletados.Contains(cursoRequerido))
                {
                    // Si no se encuentra uno de los cursos requeridos en los cursos completados, se establece cumpleRequisitosAcademicos en false y salgo del bucle
                    cumpleRequisitosAcademicos = false;
                    break;
                }
                else if (cursoSeleccionado.CreditosRequeridos > Sistema.EstudianteLogueado.Creditos)
                {
                    cumpleRequisitosAcademicos = false;
                    break;
                }
                else if (cursoSeleccionado.PromedioRequerido > Sistema.EstudianteLogueado.Promedio)
                {
                    cumpleRequisitosAcademicos = false;
                    break;
                }
            }

            return cumpleRequisitosAcademicos;
        }

        //Getters y Setters
        public List<string> CursosSinCupo { get { return _cursosSinCupo; } }
    }
}
