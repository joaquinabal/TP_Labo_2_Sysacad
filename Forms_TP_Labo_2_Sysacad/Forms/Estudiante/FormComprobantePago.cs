using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TP_Labo_2_Sysacad
{
    public partial class FormComprobantePago : FormPadre
    {
        public FormComprobantePago(string monto, Dictionary<string, double> conceptosPagados, string cuotas = "")
        {
            InitializeComponent();
            string mensajeConceptos = "Conceptos Pagados:\n";
            string montoAPagar = monto;
            string cantCuotas = cuotas;
            bool primerConcepto = true;
            DateTime fecha = DateTime.Now;
            foreach (var nombreConcepto in conceptosPagados.Keys)
            {
                if (!primerConcepto)
                {
                    mensajeConceptos += "\n";
                }
                else
                {
                    primerConcepto = false;
                }

                mensajeConceptos += $"{nombreConcepto}\n";
            }

            conceptosTitleLbl.Text = mensajeConceptos;
            montoLbl.Text = $"Monto Pagado: ${montoAPagar}";
            fechaLbl.Text = fecha.ToString();
            if (cantCuotas == "")
            {
                cuotasLbl.Visible = false;
            }
            else
            {
                cuotasLbl.Visible = true;
                cuotasLbl.Text = $"{cantCuotas}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGestionarPagos formGestionarPagos = new FormGestionarPagos();
            formGestionarPagos.Show();
        }
    }
}
