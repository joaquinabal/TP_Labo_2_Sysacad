using Libreria_Clases_TP_SYSACAD;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Gestores;
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

namespace Forms_TP_Labo_2_Sysacad
{
    public partial class FormGestionarPagos : FormPadre
    {
        private double _montoTotalAPagar;
        private double _montoConceptoAnterior = 0;
        private Dictionary<int, double> _valoresAnteriores = new Dictionary<int, double>();
        private string _metodoDePago;
        private Dictionary<string, double> _conceptosSeleccionados = new Dictionary<string, double>();
        List<ConceptoDePago> ListaConceptosDePago = new List<ConceptoDePago>();
        private GestorPagos gestorPagos = new GestorPagos();    


        public FormGestionarPagos()
        {
            InitializeComponent();
            mostrarConceptosDePago();
        }

        private void FormGestionarPagos_Load(object sender, EventArgs e)
        {
            metodoPagoCombobox.SelectedIndex = 0;
        }

        private void mostrarConceptosDePago()
        {
            conceptosPagosDGV.Rows.Clear();
            ListaConceptosDePago = Sistema.EstudianteLogueado.ConceptosDePago;

            foreach (ConceptoDePago conceptoPago in ListaConceptosDePago)
            {
                if (conceptoPago.MontoPendiente > 0)
                {
                    conceptosPagosDGV.Rows.Add(conceptoPago.Nombre, conceptoPago.MontoPendiente.ToString(), 0);
                }
            }

        }

        private void continuarBtn_Click(object sender, EventArgs e)
        {

            if (_montoTotalAPagar != 0)
            {
                List<double> listaDeMontosAAbonar = new List<double>();
                List<double> listaDeMontosOriginales = new List<double>();

                //Creamos las listas recorriendo el DGV
                foreach (DataGridViewRow row in conceptosPagosDGV.Rows)
                {
                    if (row.Cells[2].Value != null)
                    {
                        double monto;
                        if (double.TryParse(row.Cells[2].Value.ToString(), out monto))
                        {
                            listaDeMontosAAbonar.Add(monto);
                        }
                    }
                }

                foreach (DataGridViewRow row in conceptosPagosDGV.Rows)
                {
                    if (row.Cells[1].Value != null)
                    {
                        double monto;
                        if (double.TryParse(row.Cells[1].Value.ToString(), out monto))
                        {
                            listaDeMontosOriginales.Add(monto);
                        }
                    }
                }

                string respuestaValidacion = gestorPagos.ValidarMontoAAbonar(listaDeMontosAAbonar, listaDeMontosOriginales);

                //Si no hay ningun error en los campos
                if (respuestaValidacion == "OK")
                {
                    //Creamos el diccionario
                    foreach (DataGridViewRow row in conceptosPagosDGV.Rows)
                    {
                        if (row.Cells[2].Value != null && !string.IsNullOrEmpty(row.Cells[2].Value.ToString()))
                        {
                            double monto;
                            if (double.TryParse(row.Cells[2].Value.ToString(), out monto) && monto > 0)
                            {
                                _conceptosSeleccionados[row.Cells[0].Value.ToString()] = monto;
                            }
                        }
                    }

                    //Enviamos al usuario al formulario de acuerdo al medio de pago seleccionado
                    switch (MetodoDePago)
                    {
                        case "Tarjeta de Debito":
                        case "Tarjeta de Credito":
                            this.Close();
                            FormPagoTarjeta formPagoTarjeta = new FormPagoTarjeta(MontoTotalAPagar, _conceptosSeleccionados, MetodoDePago);
                            formPagoTarjeta.ShowDialog();
                            break;
                        case "Transferencia":
                            this.Hide();
                            FormPagoTransferencia formPagoTransferencia = new FormPagoTransferencia(MontoTotalAPagar, _conceptosSeleccionados, MetodoDePago);
                            formPagoTransferencia.ShowDialog();
                            break;
                    }
                }

                //Si hay errores en los campos los informamos
                else if (respuestaValidacion == "NEGATIVO")
                {
                    MessageBox.Show("No se permite ingresar numeros negativos en el abono", "Numero Negativo Detectado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (respuestaValidacion == "EXCESIVO")
                {
                    MessageBox.Show("Ha ingresado un valor a abonar superior al correspondiente", "Valor Excesivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(respuestaValidacion == "AMBOS MAL")
                {
                    MessageBox.Show("No se permite ingresar numeros negativos en el abono", "Numero Negativo Detectado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Ha ingresado un valor a abonar superior al correspondiente", "Valor Excesivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No ha ingresado un monto a abonar", "Ingrese el monto a abonar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        /// <summary>
        /// Maneja el evento de cambio de valor en las celdas del DataGridView "conceptosPagosDGV".
        /// Calcula el "MontoTotalAPagar" basado en los cambios de valor y actualiza la etiqueta "totalAPagarLbl".
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (en este caso, el DataGridView).</param>
        /// <param name="e">Argumentos del evento que contienen información sobre la celda cambiada.</param>
        private void conceptosPagosDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                DataGridViewCell cell = conceptosPagosDGV.Rows[e.RowIndex].Cells[2];
                if (cell.Value != null && double.TryParse(cell.Value.ToString(), out double nuevoMonto))
                {
                    if (_valoresAnteriores.ContainsKey(e.RowIndex))
                    {
                        double montoAnterior = _valoresAnteriores[e.RowIndex];
                        MontoTotalAPagar -= montoAnterior;
                    }

                    MontoTotalAPagar += nuevoMonto;
                    _valoresAnteriores[e.RowIndex] = nuevoMonto;
                    totalAPagarLbl.Text = $"Total a Pagar: ${MontoTotalAPagar}";
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelEst formPanelEst = new FormPanelEst();
            formPanelEst.Show();
        }

        private void metodoPagoCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetodoDePago = metodoPagoCombobox.SelectedItem.ToString();
        }

        public double MontoTotalAPagar { get { return _montoTotalAPagar; } set { _montoTotalAPagar = value; } }
        public double MontoConceptoAnterior { get { return _montoConceptoAnterior; } set { _montoConceptoAnterior = value; } }

        public string MetodoDePago { get { return _metodoDePago; } set { _metodoDePago = value; } }
    }
}