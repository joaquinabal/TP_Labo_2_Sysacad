using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Gestores;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using System.ComponentModel;

namespace Forms_TP_Labo_2_Sysacad
{
    public partial class FormInscripcionCurso : FormPadre
    {
        private List<Curso> _listaCursos = ConsultasCursos.Cursos;
        private Curso? _cursoSeleccionado;
        private BindingSource miBindingSource = new BindingSource();
        private bool hayCursoSeleccionado = false;
        private GestorCursos gestorCursos = new GestorCursos();

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


        private async void inscribirseBtn_Click(object sender, EventArgs e)
        {
            if (hayCursoSeleccionado)
            {
                ValidadorDeInscripciones validadorCursos = new ValidadorDeInscripciones();
                List<Curso> listaCursoSeleccionado = new List<Curso> { CursoSeleccionado };

                List<Curso> listaCursosEstudianteLogueado = gestorCursos.ObtenerListaCursosDesdeListaCodigos(Sistema.EstudianteLogueado.CursosInscriptos);
                if (listaCursosEstudianteLogueado.Any(curso => curso == CursoSeleccionado))
                {

                    MessageBox.Show("El alumno ya se encuentra inscripto en este curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    ValidacionInscripcionResultado resultadoValidacion = await validadorCursos.ValidarCursosSegunCupo(listaCursoSeleccionado);
                    switch (resultadoValidacion)
                    {
                        case ValidacionInscripcionResultado.SinSeleccion:
                            MessageBox.Show("Selecciona un curso nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        case ValidacionInscripcionResultado.NoCumpleNingunRequisito:
                            MessageBox.Show("No cumples los requisitos para inscribirte a este curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        case ValidacionInscripcionResultado.SinCupoAbsoluto:
                            MessageBox.Show("En este curso no hay cupos disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;

                        case ValidacionInscripcionResultado.Exitoso:
                            MessageBox.Show("Alumno inscripto correctamente.");
                            Sistema.IngresarEstudianteComoUsuarioActivo(Sistema.EstudianteLogueado.Correo);
                            this.Hide();
                            FormPanelEstCursos formPanelEstCursos = new FormPanelEstCursos();
                            formPanelEstCursos.ShowDialog();
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void cursosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hayCursoSeleccionado = true;
            DataGridViewRow filaSeleccionada = cursosDGV.CurrentRow;

            string? codigoCursoSelecionado = filaSeleccionada.Cells[1].Value.ToString();

            CursoSeleccionado = gestorCursos.ObtenerCursoDesdeCodigo(codigoCursoSelecionado);
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
