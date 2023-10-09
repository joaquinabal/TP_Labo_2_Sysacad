using Libreria_Clases_TP_SYSACAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TP_Labo_2_Sysacad
{
    public partial class FormPagoTransferencia : FormPadre
    {
        private string _CBU;
        private string _nombre;
        private string _metodoDePago;
        private Dictionary<string, double> _conceptosSeleccionados;
        private string _monto;

        public FormPagoTransferencia(double montoAPagar, Dictionary<string, double> conceptosSeleccionados, string metodoDePago)
        {
            InitializeComponent();
            ConceptosSeleccionados = conceptosSeleccionados;
            MetodoDePago = metodoDePago;
            Monto = montoAPagar.ToString();
        }

        private void pagarBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dirCampos = new Dictionary<string, string>
            {
                { "nombre", Nombre },
                { "CBU", CBU},
            };

            ValidadorInputMediosPago validadorTransfer = new ValidadorInputMediosPago();

            RespuestaValidacionInput resultadoValidacion = validadorTransfer.ValidarDatosMedioDePago(dirCampos, modo: ModoPago.transferencia);

            if (resultadoValidacion.AusenciaCamposVacios == false)
            {
                MessageBox.Show("Asegurese de completar los campos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!resultadoValidacion.ExistenciaErrores)
            {
                Sistema.EstudianteLogueado.ActualizarConceptosDePago(ConceptosSeleccionados);
                this.Close();
                FormComprobantePago formComprobantePago = new FormComprobantePago(Monto, ConceptosSeleccionados);
                formComprobantePago.ShowDialog();
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
            formGestionarPagos.Show();
        }

        private void nombreTxtbox_TextChanged(object sender, EventArgs e)
        {
            Nombre = nombreTxtbox.Text;
        }

        private void CBUTxtbox_TextChanged(object sender, EventArgs e)
        {
            CBU = CBUTxtbox.Text;
        }

        public string CBU
        {
            get { return _CBU; }
            set { _CBU = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string MetodoDePago
        {
            get { return _metodoDePago; }
            set { _metodoDePago = value; }
        }

        public Dictionary<string, double> ConceptosSeleccionados
        {
            get { return _conceptosSeleccionados; }
            set { _conceptosSeleccionados = value; }
        }

        public string Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }
    }
}
