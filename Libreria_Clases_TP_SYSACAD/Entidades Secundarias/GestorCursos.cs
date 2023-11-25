using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Entidades_Secundarias
{
    public class GestorCursos
    {
        private ConsultasCursos _consultasCursos = new ConsultasCursos();

        public Curso? ObtenerCursoDesdeCodigo(string codigo)
        {
            return _consultasCursos.ObtenerCursoDesdeCodigo(codigo);
        }

        public List<Curso> ObtenerListaCursosDesdeListaCodigos(List<string> listaCodigos)
        {
            return _consultasCursos.ObtenerListaCursosDesdeListaCodigos(listaCodigos);
        }
    } 

    


}
