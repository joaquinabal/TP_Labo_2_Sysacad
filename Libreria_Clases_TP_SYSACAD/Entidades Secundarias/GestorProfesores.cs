using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;

namespace Libreria_Clases_TP_SYSACAD.Entidades_Secundarias
{
    public class GestorProfesores
    {
        private ConsultasProfesores _consultasProfesores = new ConsultasProfesores();
        private ValidadorAsignacionCursoAProfesor validadorAsignacionCursoAProfesor = new ValidadorAsignacionCursoAProfesor();

        public Profesor? DevolverProfesor(string correo)
        {
            return _consultasProfesores.DevolverProfesor(correo);
        }

        private async Task EditarProfesor(string correo, string direccion, string especializacion, string nombre, string telefono, string correoOriginal)
        {
           await _consultasProfesores.EditarProfesor(correo, direccion, especializacion, nombre, telefono, correoOriginal);
        }

        public async Task EliminarProfesor(string correo)
        {
            await _consultasProfesores.EliminarProfesorBD(correo);
        }

        public bool ValidarDuplicadosProfesores(string correo)
        {
            return _consultasProfesores.BuscarProfesorExistenteBD(correo);
        }

        public async Task<RespuestaValidacionInput> GestionarEdicionProfesor(Dictionary<string, string> dictCampos, string correo, string nombre, string direccion, string especializacion, string telefono, string correoOriginal)
        {
            ValidadorInputGenerico validadorInputProfesores = new ValidadorInputGenerico();
            bool validacionDuplicados = ValidarDuplicadosProfesores(correo);
            RespuestaValidacionInput validacionProfesor = validadorInputProfesores.ValidarDatos(dictCampos, ModoValidacionInput.Profesores);

            if (validacionProfesor.AusenciaCamposVacios && !validacionProfesor.ExistenciaErrores && !validacionDuplicados)
            {
                await EditarProfesor(correo, nombre, direccion, especializacion, telefono, correoOriginal);
            }

            return validacionProfesor;
        }

        public async Task<RespuestaValidacionInput> GestionarAgregarProfesor(Dictionary<string, string> dictCampos, Profesor profesor)
        {
            ValidadorInputGenerico validadorInputProfesores = new ValidadorInputGenerico();
            bool validacionDuplicados = ValidarDuplicadosProfesores(profesor.Correo);
            RespuestaValidacionInput validacionProfesor = validadorInputProfesores.ValidarDatos(dictCampos, ModoValidacionInput.Profesores);

            if (validacionProfesor.AusenciaCamposVacios && !validacionProfesor.ExistenciaErrores && !validacionDuplicados)
            {
                await profesor.Registrar();
            }

            return validacionProfesor;
        }


        public async Task GestionarAsignacionCursoAProfesor(string correoProfesor, string codigoCurso)
        {
            bool resultadoValidacion = validadorAsignacionCursoAProfesor.ValidarAsignacionDeCursoAProfesor(codigoCurso, _consultasProfesores.DevolverProfesor(correoProfesor));
            if (resultadoValidacion)
            {
                await _consultasProfesores.AgregarCursoAProfesor(correoProfesor, codigoCurso);
            }
        }


        
    }
}
