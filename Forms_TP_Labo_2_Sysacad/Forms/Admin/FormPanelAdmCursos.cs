using Libreria_Clases_TP_SYSACAD;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;

namespace Forms_TP_Labo_2_Sysacad
{
    public partial class FormPanelAdmCursos : FormPadre
    {
        private List<Curso> _listaCursos = ConsultasCursos.Cursos;
        private Curso _cursoSeleccionado;
        private BindingSource miBindingSource = new BindingSource();

        public FormPanelAdmCursos()
        {
            InitializeComponent();
            ConfigurarBindingSource();
            MostrarCursos();
        }

        private void ConfigurarBindingSource()
        {
            BindingList<Curso> bindingListaCursos = new BindingList<Curso>();
            // Aquí puedes agregar los cursos a la BindingList<Curso>

            // Asigna la BindingList<Curso> al BindingSource
            miBindingSource.DataSource = bindingListaCursos;

            // Enlaza el DataGridView al BindingSource
            cursosDGV.DataSource = miBindingSource;
        }

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

        private void editarCursoBtn_Click(object sender, EventArgs e)
        {
            if (CursoSeleccionado != null)
            {

                this.Close();
                FormEditarCurso formEditarCurso = new FormEditarCurso(CursoSeleccionado);
                formEditarCurso.Show();

            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún curso.");
            }
        }


        private void cursosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtenemos la fila seleccionada

            DataGridViewRow filaSeleccionada = cursosDGV.CurrentRow;

            string nombreCursoSeleccionado = filaSeleccionada.Cells[0].Value.ToString();
            string codigoCursoSelecionado = filaSeleccionada.Cells[1].Value.ToString();
            string descripcionCursoSelecionado = filaSeleccionada.Cells[2].Value.ToString();
            string cupoMaxCursoSelecionado = filaSeleccionada.Cells[3].Value.ToString();
            string turnoCursoSeleccionado = filaSeleccionada.Cells[5].Value.ToString();
            string aulaCursoSeleccionado = filaSeleccionada.Cells[6].Value.ToString();
            string diaCursoSeleccionado = filaSeleccionada.Cells[7].Value.ToString();

            CursoSeleccionado = new Curso(nombreCursoSeleccionado, codigoCursoSelecionado, descripcionCursoSelecionado, int.Parse(cupoMaxCursoSelecionado), turnoCursoSeleccionado, aulaCursoSeleccionado, diaCursoSeleccionado, Carrera.TUSI);
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FormPanelAdministrador formPanelAdministrador = new FormPanelAdministrador();
            formPanelAdministrador.Show();
        }

        private void agregarCursoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAgregarCurso formAgregarCurso = new FormAgregarCurso();
            formAgregarCurso.Show();
        }

        private void eliminarCursoBtn_Click(object sender, EventArgs e)
        {
            if (CursoSeleccionado != null)
            {

                this.Close();
                FormEliminarCurso formEliminarCurso = new FormEliminarCurso(CursoSeleccionado);
                formEliminarCurso.Show();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún curso.");
            }
        }

        private void cursosDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public List<Curso> ListaCursos
        {
            get { return _listaCursos; }
            set { _listaCursos = value; }
        }

        public Curso CursoSeleccionado
        {
            get { return _cursoSeleccionado; }
            set { _cursoSeleccionado = value; }
        }
    }
}
