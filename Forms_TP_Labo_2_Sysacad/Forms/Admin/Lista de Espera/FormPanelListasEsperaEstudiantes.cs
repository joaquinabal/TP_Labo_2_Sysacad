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
    public partial class FormPanelListasEsperaEstudiantes : FormPadre
    {
        private List<Estudiante> _listaEstudiantes = new List<Estudiante>();
        private Curso _cursoSeleccionado;
        private Estudiante _estudianteSeleccionado;
        private BindingSource miBindingSource = new BindingSource();
        private Dictionary<string, DateTime> _listaEsperaCurso;
        private Dictionary<Curso, Dictionary<string, DateTime>> dictCursosLista;
        private bool _flagEstudianteSeleccionado = false;
        private GestorReportes gestorReportes = new GestorReportes();
        private GestorCursos gestorCursos = new GestorCursos();
        private GestorEstudiantes gestorEstudiantes = new GestorEstudiantes();

        public FormPanelListasEsperaEstudiantes(Curso curso)
        {
            InitializeComponent();
            CursoSeleccionado = curso;
            ListaEsperaCurso = DevolverListaEsperaSegunCurso(curso);
            ListaEstudiantes = DevolverListaEstudiantesSegunListaEspera(ListaEsperaCurso);
            CrearColumnas();
            AgregarEstudiantesEnDGV();
            OrdenarDGVSegunFechaInscripcionAscendente();
        }

        /// <summary>
        /// Crea y agrega columnas al DataGridView de estudiantes.
        /// </summary>
        private void CrearColumnas()
        {
            estudiantesDGV.Columns.Add("Nombre", "Nombre");
            estudiantesDGV.Columns.Add("Legajo", "Legajo");
            estudiantesDGV.Columns.Add("Correo", "Correo");
            estudiantesDGV.Columns.Add("FechaInscripcion", "Fecha de Inscripción");
        }

        /// <summary>
        /// Agrega estudiantes al DataGridView según la lista de espera del curso.
        /// </summary>
        private void AgregarEstudiantesEnDGV()
        {
            if (ListaEstudiantes.Count > 0)
            {
                for (int i = 0; i < ListaEstudiantes.Count; i++)
                {
                    foreach (string legajo in ListaEsperaCurso.Keys)
                    {
                        if (legajo == ListaEstudiantes[i].Legajo)
                        {
                            estudiantesDGV.Rows.Add(new object[] { ListaEstudiantes[i].Nombre, ListaEstudiantes[i].Legajo, ListaEstudiantes[i].Correo, ListaEsperaCurso[legajo]/*.ToString("dd/MM/yyyy HH:mm:ss")*/ });
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Ordena el DataGridView de estudiantes según la columna 'Fecha de Inscripción' en orden ascendente.
        /// </summary>
        private void OrdenarDGVSegunFechaInscripcionAscendente()
        {
            estudiantesDGV.Sort(estudiantesDGV.Columns["FechaInscripcion"], ListSortDirection.Ascending);
        }
        /// <summary>
        /// Devuelve la lista de espera para un curso específico.
        /// </summary>
        /// <param name="curso">El curso para el que se busca la lista de espera.</param>
        /// <returns>Un diccionario que contiene información de la lista de espera para el curso.</returns>
        private Dictionary<string, DateTime> DevolverListaEsperaSegunCurso(Curso curso)
        {
            Dictionary<string, DateTime> listaCurso = new Dictionary<string, DateTime>();
            Dictionary<Curso, Dictionary<string, DateTime>> dictCursosLista = gestorReportes.ObtenerCursosConListaDeEsperaSegunFechas(DateTime.MinValue, DateTime.MaxValue);
            foreach (Curso cursoLista in dictCursosLista.Keys)
            {
                if (cursoLista.Codigo == curso.Codigo)
                {
                    listaCurso = dictCursosLista[cursoLista];
                    break;
                }
            }
            return listaCurso;
        }

        /// <summary>
        /// Devuelve una lista de estudiantes según la lista de espera proporcionada.
        /// </summary>
        /// <param name="dictListaEspera">Diccionario que contiene información de la lista de espera.</param>
        /// <returns>Una lista de estudiantes presentes en la lista de espera.</returns>
        private List<Estudiante> DevolverListaEstudiantesSegunListaEspera(Dictionary<string, DateTime> dictListaEspera)
        {
            List<Estudiante> ListaEstudiantesEnListaEspera = new List<Estudiante>();

            foreach (string legajo in dictListaEspera.Keys)
            {
                Estudiante estudiante = gestorEstudiantes.ObtenerEstudianteSegunLegajo(legajo);
                ListaEstudiantesEnListaEspera.Add(estudiante);
            }
            return ListaEstudiantesEnListaEspera;
        }



        private void agregarEstBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAgregarEstudianteAListaDeEspera FormAgregarEstudianteAListaDeEspera = new FormAgregarEstudianteAListaDeEspera(CursoSeleccionado);
            FormAgregarEstudianteAListaDeEspera.Show();
        }

        private async void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (FlagEstudianteSeleccionado)
            {
                ListaEsperaCurso.Remove(EstudianteSeleccionado.Legajo);
                await gestorCursos.ActualizarListaDeEsperaDeCurso(CursoSeleccionado, ListaEsperaCurso);

                MessageBox.Show("Estudiante eliminado correctamente.");

                this.Close();
                FormPanelListasEsperaEstudiantes FormPanelListasEsperaEstudiantes = new FormPanelListasEsperaEstudiantes(CursoSeleccionado);
                FormPanelListasEsperaEstudiantes.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un estudiante.");
            }
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelListasEspera FormPanelListasEspera = new FormPanelListasEspera();
            FormPanelListasEspera.Show();
        }

        private void estudiantesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FlagEstudianteSeleccionado = true;
            DataGridViewRow filaSeleccionada = estudiantesDGV.CurrentRow;

            string legajoEstudianteSelecionado = filaSeleccionada.Cells[1].Value.ToString();

            EstudianteSeleccionado = gestorEstudiantes.ObtenerEstudianteSegunLegajo(legajoEstudianteSelecionado);

        }

        public List<Estudiante> ListaEstudiantes
        {
            get { return _listaEstudiantes; }
            set { _listaEstudiantes = value; }
        }

        public Estudiante EstudianteSeleccionado
        {
            get { return _estudianteSeleccionado; }
            set { _estudianteSeleccionado = value; }
        }

        public Dictionary<string, DateTime> ListaEsperaCurso
        {
            get { return _listaEsperaCurso; }
            set { _listaEsperaCurso = value; }
        }

        public bool FlagEstudianteSeleccionado
        {
            get { return _flagEstudianteSeleccionado; }
            set { _flagEstudianteSeleccionado = value; }
        }

        public Curso CursoSeleccionado
        {
            get { return _cursoSeleccionado; }
            set { _cursoSeleccionado = value; }
        }
    }
}
