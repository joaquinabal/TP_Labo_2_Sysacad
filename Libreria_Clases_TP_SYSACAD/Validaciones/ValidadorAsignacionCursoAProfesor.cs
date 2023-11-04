using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Validaciones
{
    public static class ValidadorAsignacionCursoAProfesor
    {
        //VALIDO QUE NO HAYA CONFLICTOS DE HORARIOS

        public static bool ValidarAsignacionDeCursoAProfesor(string codigoCursoAsignar, Profesor profesor)
        {
            bool resultadoValidacion = true;
            
            if (profesor.CodigosCursosDeProfesor.Count > 0)
            {
                List<Curso> listaCursosDelProfesor = ConsultasCursos.ObtenerListaCursosDesdeListaCodigos(profesor.CodigosCursosDeProfesor);
                Curso cursoAAsignar = ConsultasCursos.ObtenerCursoDesdeCodigo(codigoCursoAsignar);

                foreach (Curso cursoDelProfesor in listaCursosDelProfesor)
                {
                    if (cursoDelProfesor.Dia == cursoAAsignar.Dia && cursoDelProfesor.Turno == cursoAAsignar.Turno)
                    {
                        resultadoValidacion = false;
                        break;
                    }
                }
            }

            return resultadoValidacion;
        }
    }
}
