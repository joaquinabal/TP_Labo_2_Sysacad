using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class RespuestaValidacionInput
    {
        private bool _camposVacios;
        private bool _existenciaErrores;
        private List<string> _listaErrores = new List<string>();
        private string _mensajeErrores = string.Empty;

        /// <summary>
        /// Constructor de la clase RespuestaValidacionInput.
        /// </summary>
        /// <param name="camposVacios">Indica si los campos están vacíos.</param>
        /// <param name="existenciaErrores">Indica si existen errores.</param>
        /// <param name="listaErrores">Lista de errores.</param>
        internal RespuestaValidacionInput(bool camposVacios, bool existenciaErrores ,List<string> listaErrores)
        {
            _camposVacios = camposVacios;
            _existenciaErrores = existenciaErrores;
            _listaErrores = listaErrores;

            if (_existenciaErrores == true)
            {
                GenerarMensajeDeErrores();
            }
        }

        /// <summary>
        /// Genera un mensaje de errores a partir de la lista de errores.
        /// </summary>
        private void GenerarMensajeDeErrores()
        {
            _mensajeErrores = "Debe corregir: \n";

            foreach (string error in _listaErrores)
            {
                _mensajeErrores += $"{error} \n";
            }
        }

        //Getters y Setters
        public bool AusenciaCamposVacios{ get { return _camposVacios; } }

        public bool ExistenciaErrores { get { return _existenciaErrores; } }

        public string MensajeErrores { get { return _mensajeErrores; } }

    }
}
