using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms_TP_SYSACAD.Administrador.Profesores
{
    public partial class Form_Agregar_Curso_A_Profesor : Form
    {
        private string _cursoSeleccionado;
        private Profesor _profesorSeleccionado;

        public Form_Agregar_Curso_A_Profesor(Profesor profesorSeleccionado)
        {
            InitializeComponent();

            lblInfo.Text = "Cursos Disponibles:";
            btnAgregar.Text = "Agregar";
            btnAtras.Text = "Atras";

            _profesorSeleccionado = profesorSeleccionado;

            MostrarCursosDisponibles();
        }

        private void Form_Agregar_Curso_A_Profesor_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Asignar Curso a Profesor";

            listViewCursosDisponibles.MultiSelect = false;
            listViewCursosDisponibles.FullRowSelect = true;
        }

        private void MostrarCursosDisponibles()
        {
            listViewCursosDisponibles.Items.Clear();

            // Itero a través de la lista de cursos disponibles y agrega cada curso a la listView
            if (ConsultasCursos.Cursos.Count > 0)
            {
                foreach (Curso curso in ConsultasCursos.Cursos)
                {
                    if (!_profesorSeleccionado.CodigosCursosDeProfesor.Contains(curso.Codigo))
                    {
                        ListViewItem nuevaFila = new ListViewItem(curso.Nombre);
                        nuevaFila.SubItems.Add(curso.Codigo);
                        nuevaFila.SubItems.Add(curso.Dia);
                        nuevaFila.SubItems.Add(curso.Turno);
                        nuevaFila.SubItems.Add(curso.Aula);
                        nuevaFila.SubItems.Add(curso.Carrera.ToString());

                        listViewCursosDisponibles.Items.Add(nuevaFila);
                    }
                }
            }
        }

        private void listViewCursosDisponibles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListViewItem cursoSeleccionadoEnListView = e.Item;
            string codigoCursoSeleccionado = cursoSeleccionadoEnListView.SubItems[1].Text;

            _cursoSeleccionado = codigoCursoSeleccionado;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Profesores_Principal form_Profesores_Principal = new Form_Profesores_Principal();
            form_Profesores_Principal.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_cursoSeleccionado is null)
            {
                MessageBox.Show("Debe seleccionar algun curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool resultadoValidacion = ValidadorAsignacionCursoAProfesor.ValidarAsignacionDeCursoAProfesor(_cursoSeleccionado, _profesorSeleccionado);

                if (resultadoValidacion)
                {
                    ConsultasProfesores.AgregarCursoAProfesor(_profesorSeleccionado.Correo, _cursoSeleccionado);
                    this.Hide();
                    Form_Profesores_Principal form_Profesores_Principal = new Form_Profesores_Principal();
                    form_Profesores_Principal.Show();
                }
                else
                {
                    MessageBox.Show("Conflicto de Horarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
