using Forms_TP_SYSACAD.Administrador.Reportes;
using Libreria_Clases_TP_SYSACAD;
using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
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
    public partial class Form_Input_Reporte_Periodo : Form
    {
        private FuncionReporte _funcionSeleccionada;
        private DateTime _fechaDesdeSeleccionada;
        private DateTime _fechaHastaSeleccionada;

        Form_Reportes_Principal _formOrigen;

        public Form_Input_Reporte_Periodo(Form_Reportes_Principal formOrigen, FuncionReporte funcionSeleccionada)
        {
            InitializeComponent();

            _funcionSeleccionada = funcionSeleccionada;

            lblInfo.Text = "Ingrese el periodo de inscripciones";
            lblDesde.Text = "Desde:";
            lblHasta.Text = "Hasta:";
            btnContinuar.Text = "Continuar";
            btnCancelar.Text = "Cancelar";
            ConfigurarDateTimePickers();
            _formOrigen = formOrigen;
        }

        private void Form_Reporte_Inscripciones_Totales_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Ingrese los datos";
        }

        private void ConfigurarDateTimePickers()
        {
            // Establece la fecha "Desde" por defecto (ejemplo: 01 de enero de 2023)
            DateTime fechaDesdePorDefecto = new DateTime(2023, 9, 1);

            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.CustomFormat = "dd/MM/yyyy";
            dtpDesde.MinDate = new DateTime(2023, 1, 1);
            dtpDesde.MaxDate = DateTime.Now;
            dtpDesde.Value = fechaDesdePorDefecto;
            _fechaDesdeSeleccionada = fechaDesdePorDefecto;

            // Establece la fecha "Hasta" por defecto (ejemplo: 20 de enero de 2023)
            DateTime fechaHastaPorDefecto = new DateTime(2023, 9, 20);

            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.CustomFormat = "dd/MM/yyyy";
            dtpHasta.MinDate = dtpDesde.Value;
            dtpHasta.MaxDate = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            dtpHasta.Value = fechaHastaPorDefecto.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            _fechaHastaSeleccionada = fechaHastaPorDefecto.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            _fechaDesdeSeleccionada = dtpDesde.Value;
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            _fechaHastaSeleccionada = dtpHasta.Value;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //List<RegistroDeInscripcion> InscripcionesTotalesPorPeriodo = Sistema.BaseDatosInscripciones.ObtenerInscripciones(_fechaDesdeSeleccionada, _fechaHastaSeleccionada);

            if (_funcionSeleccionada == FuncionReporte.InscripcionesTotalesPorPeriodo)
            {
                List<RegistroDeInscripcion> inscripcionesTotalesPorPeriodo = ConsultasInscripciones.ObtenerInscripciones(_fechaDesdeSeleccionada, _fechaHastaSeleccionada);

                if (inscripcionesTotalesPorPeriodo.Count > 0)
                {
                    this.Hide();
                    _formOrigen.Hide();
                    Form_Reporte_Inscripciones formReporteInscripciones = new Form_Reporte_Inscripciones(inscripcionesTotalesPorPeriodo, FuncionReporte.InscripcionesTotalesPorPeriodo, _fechaDesdeSeleccionada, _fechaHastaSeleccionada);
                    formReporteInscripciones.Show();
                }
                else
                {
                    MessageBox.Show("No existen registros que cumplan con los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_funcionSeleccionada == FuncionReporte.ListaEspera)
            {
                Dictionary<Curso, Dictionary<string, DateTime>> cursosConListaDeEsperaSegunFechas = ConsultasCursos.DevolverDiccionarioConRegistrosListaDeEsperaSegunFechas(_fechaDesdeSeleccionada, _fechaHastaSeleccionada);

                if (cursosConListaDeEsperaSegunFechas.Count > 0)
                {
                    this.Hide();
                    _formOrigen.Hide();
                    Form_Reporte_Listas_Espera formReporteListasEspera = new Form_Reporte_Listas_Espera(cursosConListaDeEsperaSegunFechas, _fechaDesdeSeleccionada, _fechaHastaSeleccionada);
                    formReporteListasEspera.Show();
                }
                else
                {
                    MessageBox.Show("No existen registros que cumplan con los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
