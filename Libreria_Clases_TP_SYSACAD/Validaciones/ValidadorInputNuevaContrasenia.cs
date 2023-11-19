using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Validaciones
{
    public class ValidadorInputNuevaContrasenia : ValidadorInputs
    {
        private readonly ICambioDeContraseña _servicioCambioContraseña;

        // INYECCION DE DEPENDENCIAS:
        // Creo un constructor que reciba una referencia a una clase que implemente la interfaz "ICambioDeContraseña"
        // En este caso será un MOCK (Pero la clase que realmente implementa esta interfaz es ConsultasEstudiantes)
        // Esta interfaz tiene un metodo "CambiarContraseñaAEstudiante" que se localiza en la capa de datos.
        public ValidadorInputNuevaContrasenia(ICambioDeContraseña servicioCambioContraseña)
        {
            _servicioCambioContraseña = servicioCambioContraseña;
        }

        // Creo un constructor sin argumentos para poder llamarlo libremente desde el forms
        public ValidadorInputNuevaContrasenia()
        {
            _servicioCambioContraseña = new ConsultasEstudiantes();
        }

        public async Task<MensajeRespuestaValidacionCredencialesContraseña> ValidarNuevaContrasenia(string contrasenia, string correo)
        {
            MensajeRespuestaValidacionCredencialesContraseña mensajeADevolver;

            //Valido si no hay campos vacios. Si todo esta bien devuelve true
            bool resultadoCamposVacios = ValidarCampos(contrasenia);

            //Valido si hay campos vacios y si el regex esta bien
            if (!resultadoCamposVacios)
            {
                mensajeADevolver = MensajeRespuestaValidacionCredencialesContraseña.camposVacios;
            }
            else
            {
                if (!Regex.IsMatch(contrasenia, @"^[a-zA-Z0-9]{6,}$"))
                {
                    mensajeADevolver = MensajeRespuestaValidacionCredencialesContraseña.ERROR;
                }
                else
                {
                    // Acá entonces no necesito instanciar el metodo "CambiarContraseñaAEstudiante" de la class
                    // "ConsultasEstudiantes", ya que tengo la referencia a la class que implementa la interfaz
                    // "ICambioDeContraseña" (Que es "ConsultasEstudiantes"). Entonces en vez de instanciar la 
                    // clase directamente, accedo a la referencia de aquella class que implementa la interfaz.
                    await _servicioCambioContraseña.CambiarContraseñaAEstudiante(correo, contrasenia);
                    mensajeADevolver = MensajeRespuestaValidacionCredencialesContraseña.OK;
                }
            }

            return mensajeADevolver;
        }
    }
}
