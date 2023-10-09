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
    public partial class FormEliminarCurso : FormPadre
    {
        private string _nombre;
        private string _codigo;
        private string _descripcion;
        private string _cupo;
        private string _turno;
        private string _aula;
        private string _dia;

        public FormEliminarCurso(Curso curso)
        {
            InitializeComponent();

            nombreTextbox.Text = curso.Nombre;
            codigoTextbox.Text = curso.Codigo;
            descripcionTextbox.Text = curso.Descripcion;
            cupoMaxTextbox.Text = curso.CupoMaximo.ToString();
            turnoTextbox.Text = curso.Turno;
            aulaTextbox.Text = curso.Aula;
            diaTextbox.Text = curso.Dia;

            _nombre = curso.Nombre;
            _codigo = curso.Codigo;
            _descripcion = curso.Descripcion;
            _cupo = curso.CupoMaximo.ToString();
            _turno = curso.Turno;
            _aula = curso.Aula;
            _dia = curso.Dia;
        }

        private void nombreTextbox_TextChanged(object sender, EventArgs e)
        {
            _nombre = nombreTextbox.Text;
        }

        private void codigoTextbox_TextChanged(object sender, EventArgs e)
        {
            _codigo = codigoTextbox.Text;
        }

        private void cupoMaxTextbox_TextChanged(object sender, EventArgs e)
        {
            _cupo = cupoMaxTextbox.Text;
        }

        private void turnoTextbox_TextChanged(object sender, EventArgs e)
        {
            _turno = turnoTextbox.Text;
        }

        private void aulaTextbox_TextChanged(object sender, EventArgs e)
        {
            _aula = aulaTextbox.Text;
        }

        private void diaTextbox_TextChanged(object sender, EventArgs e)
        {
            _dia = diaTextbox.Text;
        }

        private void descripcionTextbox_TextChanged(object sender, EventArgs e)
        {
            _descripcion = descripcionTextbox.Text;
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            Sistema.BaseDatosCursos.EliminarCursoBD(_codigo);
            MessageBox.Show("Curso eliminado exitosmente.");
            this.Close();
            FormPanelAdmCursos formPanelAdmCursos = new FormPanelAdmCursos();
            formPanelAdmCursos.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelAdmCursos formPanelAdmCursos = new FormPanelAdmCursos();
            formPanelAdmCursos.ShowDialog();
        }
    }
}
