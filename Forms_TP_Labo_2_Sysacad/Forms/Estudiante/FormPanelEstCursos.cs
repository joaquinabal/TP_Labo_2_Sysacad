using Libreria_Clases_TP_SYSACAD;
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
    public partial class FormPanelEstCursos : FormPadre
    {
        private List<Curso> _listaCursos = new List<Curso>();
        private BindingSource miBindingSource = new BindingSource();

        public FormPanelEstCursos()
        {
            InitializeComponent();
            ConfigurarBindingSource();
            MostrarCursos();
        }
        /// <summary>
        /// Configura la fuente de datos (BindingSource) y enlaza el DataGridView a la lista de cursos.
        /// </summary>
        private void ConfigurarBindingSource()
        {
            BindingList<Curso> bindingListaCursos = new BindingList<Curso>();
            // Asigna la BindingList<Curso> al BindingSource
            miBindingSource.DataSource = bindingListaCursos;
            // Enlaza el DataGridView al BindingSource
            cursosDGV.DataSource = miBindingSource;
        }

        /// <summary>
        /// Muestra los cursos inscritos por el estudiante actual en el DataGridView.
        /// </summary>
        private void MostrarCursos()
        {
            ListaCursos = Sistema.EstudianteLogueado.CursosInscriptos;
            // Obtenemos el BindingSource que enlaza el DataGridView
            BindingSource bindingSource = (BindingSource)cursosDGV.DataSource;
            // Obtenemos la BindingList<Curso> desde el BindingSource
            BindingList<Curso> bindingListaCursos = (BindingList<Curso>)bindingSource.List;
            foreach (Curso curso in ListaCursos)
            {
                bindingListaCursos.Add(curso);
            }
        }

        private void agregarCursoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInscripcionCurso formInscripcionCurso = new FormInscripcionCurso();
            formInscripcionCurso.ShowDialog();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelEst formPanelEst = new FormPanelEst();
            formPanelEst.ShowDialog();
        }

        public List<Curso> ListaCursos
        {
            get { return _listaCursos; }
            set { _listaCursos = value; }
        }
    }
}
