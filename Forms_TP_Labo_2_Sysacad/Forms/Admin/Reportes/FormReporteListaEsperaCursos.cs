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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    public partial class FormReporteListaEsperaCursos : FormPadre
    {
        private List<Curso> _listaCursos;
        Dictionary<Curso, Dictionary<string, DateTime>> _dictCursosListaEspera;
        private DateTime _fechaDesde;
        private DateTime _fechaHasta;
        private GestorReportes gestorReportes = new GestorReportes();

        public FormReporteListaEsperaCursos(DateTime fechaDesde, DateTime fechaHasta)
        {
            InitializeComponent();

            _fechaDesde = fechaDesde;
            _fechaHasta = fechaHasta;
            DictCursosListaEspera = gestorReportes.ObtenerCursosConListaDeEsperaSegunFechas(_fechaDesde, _fechaHasta);
            AgregarColumnas();
            AgregarCamposAlLW();
        }

        /// <summary>
        /// Agrega una columna al control ListView para mostrar información de cursos.
        /// </summary>
        private void AgregarColumnas()
        {
            cursosLV.Columns.Add("Curso", "Curso");
            cursosLV.Columns["Curso"].Width = 500;
        }

        /// <summary>
        /// Agrega información de cursos y sus listas de espera al control ListView.
        /// </summary>
        private void AgregarCamposAlLW()
        {
            foreach (Curso curso in DictCursosListaEspera.Keys)
            {
                foreach (KeyValuePair<string, DateTime> alumnoFecha in curso.ListaDeEspera)
                {

                    string alumno = alumnoFecha.Key;
                    DateTime fecha = alumnoFecha.Value;

                    ListViewItem nuevaFila = new ListViewItem($"{curso.Nombre} || {curso.Turno} || {alumno} || {fecha}");
                    nuevaFila.SubItems.Add(curso.Turno);
                    nuevaFila.SubItems.Add(alumno);
                    nuevaFila.SubItems.Add(fecha.ToString());

                    cursosLV.Items.Add(nuevaFila);
                }
            }
            cursosLV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void ExportarPDFBtn_Click(object sender, EventArgs e)
        {
            string nombreArchivo = $"ListaEspera{DateTime.Now.ToString("yyyyMMddhhmm")}.PDF";
            GeneradorDePDF.GenerarPDFListaEspera(nombreArchivo, DictCursosListaEspera, DateTime.Now.ToString(), _fechaDesde.ToString(), _fechaHasta.ToString());
            MessageBox.Show($"Se ha creado el reporte {nombreArchivo}.");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelReportes FormPanelReportes = new FormPanelReportes();
            FormPanelReportes.Show();
        }

        public List<Curso> ListaCursos
        {
            get { return _listaCursos; }
            set { _listaCursos = value; }
        }

        public Dictionary<Curso, Dictionary<string, DateTime>> DictCursosListaEspera
        {
            get { return _dictCursosListaEspera; }
            set { _dictCursosListaEspera = value; }
        }
    }
}
