using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.Entidades_Secundarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
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
    public partial class FormAsignarCursoAProf : FormPadre
    {
        private List<Curso> _listaCursos;
        private List<Curso> _listaCursosAsignados;
        private Curso _cursoSeleccionado;
        private BindingSource miBindingSourceCursos = new BindingSource();
        private BindingSource miBindingSourceCursosAsignados = new BindingSource();
        private Profesor _profesor;
        private GestorCursos gestorCursos = new GestorCursos();

        public FormAsignarCursoAProf(Profesor profesor)
        {
            InitializeComponent();
            _profesor = profesor;
            ListaCursosAsignados = gestorCursos.ObtenerListaCursosDesdeListaCodigos(Profesor.CodigosCursosDeProfesor);
            ConfigurarBindingSource();
            MostrarCursosAsignados();
            MostrarCursos();
        }

        private void ConfigurarBindingSource()
        {
            BindingList<Curso> bindingListaCursos = new BindingList<Curso>();
            BindingList<Curso> bindingListaCursosAsignados = new BindingList<Curso>();

            // Asigna la BindingList<Curso> al BindingSource
            miBindingSourceCursos.DataSource = bindingListaCursos;
            miBindingSourceCursosAsignados.DataSource = bindingListaCursosAsignados;

            // Enlaza el DataGridView al BindingSource correspondiente
            cursosDGV.DataSource = miBindingSourceCursos;
            cursosAsignadosDGV.DataSource = miBindingSourceCursosAsignados;
        }

        private void MostrarCursosAsignados()
        {

            // Obtenemos el BindingSource que enlaza el DataGridView
            BindingSource bindingSource = (BindingSource)cursosAsignadosDGV.DataSource;

            // Obtenemos la BindingList<Curso> desde el BindingSource
            BindingList<Curso> bindingListaCursosAsignados = (BindingList<Curso>)bindingSource.List;

            // Limpiamos la lista antes de agregar los cursos asignados
            bindingListaCursosAsignados.Clear();

            foreach (Curso curso in ListaCursosAsignados)
            {
                bindingListaCursosAsignados.Add(curso);
            }
        }

        private void MostrarCursos()
        {
            _listaCursos = ConsultasCursos.Cursos;
            // Obtenemos el BindingSource que enlaza el DataGridView
            BindingSource bindingSource = (BindingSource)cursosDGV.DataSource;

            // Obtenemos la BindingList<Curso> desde el BindingSource
            BindingList<Curso> bindingListaCursos = (BindingList<Curso>)bindingSource.List;

            // Limpiamos la lista antes de agregar los cursos
            bindingListaCursos.Clear();

            foreach (Curso curso in _listaCursos)
            {
                bindingListaCursos.Add(curso);
            }
        }

        private async void asignarCursoBtn_Click(object sender, EventArgs e)
        {
            bool resultadoValidacion = ValidadorAsignacionCursoAProfesor.ValidarAsignacionDeCursoAProfesor(CursoSeleccionado.Codigo, Profesor);
            if (resultadoValidacion)
            {
                await ConsultasProfesores.AgregarCursoAProfesor(Profesor.Correo, CursoSeleccionado.Codigo);
                MessageBox.Show("Asignación exitosa", "ASIGNACIÓN", MessageBoxButtons.OK);
                this.Close();
                FormPanelAdmProf FormPanelAdmProf = new FormPanelAdmProf();
                FormPanelAdmProf.Show();
            }

        }

        private void cursosDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelAdmProf FormPanelAdmProf = new FormPanelAdmProf();
            FormPanelAdmProf.Show();
        }

        private void cursosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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

        public List<Curso> ListaCursos
        {
            get { return _listaCursos; }
            set { _listaCursos = value; }
        }
        public List<Curso> ListaCursosAsignados
        {
            get { return _listaCursosAsignados; }
            set { _listaCursosAsignados = value; }
        }

        public Curso CursoSeleccionado
        {
            get { return _cursoSeleccionado; }
            set { _cursoSeleccionado = value; }
        }

        public Profesor Profesor
        {
            get { return _profesor; }
            set { _profesor = value; }
        }
    }
}
