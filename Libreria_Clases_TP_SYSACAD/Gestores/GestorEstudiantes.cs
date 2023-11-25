using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Herramientas;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Gestores
{
    public class GestorEstudiantes
    {
        private ConsultasEstudiantes _consultasEstudiantes = new ConsultasEstudiantes();

        public bool BuscarSiUsuarioDebeCambiarContrasenia(string correo)
        {
            return _consultasEstudiantes.BuscarSiUsuarioDebeCambiarContrasenia(correo);
        }

        public Estudiante ObtenerEstudianteSegunLegajo(string legajo)
        {
            return _consultasEstudiantes.ObtenerEstudianteSegunLegajo(legajo);
        }

        public bool ValidarDuplicadosEstudiantes(string legajo, string correo)
        {
            return ConsultasEstudiantes.BuscarUsuarioExistenteBD(correo, legajo);
        }

        ///////////////////////////////GESTION///////////////////////////////////////


        public async Task<RespuestaValidacionInput> GestionarRegistrarEstudiante(Dictionary<string, string> dictCampos, Estudiante estudiante)
        {
            ValidadorInputGenerico validadorInputEstudiante = new ValidadorInputGenerico();
            bool validacionDuplicados = ValidarDuplicadosEstudiantes(estudiante.Legajo, estudiante.Correo);
            RespuestaValidacionInput validacionEstudiante = validadorInputEstudiante.ValidarDatos(dictCampos, ModoValidacionInput.Estudiantes);

            if (validacionEstudiante.AusenciaCamposVacios && !validacionEstudiante.ExistenciaErrores && !validacionDuplicados)
            {
                await estudiante.Registrar();
                await EmisorCorreoElectronico.EnviarCorreoElectronicoCredenciales(nuevoEstudiante, _contraseñaProvisional);
            }

            return validacionEstudiante;
        }


    }
}
