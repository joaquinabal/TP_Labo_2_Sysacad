using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Validaciones
{
    public class ValidadorEventoMail
    {
        public DateTime FechaInicioCuatri { get; set; }

        public DateTime FechaPagoCuota { get; set; }

        public DateTime FechaLimiteInscripcion { get; set; }

        public int DiasLimiteInscripcion { get; set; }

        public int DiasLimitePagoCuota { get; set; }

        public RespuestaEvento ValidarFechasMail(TipoEvento evento)
        {
            DateTime fechaLimite = new DateTime();
            int diasLimite = 0;
            int diasRestantesInscripcion;

            RespuestaEvento respuesta = RespuestaEvento.NoEjecutar;

            DateTime fechaActual = DateTime.Now;

            if (evento == TipoEvento.PagoCuota)
            {
                fechaLimite = FechaPagoCuota;
                diasLimite = DiasLimitePagoCuota;
            }
            else if (evento == TipoEvento.LimiteInscripcion)
            {
                fechaLimite = FechaLimiteInscripcion;
                diasLimite = DiasLimiteInscripcion;
            }
            else if(evento == TipoEvento.InicioCuatri) 
            {
                return RespuestaEvento.Ejecutar;
            }  
            
            diasRestantesInscripcion = (int)(fechaLimite - fechaActual).TotalDays;

            if (diasRestantesInscripcion <= diasLimite)
            {
                respuesta = RespuestaEvento.Ejecutar;
            }
            return respuesta;
        }
    }
}
