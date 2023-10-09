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
    public partial class FormInscripcionCurso : FormPadre
    {
        private List<Curso> _listaCursos = new List<Curso>();
        private Curso _cursoSeleccionado;
        private BindingSource miBindingSource = new BindingSource();
        private bool hayCursoSeleccionado = false;

        public FormInscripcionCurso()
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
            // Crea una nueva BindingList<Curso> para almacenar los cursos.
            BindingList<Curso> bindingListaCursos = new BindingList<Curso>();

            // Asigna la BindingList<Curso> al objeto BindingSource (miBindingSource).
            miBindingSource.DataSource = bindingListaCursos;

            // Enlaza el DataGridView (cursosDGV) al BindingSource para mostrar los cursos en la interfaz de usuario.
            cursosDGV.DataSource = miBindingSource;
        }

        /// <summary>
        /// Muestra los cursos obtenidos desde la base de datos en el DataGridView.
        /// </summary>
        private void MostrarCursos()
        {
            ListaCursos = Sistema.BaseDatosCursos.Cursos;

            // Obtiene el BindingSource que enlaza el DataGridView (cursosDGV).
            BindingSource bindingSource = (BindingSource)cursosDGV.DataSource;

            // Obtiene la BindingList<Curso> desde el BindingSource para agregar cursos.
            BindingList<Curso> bindingListaCursos = (BindingList<Curso>)bindingSource.List;

            // Itera a través de los cursos en "ListaCursos" y los agrega a la BindingList<Curso>.
            foreach (Curso curso in ListaCursos)
            {
                bindingListaCursos.Add(curso);
            }
        }


        private void inscribirseBtn_Click(object sender, EventArgs e)
        {
            if (hayCursoSeleccionado)
            {
                ValidadorYAdministradorDeCupos validadorCursos = new ValidadorYAdministradorDeCupos();
                List<Curso> listaCursoSeleccionado = new List<Curso> { CursoSeleccionado };
                bool cursoRepetido = false;
                foreach (Curso curso in Sistema.EstudianteLogueado.CursosInscriptos)
                {
                    if (curso.Codigo == CursoSeleccionado.Codigo)
                    {
                        cursoRepetido = true;
                        MessageBox.Show("No puedes volver a inscribirte al mismo curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (!cursoRepetido)
                {
                    validadorCursos.ValidarCursosSegunCupo(listaCursoSeleccionado);
                    if (CursoSeleccionado.CupoDisponible <= 0)
                    {
                        MessageBox.Show("No hay cupos disponibles para este curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Alumno inscripto correctamente.");
                        this.Hide();
                        FormPanelEstCursos formPanelEstCursos = new FormPanelEstCursos();
                        formPanelEstCursos.ShowDialog();
                    }

                }

            }
            else
            {
                MessageBox.Show("Selecciona un curso nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cursosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hayCursoSeleccionado = true;
            DataGridViewRow filaSeleccionada = cursosDGV.CurrentRow;


            string nombreCursoSeleccionado = filaSeleccionada.Cells[0].Value.ToString();
            string codigoCursoSelecionado = filaSeleccionada.Cells[1].Value.ToString();
            string descripcionCursoSelecionado = filaSeleccionada.Cells[2].Value.ToString();
            string cupoMaxCursoSelecionado = filaSeleccionada.Cells[3].Value.ToString();
            string cupoDisponibleSeleccionado = filaSeleccionada.Cells[4].Value.ToString();
            string turnoCursoSeleccionado = filaSeleccionada.Cells[5].Value.ToString();
            string aulaCursoSeleccionado = filaSeleccionada.Cells[6].Value.ToString();
            string diaCursoSeleccionado = filaSeleccionada.Cells[7].Value.ToString();

            CursoSeleccionado = new Curso(nombreCursoSeleccionado, codigoCursoSelecionado, descripcionCursoSelecionado, int.Parse(cupoMaxCursoSelecionado), turnoCursoSeleccionado, aulaCursoSeleccionado, diaCursoSeleccionado);
            CursoSeleccionado.CupoDisponible = int.Parse(cupoDisponibleSeleccionado);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelEstCursos formPanelEstCursos = new FormPanelEstCursos();
            formPanelEstCursos.Show();
        }

        private void FormInscripcionCurso_Load(object sender, EventArgs e)
        {
            cursosDGV.Rows[0].Selected = true;
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
