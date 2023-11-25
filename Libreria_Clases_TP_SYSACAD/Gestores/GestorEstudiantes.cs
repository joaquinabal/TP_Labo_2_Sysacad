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

        public async Task<bool> EnviarCorreoElectronicoAEstudiante(Estudiante estudiante)
        {
            bool resultadoEmisionCorreo = await EmisorCorreoElectronico.EnviarCorreoElectronicoCredenciales(estudiante, estudiante.Contrasenia);
            return resultadoEmisionCorreo;
        }

        ///////////////////////////////GESTION///////////////////////////////////////
        public RespuestaValidacionInput ValidarInputsEstudiantes(Dictionary<string, string> dictCampos)
        {
            ValidadorInputGenerico validadorInputEstudiantes = new ValidadorInputGenerico();
            RespuestaValidacionInput validacionEstudiantes = validadorInputEstudiantes.ValidarDatos(dictCampos, ModoValidacionInput.Estudiantes);

            return validacionEstudiantes;
        }

        public async Task<bool> GestionarRegistrarEstudianteEnBaseADuplicados(Estudiante estudiante)
        {
            bool validacionDuplicados = ValidarDuplicadosEstudiantes(estudiante.Legajo, estudiante.Correo);

            if (!validacionDuplicados)
            {
                await estudiante.Registrar();
            }

            return validacionDuplicados;
        }


    }
}
