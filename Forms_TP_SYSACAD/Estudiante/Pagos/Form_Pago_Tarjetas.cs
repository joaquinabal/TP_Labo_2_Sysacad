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
    public partial class Form_Pago_Tarjetas : Form
    {
        private string _nombre;
        private string _numero;
        private string _vencimiento;
        private string _codigo;
        private string _montoAAbonar;
        private DateTime _fechaActual;
        private Dictionary<string, double> _conceptosSeleccionados = new Dictionary<string, double>();

        public Form_Pago_Tarjetas(double montoAAbonar, Dictionary<string, double> conceptosSeleccionados)
        {
            InitializeComponent();

            lblNombre.Text = "Ingrese su nombre";
            lblNumero.Text = "Numero de la tarjeta";
            lblVencimiento.Text = "Fecha de Vencimiento";
            lblCodigo.Text = "Codigo de Seguridad";

            tbNombre.PlaceholderText = "Apellido Nombre";
            tbNumero.PlaceholderText = "Ingrese los 16 digitos";
            tbVencimiento.PlaceholderText = "MM/AA";
            tbCodigo.PlaceholderText = "Ingrese los 3 digitos";

            btnAtras.Text = "Atras";
            btnPagar.Text = "Pagar";

            _montoAAbonar = montoAAbonar.ToString();
            lblMonto.Text = $"Monto a Abonar: ${_montoAAbonar}";

            _fechaActual = DateTime.Now;
            _conceptosSeleccionados = conceptosSeleccionados;
        }

        private void Form_Pago_Tarjetas_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Text = "Pagar con Tarjeta";
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            _nombre = tbNombre.Text;
        }

        private void tbNumero_TextChanged(object sender, EventArgs e)
        {
            _numero = tbNumero.Text;
        }

        private void tbVencimiento_TextChanged(object sender, EventArgs e)
        {
            _vencimiento = tbVencimiento.Text;
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {
            _codigo = tbCodigo.Text;
        }

        /// <summary>
        /// Maneja el evento de hacer clic en el botón "Pagar" para realizar un pago.
        /// </summary>
        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
                {
                    { "nombre", _nombre },
                    { "numero", _numero },
                    { "vencimiento", _vencimiento },
                    { "codigo", _codigo },
                };

                //ValidadorInputMediosPago validacionDelInput = new ValidadorInputMediosPago();
                //RespuestaValidacionInput resultadoInputs = validacionDelInput.ValidarDatosMedioDePago(camposIngresados, ModoPago.tarjeta);

                ValidadorInputGenerico validacionDelInput = new ValidadorInputGenerico();
                RespuestaValidacionInput resultadoInputs = validacionDelInput.ValidarDatos(camposIngresados, ModoValidacionInput.MediosPagoTarjeta);

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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Pagos_Principal formPagosPrincipal = new Form_Pagos_Principal();
            formPagosPrincipal.Show();
        }
    }
}
