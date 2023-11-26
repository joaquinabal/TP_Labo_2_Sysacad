using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Gestores;
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
    public partial class FormReporteEstudiantesCursoEspecifico : FormPadre
    {
        private List<RegistroDeInscripcion> _listaIncripciones;
        private DateTime _fechaDesde;
        private DateTime _fechaHasta;
        private DateTime _fechaConMasRegistros;
        private double _promedioInscripciones;
        private int _totalInscripciones;
        private BindingSource miBindingSource = new BindingSource();
        private Curso? _cursoSeleccionado;
        private GestorReportes gestorReportes = new GestorReportes();

        public FormReporteEstudiantesCursoEspecifico(Curso curso, DateTime fechaDesde, DateTime fechaHasta)
        {
            InitializeComponent();

            _cursoSeleccionado = curso;
            _fechaDesde = fechaDesde;
            _fechaHasta = fechaHasta;

            _listaIncripciones = gestorReportes.ObtenerInscripcionesPorCursoPeriodo(fechaDesde, fechaHasta, _cursoSeleccionado.Codigo);
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

        /// <summary>
        /// Configura el enlace de datos entre una lista de inscripciones y un DataGridView mediante un BindingSource.
        /// </summary>
        private void ConfigurarBindingSourceInscripciones()
        {
            BindingList<RegistroDeInscripcion> bindingListaInscripciones = new BindingList<RegistroDeInscripcion>();

            // Asigna la BindingList<Curso> al BindingSource
            miBindingSource.DataSource = bindingListaInscripciones;

            // Enlaza el DataGridView al BindingSource
            inscripcionesDGV.DataSource = miBindingSource;
        }

        /// <summary>
        /// Muestra una lista de inscripciones enlazadas al DataGridView correspondiente.
        /// </summary>
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

        private void ExportarPDFBtn_Click(object sender, EventArgs e)
        {
            string nombreArchivo = $"EstudiantesCursoEspecifico{DateTime.Now.ToString("yyyyMMddhhmm")}.PDF";
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
