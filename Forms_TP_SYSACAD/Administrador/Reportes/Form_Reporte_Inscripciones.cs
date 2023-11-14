using Libreria_Clases_TP_SYSACAD;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Herramientas;
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
    public partial class Form_Reporte_Inscripciones : Form
    {
        private int _inscripcionesTotales;
        private DateTime _fechaPopular;
        private double _mediaPorDia;
        private FuncionReporte _funcionReporte;
        private List<RegistroDeInscripcion> _listaRegistrosAMostrar;
        private DateTime _fechaDesdeRecibida;
        private DateTime _fechaHastaRecibida;

        public Form_Reporte_Inscripciones(List<RegistroDeInscripcion> listaRegistrosAMostrar, FuncionReporte funcionSeleccionada, DateTime fechaDesdeRecibida, DateTime fechaHastaRecibida)
        {
            InitializeComponent();

            MostrarRegistrosDeInscripcion(listaRegistrosAMostrar);

            _listaRegistrosAMostrar = listaRegistrosAMostrar;
            _inscripcionesTotales = EstadisticasReportes.CalcularRegistrosTotales(listaRegistrosAMostrar);
            _fechaPopular = EstadisticasReportes.CalcularFechaMasPopular(listaRegistrosAMostrar);
            _mediaPorDia = EstadisticasReportes.CalcularMediaPorDia(listaRegistrosAMostrar);
            _funcionReporte = funcionSeleccionada;
            _fechaDesdeRecibida = fechaDesdeRecibida;
            _fechaHastaRecibida = fechaHastaRecibida;

            lblInfo.Text = "Estadisticas:";
            lblTotales.Text = $"Inscripciones totales: {_inscripcionesTotales}";
            lblFechaPopular.Text = $"Fecha con mayor cantidad de inscripciones: {_fechaPopular.Date.ToString("dd/MM/yyyy")}";
            lblMediaPorDia.Text = $"Media de Inscripciones por dia: {_mediaPorDia}";

            btnPanel.Text = "Volver al Panel";
            btnPDF.Text = "Descargar PDF";
        }

        private void MostrarRegistrosDeInscripcion(List<RegistroDeInscripcion> listaRegistrosAMostrar)
        {
            listViewInscripciones.Items.Clear();

            foreach (RegistroDeInscripcion registro in listaRegistrosAMostrar)
            {
                ListViewItem nuevaFila = new ListViewItem(registro.Carrera.ToString());
                nuevaFila.SubItems.Add(registro.Legajo);
                nuevaFila.SubItems.Add(registro.NombreAlumno);
                nuevaFila.SubItems.Add(registro.CodigoCurso);
                nuevaFila.SubItems.Add(registro.NombreCurso);
                nuevaFila.SubItems.Add(registro.Fecha.ToString());

                listViewInscripciones.Items.Add(nuevaFila);
            }
        }

        private void Form_Inscr_Totales_Periodo_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Reporte de Inscripciones";
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Panel_Administracion formPanelAdministracion = new Form_Panel_Administracion();
            formPanelAdministracion.Show();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            string fechaYHora = DateTime.Now.ToString("dd-MM-yyyy HH.mm");
            string fechaDesde = _fechaDesdeRecibida.ToString("dd-MM-yyyy");
            string fechaHasta = _fechaHastaRecibida.ToString("dd-MM-yyyy");

            switch (_funcionReporte)
            {
                case FuncionReporte.InscripcionesTotalesPorPeriodo:

                    string nombreArchivoPDFUno = $"Reporte Inscripciones Totales {fechaYHora}.pdf";
                    bool resultadoGeneracionPfdUno = GeneradorDePDF.GenerarPDFInscripciones(nombreArchivoPDFUno,
                        _listaRegistrosAMostrar, _inscripcionesTotales, _fechaPopular, _mediaPorDia, "REPORTE DE INSCRIPCIONES TOTALES", fechaYHora, fechaDesde, fechaHasta);

                    if (resultadoGeneracionPfdUno)
                    {
                        MessageBox.Show("Se ha guardado el archivo PDF en la carpeta 'Inscripciones' localizada en 'Documentos/SYSACAD/Reportes PDF'", "PDF Generado Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("No ha sido posible generar el PDF", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case FuncionReporte.InscripcionesPorCursoPeriodo:
                    string nombreArchivoPDFDos = $"Reporte Inscripciones por Curso {fechaYHora}.pdf";
                    bool resultadoGeneracionPfdDos = GeneradorDePDF.GenerarPDFInscripciones(nombreArchivoPDFDos,
                        _listaRegistrosAMostrar, _inscripcionesTotales, _fechaPopular, _mediaPorDia, "REPORTE DE INSCRIPCIONES SEGUN CURSO", fechaYHora, fechaDesde, fechaHasta);

                    if (resultadoGeneracionPfdDos)
                    {
                        MessageBox.Show("Se ha guardado el archivo PDF en la carpeta 'Inscripciones' localizada en 'Documentos/SYSACAD/Reportes PDF'", "PDF Generado Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("No ha sido posible generar el PDF", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case FuncionReporte.InscripcionesPorCarreraPeriodo:
                    string nombreArchivoPDFTres = $"Reporte Inscripciones por Carrera {fechaYHora}.pdf";
                    bool resultadoGeneracionPfdTres = GeneradorDePDF.GenerarPDFInscripciones(nombreArchivoPDFTres,
                        _listaRegistrosAMostrar, _inscripcionesTotales, _fechaPopular, _mediaPorDia, "Reporte de Inscripciones segun Carrera", fechaYHora, fechaDesde, fechaHasta);

                    if (resultadoGeneracionPfdTres)
                    {
                        MessageBox.Show("Se ha guardado el archivo PDF en la carpeta 'Inscripciones' localizada en 'Documentos/SYSACAD/Reportes PDF'", "PDF Generado Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("No ha sido posible generar el PDF", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
            }
        }
    }
}
