using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class ConceptoDePago
    {
        private string _nombre;
        private double _montoInicial;
        private double _montoPendiente;

        public ConceptoDePago(string nombre, double montoInicial, double montoPendiente)
        {
            _nombre = nombre;
            _montoInicial = montoInicial;
            _montoPendiente = montoPendiente;
        }

        //Getters y Setters
        public string Nombre { get { return _nombre; } }

        public double MontoInicial { get { return _montoInicial;  } }

        public double MontoPendiente { get { return _montoPendiente; } set { _montoPendiente = value; } }

    }
}
