using Libreria_Clases_TP_SYSACAD;
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
        private List<RegistroDePago> _listaRegistroDePagos = new List<RegistroDePago>();

        public FormPagoTransferencia(double montoAPagar, Dictionary<string, double> conceptosSeleccionados, string metodoDePago)
        {
            InitializeComponent();
            ConceptosSeleccionados = conceptosSeleccionados;
            MetodoDePago = metodoDePago;
            Monto = montoAPagar.ToString();
           // _registroDePago = new RegistroDePago(Sistema.EstudianteLogueado.Legajo, Nombre, )
        }

       private List<RegistroDePago> GenerarListaRegistroDePagos()
        {
            List<RegistroDePago> listaRegistroPagos = new List<RegistroDePago>();
            foreach (KeyValuePair<string,double> concepto in ConceptosSeleccionados)
            {
                RegistroDePago registroDePago = new RegistroDePago(Sistema.EstudianteLogueado.Legajo, Nombre, concepto.Key, concepto.Value, DateTime.Now);
                listaRegistroPagos.Add(registroDePago); 
            }
            return listaRegistroPagos;
        }

        private async void pagarBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dirCampos = new Dictionary<string, string>
            {
                { "nombre", Nombre },
                { "CBU", CBU},
            };

            _listaRegistroDePagos = GenerarListaRegistroDePagos();

            ValidadorInputGenerico validadorTransfer = new ValidadorInputGenerico();

            RespuestaValidacionInput resultadoValidacion = validadorTransfer.ValidarDatos(dirCampos, ModoValidacionInput.MediosPagoTransferencia);

            if (resultadoValidacion.AusenciaCamposVacios == false)
            {
                MessageBox.Show("Asegurese de completar los campos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!resultadoValidacion.ExistenciaErrores)
            {
                await ConsultasPagos.IngresarNuevoPago(_listaRegistroDePagos);
                await Sistema.EstudianteLogueado.ActualizarConceptosDePago(ConceptosSeleccionados);
                Sistema.IngresarEstudianteComoUsuarioActivo(Sistema.EstudianteLogueado.Correo);
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
