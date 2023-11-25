using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Secundarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
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

namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    public partial class FormReporteIncripcionPorPeriodo : FormPadre
    {
        private List<RegistroDeInscripcion> _listaIncripciones;
        private DateTime _fechaDesde;
        private DateTime _fechaHasta;
        private DateTime _fechaConMasRegistros;
        private double _promedioInscripciones;
        private int _totalInscripciones;
        private BindingSource miBindingSource = new BindingSource();
        private bool _inscripcionFlag = false;
        private GestorReportes gestorReportes = new GestorReportes();


        public FormReporteIncripcionPorPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            InitializeComponent();
            _inscripcionFlag = true;
            _fechaDesde = fechaDesde;
            _fechaHasta = fechaHasta;
            _listaIncripciones = gestorReportes.ObtenerInscripcionesTotalesPorPeriodo(fechaDesde, fechaHasta);
            _fechaConMasRegistros = gestorReportes.CalcularFechaMasPopular(_listaIncripciones);
            _promedioInscripciones = gestorReportes.CalcularMediaPorDia(_listaIncripciones);
            _totalInscripciones = gestorReportes.CalcularRegistrosTotales(_listaIncripciones);
            desdeLabel.Text = $"Desde: {_fechaDesde}";
            hastaLabel.Text = $"Hasta: {_fechaHasta}";
            fechaPopularLabel.Text = $"Fecha con más registros: {_fechaConMasRegistros}";
            mediaPorDiaLabel.Text = $"Media por día: {_promedioInscripciones}";
            inscripcionesTotalesLabel.Text = $"Inscripciones Totales: {_totalInscripciones}";
            ConfigurarBindingSourceInscripciones();
            MostrarInscripciones();
        }

        private void ConfigurarBindingSourceInscripciones()
        {
            BindingList<RegistroDeInscripcion> bindingListaInscripciones = new BindingList<RegistroDeInscripcion>();

            // Asigna la BindingList<Curso> al BindingSource
            miBindingSource.DataSource = bindingListaInscripciones;

            // Enlaza el DataGridView al BindingSource
            inscripcionesDGV.DataSource = miBindingSource;
        }

        private void MostrarInscripciones()
        {
            // Obtenemos el BindingSource que enlaza el DataGridView
            BindingSource bindingSource = (BindingSource)inscripcionesDGV.DataSource;

            // Obtenemos la BindingList<RegistroDeInscripcion> desde el BindingSource
            BindingList<RegistroDeInscripcion> bindingListaInscripciones = (BindingList<RegistroDeInscripcion>)bindingSource.List;


            foreach (RegistroDeInscripcion inscripcion in _listaIncripciones)
            {
                bindingListaInscripciones.Add(inscripcion);
            }

        }

        public static DateTime GetFechaConMasInscripciones(List<RegistroDeInscripcion> listaInscripciones)
        {
            int maxInscripciones = 0;
            DateTime fechaConMasInscripciones = DateTime.MinValue;

            foreach (RegistroDeInscripcion inscripcion in listaInscripciones)
            {
                int inscripcionesEnFecha = 0;

                // Obtenemos la fecha de la inscripción
                DateTime fechaInscripcion = inscripcion.Fecha;

                // Obtenemos el día, mes y año de la inscripción
                int dia = fechaInscripcion.Day;
                int mes = fechaInscripcion.Month;
                int anio = fechaInscripcion.Year;

                // Contamos las inscripciones en la fecha actual
                foreach (RegistroDeInscripcion otraInscripcion in listaInscripciones)
                {
                    if (otraInscripcion.Fecha.Day == dia && otraInscripcion.Fecha.Month == mes && otraInscripcion.Fecha.Year == anio)
                    {
                        inscripcionesEnFecha++;
                    }
                }

                // Si el número de inscripciones en la fecha actual es mayor que el máximo, actualizamos el máximo y la fecha
                if (inscripcionesEnFecha > maxInscripciones)
                {
                    maxInscripciones = inscripcionesEnFecha;
                    fechaConMasInscripciones = fechaInscripcion;
                }
            }

            return fechaConMasInscripciones.Date;
        }

        private void ExportarPDFBtn_Click(object sender, EventArgs e)
        {
            string nombreArchivo = $"InscripcionPorPeriodo{DateTime.Now.ToString("yyyyMMddhhmm")}.PDF";
            GeneradorDePDF.GenerarPDFInscripciones(nombreArchivo, _listaIncripciones, _totalInscripciones, _fechaConMasRegistros, _promedioInscripciones, "REPORTE DE REGISTRO DE INSCRIPCIONES", DateTime.Now.ToString("dd/MM/yyyy"), _fechaDesde.ToString("dd/MM/yyyy"), _fechaHasta.ToString("dd/MM/yyyy"));
            MessageBox.Show($"Se ha creado el reporte {nombreArchivo}.");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelReportes FormPanelReportes = new FormPanelReportes();
            FormPanelReportes.Show();
        }
    }
}
