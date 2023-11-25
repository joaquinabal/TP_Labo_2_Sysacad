using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Secundarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
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
    public partial class FormAgregarEstudianteAListaDeEspera : FormPadre
    {

        private List<Estudiante> _listaEstudiantes;
        private Curso _cursoSeleccionado;
        private Estudiante _estudianteSeleccionado;
        private BindingSource miBindingSource = new BindingSource();
        private Dictionary<string, DateTime> _listaEsperaCurso;
        private bool _flagEstudianteSeleccionado = false;
        public FormAgregarEstudianteAListaDeEspera(Curso curso)
        {
            InitializeComponent();
            CursoSeleccionado = curso;
            // dictCursosLista  = ConsultasCursos.DevolverDiccionarioConRegistrosListaDeEsperaSegunFechas(DateTime.MinValue, DateTime.MaxValue);
            ListaEsperaCurso = DevolverListaEsperaSegunCurso(CursoSeleccionado);
            //ListaEsperaCurso = curso.ListaDeEspera;
            //ConsultasCursos.ActualizarListaDeEsperaDeCurso(CursoSeleccionado, ListaEsperaCurso);
            // ListaEsperaCurso = curso.ListaDeEspera;
            ListaEstudiantes = ConsultasEstudiantes.Estudiantes;

            ConfigurarBindingSource();
            MostrarEstudiantes();
        }

        private Dictionary<string, DateTime> DevolverListaEsperaSegunCurso(Curso curso)
        {
            GestorReportes gestorReportes = new GestorReportes();
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



        private void ConfigurarBindingSource()
        {
            BindingList<Estudiante> bindingListaEstudiantes = new BindingList<Estudiante>();
            // Aquí puedes agregar los cursos a la BindingList<Curso>

            // Asigna la BindingList<Curso> al BindingSource
            miBindingSource.DataSource = bindingListaEstudiantes;

            // Enlaza el DataGridView al BindingSource
            estudiantesDGV.DataSource = miBindingSource;
        }

        private void MostrarEstudiantes()
        {
            // Obtenemos el BindingSource que enlaza el DataGridView
            BindingSource bindingSource = (BindingSource)estudiantesDGV.DataSource;

            // Obtenemos la BindingList<Curso> desde el BindingSource
            BindingList<Estudiante> bindingListaEstudiantes = (BindingList<Estudiante>)bindingSource.List;

            foreach (Estudiante estudiante in ListaEstudiantes)
            {
                bindingListaEstudiantes.Add(estudiante);
            }
        }


        private void estudiantesDGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            FlagEstudianteSeleccionado = true;
            DataGridViewRow filaSeleccionada = estudiantesDGV.CurrentRow;

            string legajoEstudianteSelecionado = filaSeleccionada.Cells[1].Value.ToString();

            EstudianteSeleccionado = ConsultasEstudiantes.ObtenerEstudianteSegunLegajo(legajoEstudianteSelecionado);
        }

        private async void agregarEstBtn_Click(object sender, EventArgs e)
        {
            if (FlagEstudianteSeleccionado)
            {
                List<Curso> listaCursoSelecionado = new List<Curso>
                {
                    CursoSeleccionado
                };
                ValidadorAdicionDeAlumnoEnListaDeEspera validadorListaDeEspera = new ValidadorAdicionDeAlumnoEnListaDeEspera();
                ValidadorDeInscripciones validadorDeInscripciones = new ValidadorDeInscripciones();
                RespuestaValidacionInput validacionListaDeEspera = validadorListaDeEspera.ValidarAdicionAlumnoEnLista(EstudianteSeleccionado.Legajo, CursoSeleccionado);

                if (validacionListaDeEspera.ExistenciaEnListaDeEspera)
                {
                    MessageBox.Show("Este alumno ya se encuentra en la Lista de Espera de este Curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (validacionListaDeEspera.ExistenciaErrores)
                {
                    MessageBox.Show(validacionListaDeEspera.MensajeErrores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!validacionListaDeEspera.ExistenciaErrores)
                {
                    Sistema.IngresarEstudianteComoUsuarioActivo(EstudianteSeleccionado.Correo);
                    await validadorDeInscripciones.ValidarCursosSegunCupo(listaCursoSelecionado);
                    //ConsultasCursos.AgregarEstudianteAListaDeEspera(CursoSeleccionado.Codigo, EstudianteSeleccionado.Legajo);
                    ListaEsperaCurso = DevolverListaEsperaSegunCurso(CursoSeleccionado);
                    await ConsultasCursos.ActualizarListaDeEsperaDeCurso(CursoSeleccionado, ListaEsperaCurso);
                    Console.WriteLine(CursoSeleccionado.ListaDeEspera);
                    MessageBox.Show("Alumno ingresado a la lista de espera.");
                }

                this.Close();
                FormPanelListasEsperaEstudiantes FormPanelListasEsperaEstudiantes = new FormPanelListasEsperaEstudiantes(CursoSeleccionado);
                FormPanelListasEsperaEstudiantes.Show();
            }
            else
            {
                MessageBox.Show("Selecciona un estudiante.");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelListasEsperaEstudiantes FormPanelListasEsperaEstudiantes = new FormPanelListasEsperaEstudiantes(CursoSeleccionado);
            FormPanelListasEsperaEstudiantes.Show();
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

