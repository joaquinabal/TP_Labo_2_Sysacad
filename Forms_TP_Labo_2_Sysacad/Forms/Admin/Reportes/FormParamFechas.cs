using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    public partial class FormParamFechas : FormPadre
    {
        private DateTime _fechaDesde;
        private DateTime _fechaHasta;
        private Reporte _reporteSeleccionado;
        private Curso _cursoSeleccionado;
        private string _conceptoPago;
        private Carrera? _carrera;
        public FormParamFechas(Reporte tipoReporte)
        {
            InitializeComponent();
            desdeDTP.Value = new DateTime(2023, 1, 1, 00, 00, 00);
            hastaDTP.Value = new DateTime(2023, 12, 31, 23, 59, 59);
            ReporteSeleccionado = tipoReporte;
            if (ReporteSeleccionado == Reporte.IngresoPorConceptoDePago)
            {
                ActivarMostrarConceptosDePago();
            }
            else if (ReporteSeleccionado == Reporte.InscripcionPorCarrera)
            {
                ActivarMostrarCarreras();
            }
        }

        public FormParamFechas(Reporte tipoReporte, Curso curso)
        {
            InitializeComponent();
            desdeDTP.Value = new DateTime(2023, 1, 1, 00, 00, 00);
            hastaDTP.Value = new DateTime(2023, 12, 31, 23, 59, 59);
            ReporteSeleccionado = tipoReporte;
            CursoSeleccionado = curso;
        }

        /// <summary>
        /// Activa y muestra los elementos relacionados con los conceptos de pago en la interfaz.
        /// </summary>
        private void ActivarMostrarConceptosDePago()
        {
            conceptoPagoLbl.Visible = true;
            conceptoPagoLbl.Enabled = true;
            conceptoPagoComboBox.Visible = true;
            conceptoPagoComboBox.Enabled = true;
        }

        /// <summary>
        /// Activa y muestra los elementos relacionados con la selección de carreras en la interfaz.
        /// </summary>
        private void ActivarMostrarCarreras()
        {
            carreraLbl.Visible = true;
            carreraLbl.Enabled = true;
            carreraComboBox.Visible = true;
            carreraComboBox.Enabled = true;
        }

        private void desdeDTP_ValueChanged(object sender, EventArgs e)
        {
            _fechaDesde = desdeDTP.Value;
        }

        private void hastaDTP_ValueChanged(object sender, EventArgs e)
        {
            _fechaHasta = hastaDTP.Value;
        }

        private void generarReporteBtn_Click(object sender, EventArgs e)
        {
            if (ReporteSeleccionado == Reporte.InscripcionPorPeriodo)
            {
                this.Close();
                FormReporteIncripcionPorPeriodo FormReporte = new FormReporteIncripcionPorPeriodo(_fechaDesde, _fechaHasta);
                FormReporte.Show();
            }
            else if (ReporteSeleccionado == Reporte.ListaDeEsperaDeCursos)
            {
                this.Close();
                FormReporteListaEsperaCursos FormReporte = new FormReporteListaEsperaCursos(_fechaDesde, _fechaHasta);
                FormReporte.Show();
            }
            else if (ReporteSeleccionado == Reporte.EstudiantesEnCursoEspecifico)
            {
                this.Close();
                FormReporteEstudiantesCursoEspecifico FormReporteEstudiantesCursoEspecifico = new FormReporteEstudiantesCursoEspecifico(CursoSeleccionado, _fechaDesde, _fechaHasta);
                FormReporteEstudiantesCursoEspecifico.Show();

            }
            else if (ReporteSeleccionado == Reporte.IngresoPorConceptoDePago)
            {
                if (_conceptoPago == null)
                {
                    MessageBox.Show("Selecciona un concepto de pago.");
                }
                else
                {
                    this.Close();
                    FormReporteIngresosConceptoPago FormReporteIngresosConceptoPago = new FormReporteIngresosConceptoPago(_conceptoPago, _fechaDesde, _fechaHasta);
                    FormReporteIngresosConceptoPago.Show();
                }
            }
            else if (ReporteSeleccionado == Reporte.InscripcionPorCarrera)
            {
                if (_carrera == null)
                {
                    MessageBox.Show("Selecciona una carrera.");
                }
                else
                {
                    this.Close();
                    FormReporteInscripcionPorCarrera FormReporteInscripcionPorCarrera = new FormReporteInscripcionPorCarrera((Carrera)_carrera, _fechaDesde, _fechaHasta);
                    FormReporteInscripcionPorCarrera.Show();
                }

            }
        }

        private void conceptoPagoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _conceptoPago = conceptoPagoComboBox.Text;
        }

        private void carreraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _carrera = (Carrera)carreraComboBox.SelectedIndex;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelReportes FormPanelReportes = new FormPanelReportes();
            FormPanelReportes.Show();
        }

        public Reporte ReporteSeleccionado
        {
            get { return _reporteSeleccionado; }
            set { _reporteSeleccionado = value; }
        }

        public Curso CursoSeleccionado
        {
            get { return _cursoSeleccionado; }
            set { _cursoSeleccionado = value; }
        }
    }
}
