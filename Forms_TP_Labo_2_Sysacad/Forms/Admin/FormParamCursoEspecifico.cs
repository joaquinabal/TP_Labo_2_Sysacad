using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
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
    public partial class FormParamCursoEspecifico : FormPadre
    {
        private List<Curso> _listaCursos = ConsultasCursos.Cursos;
        private Curso _cursoSeleccionado;
        private BindingSource miBindingSource = new BindingSource();

        public FormParamCursoEspecifico()
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

            string nombreCursoSeleccionado = filaSeleccionada.Cells[0].Value.ToString();
            string codigoCursoSelecionado = filaSeleccionada.Cells[1].Value.ToString();
            string descripcionCursoSelecionado = filaSeleccionada.Cells[2].Value.ToString();
            string cupoMaxCursoSelecionado = filaSeleccionada.Cells[3].Value.ToString();
            string turnoCursoSeleccionado = filaSeleccionada.Cells[5].Value.ToString();
            string aulaCursoSeleccionado = filaSeleccionada.Cells[6].Value.ToString();
            string diaCursoSeleccionado = filaSeleccionada.Cells[7].Value.ToString();
            int carreraCursoSeleccionado = (int)filaSeleccionada.Cells[8].Value;

            CursoSeleccionado = new Curso(nombreCursoSeleccionado, codigoCursoSelecionado, descripcionCursoSelecionado, int.Parse(cupoMaxCursoSelecionado), turnoCursoSeleccionado, aulaCursoSeleccionado, diaCursoSeleccionado, (Carrera)carreraCursoSeleccionado);

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
