using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Secundarias;
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
    public partial class FormPanelListasEspera : FormPadre
    {
        private List<Curso> _listaCursos = ConsultasCursos.Cursos;
        private Curso? _cursoSeleccionado;
        private BindingSource miBindingSource = new BindingSource();
        private GestorRequisitos gestorRequisitos = new GestorRequisitos();
        private GestorCursos gestorCursos = new GestorCursos();

        public FormPanelListasEspera()
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
                if (curso.CupoDisponible == 0)
                {
                    bindingListaCursos.Add(curso);
                }
            }

        }

        private void asignarCursoBtn_Click(object sender, EventArgs e)
        {

        }
        private void cursosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtenemos la fila seleccionada

            DataGridViewRow filaSeleccionada = cursosDGV.CurrentRow;

            string? codigoCursoSeleccionado = filaSeleccionada.Cells[1].Value.ToString();

            CursoSeleccionado = gestorCursos.ObtenerCursoDesdeCodigo(codigoCursoSeleccionado);
        }

        private void VerListaEsperaBtn_Click(object sender, EventArgs e)
        {
            if(CursoSeleccionado is not null)
            {
                this.Close();
                FormPanelListasEsperaEstudiantes FormPanelListasEsperaEstudiantes = new FormPanelListasEsperaEstudiantes(CursoSeleccionado);
                FormPanelListasEsperaEstudiantes.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un curso.");
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelAdministrador FormPanelAdministrador = new FormPanelAdministrador();
            FormPanelAdministrador.Show();
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
