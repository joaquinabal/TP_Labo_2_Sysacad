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

namespace Libreria_Clases_TP_SYSACAD.Gestores
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

        //////////////////////////////////////GESTION/////////////////////////////////

        public RespuestaValidacionInput ValidarInputsProfesor(Dictionary<string, string> dictCampos)
        {
            ValidadorInputGenerico validadorInputProfesores = new ValidadorInputGenerico();
            RespuestaValidacionInput validacionProfesor = validadorInputProfesores.ValidarDatos(dictCampos, ModoValidacionInput.Profesores);

            return validacionProfesor;
        }

        public async Task<bool> GestionarEdicionProfesorEnBaseADuplicados(bool cambioDeCorreo, string correo, string direccion, string especializacion, string nombre, string telefono, string correoOriginal)
        {
            if (cambioDeCorreo)
            {
                bool validacionDuplicados = ValidarDuplicadosProfesores(correo);

                if (!validacionDuplicados)
                {
                    await EditarProfesor(correo, direccion, especializacion, nombre, telefono, correoOriginal);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                await EditarProfesor(correo, direccion, especializacion, nombre, telefono, correoOriginal);
                return true;
            }
        }

        public async Task<bool> GestionarAgregarProfesorEnBaseADuplicados(Profesor profesor)
        {
            bool validacionDuplicados = ValidarDuplicadosProfesores(profesor.Correo);

            if (!validacionDuplicados)
            {
                await profesor.Registrar();
            }

            return validacionDuplicados;
        }


        public async Task<bool> GestionarAsignacionCursoAProfesor(string correoProfesor, string codigoCurso)
        {
            Profesor profesorGestionado = DevolverProfesor(correoProfesor);
            bool resultadoValidacion = validadorAsignacionCursoAProfesor.ValidarAsignacionDeCursoAProfesor(codigoCurso, profesorGestionado);

            if (resultadoValidacion)
            {
                await _consultasProfesores.AgregarCursoAProfesor(correoProfesor, codigoCurso);
            }

            return resultadoValidacion;
        }
    }
}
