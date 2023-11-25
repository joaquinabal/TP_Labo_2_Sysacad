using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
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

        public async Task EditarCurso(string codigoABuscar, string nombre, string codigo, string descripcion, int cupoMaximo, string turno, string dia, string aula)
        {
             await _consultasCursos.EditarCursoBD(codigoABuscar, nombre, codigo, descripcion, cupoMaximo, turno, dia, aula);
        }

        public async Task ActualizarListaDeEsperaDeCurso(Curso cursoRecibido, Dictionary<string, DateTime> listaEsperaRecibida)
        {
            await _consultasCursos.ActualizarListaDeEsperaDeCurso(cursoRecibido, listaEsperaRecibida);
        }

        public async Task EliminarCurso(string codigoABuscar)
        {
            await _consultasCursos.EliminarCursoBD(codigoABuscar);
        }

        public bool ValidarDuplicadosCursos(string codigo)
        {
            return _consultasCursos.BuscarCursoBD(codigo);
        }


        //////////////////////////////////////GESTION/////////////////////////////////

        public async Task<RespuestaValidacionInput> GestionarEdicionCurso(Dictionary<string, string> dictCampos, string codigoABuscar, string nombre, string codigo, string descripcion, int cupoMaximo, string turno, string dia, string aula)
        {
            ValidadorInputGenerico validadorInputCursos = new ValidadorInputGenerico();
            bool validacionDuplicados = ValidarDuplicadosCursos(codigo);
            RespuestaValidacionInput validacionCursos = validadorInputCursos.ValidarDatos(dictCampos, ModoValidacionInput.CursoAgregarOEditar);

            if (validacionCursos.AusenciaCamposVacios && !validacionCursos.ExistenciaErrores && !validacionDuplicados)
            {
                await EditarCurso(codigoABuscar, nombre, codigo, descripcion, cupoMaximo, turno, dia, aula);
            }

            return validacionCursos;
        }

        public async Task<RespuestaValidacionInput> GestionarAgregarCurso(Dictionary<string, string> dictCampos, Curso curso)
        {
            ValidadorInputGenerico validadorInputCursos = new ValidadorInputGenerico();
            bool validacionDuplicados = ValidarDuplicadosCursos(curso.Codigo);
            RespuestaValidacionInput validacionCursos = validadorInputCursos.ValidarDatos(dictCampos, ModoValidacionInput.CursoAgregarOEditar);

            if (validacionCursos.AusenciaCamposVacios && !validacionCursos.ExistenciaErrores && !validacionDuplicados)
            {
                await curso.Registrar();
            }

            return validacionCursos;
        }
    } 

    


}
