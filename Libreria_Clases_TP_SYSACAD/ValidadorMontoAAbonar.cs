using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class ValidadorMontoAAbonar
    {
        private List<double> _listaMontos;
        private List<double> _listaMontosOriginales;

        public ValidadorMontoAAbonar(List<double> listaMontos)
        {
            _listaMontos = listaMontos;
        }

        public ValidadorMontoAAbonar(List<double> listaMontos, List<double> listaMontosOriginales) :this(listaMontos)
        {
            _listaMontosOriginales = listaMontosOriginales;
        }

        public bool VerificarSiHayNumeroNegativo()
        {
            // Verifica si algún valor en la columna de índice 2 es negativo
            bool hayNumeroNegativo = false;
            
            foreach (double monto in _listaMontos)
            {
                if (monto < 0)
                {
                    hayNumeroNegativo = true;
                    break;
                }
            }

            return hayNumeroNegativo;
        }

        public bool VerificarSiHayValorExcesivo()
        {
            // Verifica si algún valor en la columna de índice 2 es mayor que el valor en la columna de índice 1
            bool hayValorExcesivo = false;

            for (int i = 0; i < _listaMontos.Count; i++)
            {
                for (int j = 0; j < _listaMontosOriginales.Count; j++)
                {
                    if( i == j && _listaMontos[i] > _listaMontosOriginales[j])
                    {
                        hayValorExcesivo = true;
                        break;
                    }
                }
            }



            /*foreach (double montoAbonar in _listaMontos)
            {
                foreach (double montoOriginal in _listaMontosOriginales)
                {
                    if (montoAbonar > montoOriginal)
                    {
                        hayValorExcesivo = true;
                        break;
                    }
                }
            }*/

            return hayValorExcesivo;
        }
    }
}
