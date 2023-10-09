using Libreria_Clases_TP_SYSACAD;
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
    public partial class FormPagoTarjeta : FormPadre
    {
        private string _nroTarjeta;
        private string _nombre;
        private string _fechaVencimiento;
        private string _codSeguridad;
        private string _metodoDePago;
        private Dictionary<string, double> _conceptosSeleccionados;
        private string _monto;
        private string _cantCuotas;
        public FormPagoTarjeta(double montoAPagar, Dictionary<string, double> conceptosSeleccionados, string metodoDePago)
        {
            InitializeComponent();
            radioBtnCheckeado(metodoDePago);
            ConceptosSeleccionados = conceptosSeleccionados;
            MetodoDePago = metodoDePago;
            Monto = montoAPagar.ToString();
        }

        private void nroTarjetaTxtbox_TextChanged(object sender, EventArgs e)
        {
            NroTarjeta = nroTarjetaTxtbox.Text;
        }

        private void nombreTxtbox_TextChanged(object sender, EventArgs e)
        {
            Nombre = nombreTxtbox.Text;
        }

        private void FVTxtbox_TextChanged(object sender, EventArgs e)
        {
            FechaVencimiento = FVTxtbox.Text;
        }

        private void CSTxtbox_TextChanged(object sender, EventArgs e)
        {
            CodSeguridad = CSTxtbox.Text;
        }


        private void pagarBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dirCampos = new Dictionary<string, string>
            {
                { "nombre", Nombre },
                { "numero", NroTarjeta},
                { "vencimiento", FechaVencimiento },
                { "codigo", CodSeguridad }
            };

            ValidadorInputMediosPago validadorDeTarjeta = new ValidadorInputMediosPago();

            RespuestaValidacionInput resultadoValidacion = validadorDeTarjeta.ValidarDatosMedioDePago(dirCampos, modo: ModoPago.tarjeta);

            if (resultadoValidacion.AusenciaCamposVacios == false)
            {
                MessageBox.Show("Asegurese de completar los campos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!resultadoValidacion.ExistenciaErrores)
            {
                Sistema.EstudianteLogueado.ActualizarConceptosDePago(ConceptosSeleccionados);
                MessageBox.Show("vamos pa delante");
                this.Close();
                FormComprobantePago formComprobantePago = new FormComprobantePago(Monto, ConceptosSeleccionados, _cantCuotas);
                formComprobantePago.Show();
            }
            else
            {
                MessageBox.Show(resultadoValidacion.MensajeErrores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGestionarPagos formGestionarPagos = new FormGestionarPagos();
            formGestionarPagos.ShowDialog();
        }

        /// <summary>
        /// Verifica y marca el RadioButton correspondiente según el método de pago proporcionado.
        /// </summary>
        /// <param name="metodoPago">El método de pago a verificar (por ejemplo, "Tarjeta de Credito" o "Tarjeta de Debito").</param>
        private void radioBtnCheckeado(string metodoPago)
        {
            if (metodoPago == "Tarjeta de Credito")
            {
                TCRadioBtn.Checked = true;
            }
            else if (metodoPago == "Tarjeta de Debito")
            {
                TDRadioBtn.Checked = true;
            }
        }

        /// <summary>
        /// Habilita o deshabilita el control de selección de cuotas según la selección de método de pago.
        /// </summary>
        private void habilitarCuotas()
        {
            if (TCRadioBtn.Checked)
            {
                cantCuotasCB.Enabled = true;
            }
            else
            {
                cantCuotasCB.Enabled = false;
            }
        }


        private void TDRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCuotas();
            _cantCuotas = "";
        }

        private void TCRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCuotas();
            cantCuotasCB.SelectedIndex = 0;
        }

        private void cantCuotasCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cantCuotas = cantCuotasCB.Text;
        }

        public string NroTarjeta
        {
            get { return _nroTarjeta; }
            set { _nroTarjeta = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string FechaVencimiento
        {
            get { return _fechaVencimiento; }
            set { _fechaVencimiento = value; }
        }

        public string CodSeguridad
        {
            get { return _codSeguridad; }
            set { _codSeguridad = value; }
        }

        public string MetodoDePago
        {
            get { return _metodoDePago; }
            set { _metodoDePago = value; }
        }

        public string Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        public Dictionary<string, double> ConceptosSeleccionados
        {
            get { return _conceptosSeleccionados; }
            set { _conceptosSeleccionados = value; }
        }

    }
}
