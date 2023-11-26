using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Gestores;
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
    public partial class FormParamCursoEspecifico : FormPadre
    {
        private List<Curso> _listaCursos = ConsultasCursos.Cursos;
        private Curso? _cursoSeleccionado;
        private BindingSource miBindingSource = new BindingSource();
        private GestorCursos gestorCursos = new GestorCursos(); 

        public FormParamCursoEspecifico()
        {
            InitializeComponent();
            ConfigurarBindingSource();
            MostrarCursos();
        }

        /// <summary>
        /// Configura el enlace de datos entre una lista de cursos y un DataGridView mediante un BindingSource.
        /// </summary>
        private void ConfigurarBindingSource()
        {
            BindingList<Curso> bindingListaCursos = new BindingList<Curso>();
            // Aquí puedes agregar los cursos a la BindingList<Curso>

            // Asigna la BindingList<Curso> al BindingSource
            miBindingSource.DataSource = bindingListaCursos;

            // Enlaza el DataGridView al BindingSource
            cursosDGV.DataSource = miBindingSource;
        }
        /// <summary>
        /// Muestra una lista de cursos enlazados al DataGridView correspondiente.
        /// </summary>
        private void MostrarCursos()
        {
            // Obtenemos el BindingSource que enlaza el DataGridView
            BindingSource bindingSource = (BindingSource)cursosDGV.DataSource;

            // Obtenemos la BindingList<Curso> desde el BindingSource
            BindingList<Curso> bindingListaCursos = (BindingList<Curso>)bindingSource.List;

            foreach (Curso curso in ListaCursos)
            {
                bindingListaCursos.Add(curso);
            }
        }


        private void generarReporteBtn_Click(object sender, EventArgs e)
        {
            if (CursoSeleccionado != null)
            {
                this.Close();
                FormParamFechas FormParamFechas = new FormParamFechas(Reporte.EstudiantesEnCursoEspecifico, CursoSeleccionado);
                FormParamFechas.Show();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún curso.");
            }
        }

        private void cursosDGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = cursosDGV.CurrentRow;

            string codigoCursoSelecionado = filaSeleccionada.Cells[1].Value.ToString();

            CursoSeleccionado = gestorCursos.ObtenerCursoDesdeCodigo(codigoCursoSelecionado);

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

        public Curso? CursoSeleccionado
        {
            get { return _cursoSeleccionado; }
            set { _cursoSeleccionado = value; }
        }
    }
}
