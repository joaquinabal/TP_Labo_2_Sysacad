using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Herramientas
{
    public class ElementosCorreoElectronicoArgs : EventArgs
    {
        public string Subject { get; set; }
        public string Body { get; set; }

        public ElementosCorreoElectronicoArgs(string subject, string body)
        {
            Subject = subject;
            Body = body;
        }
    }
}
