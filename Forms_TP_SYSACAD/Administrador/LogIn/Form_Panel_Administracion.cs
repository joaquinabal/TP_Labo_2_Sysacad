using Forms_TP_SYSACAD.Administrador.Profesores;
using Libreria_Clases_TP_SYSACAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TP_SYSACAD
{
    public partial class Form_Panel_Administracion : Form
    {
        public Form_Panel_Administracion()
        {
            InitializeComponent();
            lblInformacionPanel.Text = "TAREAS:";
            lblOpcionEstudiante.Text = "Estudiantes";
            lblSeccionCursos.Text = "Cursos";
            lblReporte.Text = "Reportes";
            lblRequisitos.Text = "Requisitos";
            lblListasEspera.Text = "Listas de espera";
            lblProfesores.Text = "Profesores";

            btnRegistroEstudiante.Text = "Registrar Alumno";
            btnGestionCursos.Text = "Gestionar Cursos";
            btnReportes.Text = "Generar Reportes";
            btnRequisitos.Text = "Gestionar Requisitos Academicos";
            btnListasEspera.Text = "Manejar Listas de Espera";
            btnProfesores.Text = "Gestionar Profesores";
            btnAtras.Text = "Atras";
        }

        private void Form_Panel_Administracion_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Panel de Administracion";
        }

        private void btnRegistroEstudiante_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Registro_Estudiantes formRegistroEstudiante = new Form_Registro_Estudiantes();
            formRegistroEstudiante.Show();
        }

        private void btnGestionCursos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Cursos_Disponibles nuevoFormCursosDisponibles = new Form_Cursos_Disponibles();
            nuevoFormCursosDisponibles.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_LogIn_Administrador nuevoFormLogIn = new Form_LogIn_Administrador();
            nuevoFormLogIn.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Reportes_Principal nuevoReportesPrincipal = new Form_Reportes_Principal();
            nuevoReportesPrincipal.Show();
        }

        private void btnRequisitos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Gestion_Requisitos formGestionRequisitos = new Form_Gestion_Requisitos();
            formGestionRequisitos.Show();
        }

        private void btnListasEspera_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Gestion_Listas_Espera formGestionListasEspera = new Form_Gestion_Listas_Espera();
            formGestionListasEspera.Show();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Profesores_Principal formProfesoresPrincipal = new Form_Profesores_Principal();
            formProfesoresPrincipal.Show();
        }
    }
}
