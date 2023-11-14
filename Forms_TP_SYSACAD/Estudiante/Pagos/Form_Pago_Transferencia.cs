using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TP_SYSACAD
{
    public partial class Form_Pago_Transferencia : Form
    {
        private string _nombreRemitente;
        private string _cuentaRemitente;
        private string _montoAAbonar;
        private DateTime _fechaActual;
        private Dictionary<string, double> _conceptosSeleccionados = new Dictionary<string, double>();

        public Form_Pago_Transferencia(double montoAAbonar, Dictionary<string, double> conceptosSeleccionados)
        {
            InitializeComponent();

            lblRemitente.Text = "Datos del Remitente: ";
            lblNombreRemit.Text = "Nombre";
            lblCuentaRemit.Text = "Numero de Cuenta (CBU)";
            lblBeneficiario.Text = "Datos del Beneficiario";
            lblNombreBenef.Text = "Nombre: UTNFra";
            lblCuentaBenef.Text = "Numero de Cuenta (CBU): 2112154954879536524011";

            _montoAAbonar = montoAAbonar.ToString();
            lblMonto.Text = $"Monto a Abonar: ${_montoAAbonar}";

            btnAtras.Text = "Atras";
            btnContinuar.Text = "Pagar";

            tbNombreRemit.PlaceholderText = "Apellido Nombre";
            tbCuentaRemit.PlaceholderText = "Ingrese los 22 digitos del CBU";

            _fechaActual = DateTime.Now;
            _conceptosSeleccionados = conceptosSeleccionados;
        }

        private void Form_Pago_Transferencia_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Text = "Pagar con Transferencia Bancaria";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Pagos_Principal formPagosPrincipal = new Form_Pagos_Principal();
            formPagosPrincipal.Show();
        }

        /// <summary>
        /// Maneja el evento de hacer clic en el botón "Continuar" para realizar un pago por transferencia.
        /// </summary>
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
                {
                    { "nombre", _nombreRemitente },
                    { "CBU", _cuentaRemitente }
                };

                //ValidadorInputMediosPago validacionDelInput = new ValidadorInputMediosPago();
                //RespuestaValidacionInput resultadoInputs = validacionDelInput.ValidarDatosMedioDePago(camposIngresados, ModoPago.transferencia);

                ValidadorInputGenerico validacionDelInput = new ValidadorInputGenerico();
                RespuestaValidacionInput resultadoInputs = validacionDelInput.ValidarDatos(camposIngresados, ModoValidacionInput.MediosPagoTransferencia);

                if (!resultadoInputs.AusenciaCamposVacios)
                {
                    throw new Exception("Asegúrese de completar los campos solicitados");
                }

                if (resultadoInputs.ExistenciaErrores)
                {
                    throw new Exception(resultadoInputs.MensajeErrores);
                }

                Sistema.EstudianteLogueado.ActualizarConceptosDePago(_conceptosSeleccionados);

                List<RegistroDePago> listaRegistrosPago = new List<RegistroDePago>();

                foreach (KeyValuePair<string, double> kvp in _conceptosSeleccionados)
                {
                    string concepto = kvp.Key;
                    double valor = kvp.Value;

                    RegistroDePago nuevoRegistroDePago = new RegistroDePago(Sistema.EstudianteLogueado.Legajo, Sistema.EstudianteLogueado.Nombre, concepto, valor, _fechaActual);
                    listaRegistrosPago.Add(nuevoRegistroDePago);
                }

                ConsultasPagos.IngresarNuevoPago(listaRegistrosPago);

                this.Hide();
                Form_Comprobante_Pago formComprobantePago = new Form_Comprobante_Pago(_fechaActual, _montoAAbonar, _conceptosSeleccionados);
                formComprobantePago.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNombreRemit_TextChanged(object sender, EventArgs e)
        {
            _nombreRemitente = tbNombreRemit.Text;
        }

        private void tbCuentaRemit_TextChanged(object sender, EventArgs e)
        {
            _cuentaRemitente = tbCuentaRemit.Text;
        }
    }
}
