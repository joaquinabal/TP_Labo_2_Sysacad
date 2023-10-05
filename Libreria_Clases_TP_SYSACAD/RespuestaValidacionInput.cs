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
        
        public RespuestaValidacionInput(bool camposVacios, bool existenciaErrores ,List<string> listaErrores)
        {
            _camposVacios = camposVacios;
            _existenciaErrores = existenciaErrores;
            _listaErrores = listaErrores;

            if (_existenciaErrores == true)
            {
                GenerarMensajeDeErrores();
            }
        }

        private void GenerarMensajeDeErrores()
        {
            _mensajeErrores = "Debe corregir: \n";

            foreach (string error in _listaErrores)
            {
                _mensajeErrores += $"{error} \n";
            }
        }

        public bool AusenciaCamposVacios{ get { return _camposVacios; } }

        public bool ExistenciaErrores { get { return _existenciaErrores; } }

        public string MensajeErrores { get { return _mensajeErrores; } }

    }
}
