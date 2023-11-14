using Libreria_Clases_TP_SYSACAD;
using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TP_SYSACAD
{
    public partial class Form_Horarios_Cursos : Form
    {
        public Form_Horarios_Cursos()
        {
            InitializeComponent();

            btnAtras.Text = "Atras";

            MostrarHorariosListView(Sistema.EstudianteLogueado);
        }

        private void Form_Horarios_Cursos_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Text = "Consultar Horarios";
        }

        /// <summary>
        /// Muestra la información de horarios de los cursos en los que está inscrito un estudiante
        /// en un control ListView.
        /// </summary>
        /// <param name="estudianteLogeado">El estudiante cuyos horarios se mostrarán.</param>
        private void MostrarHorariosListView(Estudiante estudianteLogeado)
        {
            listViewHorarios.Items.Clear();

            // Obtengo la lista de cursos del estudiante
            List<Curso> listaCursosAlumno = ConsultasCursos.ObtenerListaCursosDesdeListaCodigos(estudianteLogeado.CursosInscriptos);

            foreach (Curso curso in listaCursosAlumno)
            {
                ListViewItem nuevaFila = new ListViewItem(curso.Nombre);
                nuevaFila.SubItems.Add(curso.DevolverHorario());
                nuevaFila.SubItems.Add(curso.Dia);
                nuevaFila.SubItems.Add(curso.Aula);

                listViewHorarios.Items.Add(nuevaFila);
            }
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form_Panel_Estudiante formPanelEstudiante = new Form_Panel_Estudiante();
            formPanelEstudiante.Show();
        }
    }
}
