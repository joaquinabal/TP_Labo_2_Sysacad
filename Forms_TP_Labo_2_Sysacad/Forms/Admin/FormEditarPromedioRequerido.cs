using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
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
    public partial class FormEditarPromedioRequerido : FormPadre
    {

        private string _nombre;
        private string _codigo;
        private string _descripcion;
        private string _cupo;
        private string _turno;
        private string _aula;
        private string _dia;
        private string _promedio;
        private Curso _cursoSeleccionado;
        public FormEditarPromedioRequerido(Curso curso)
        {
            InitializeComponent();
            _cursoSeleccionado = curso;
            nombreTextbox.Text = curso.Nombre;
            codigoTextbox.Text = curso.Codigo;
            descripcionTextbox.Text = curso.Descripcion;
            cupoMaxTextbox.Text = curso.CupoMaximo.ToString();
            turnoTextbox.Text = curso.Turno;
            aulaTextbox.Text = curso.Aula;
            diaTextbox.Text = curso.Dia;
            promRequeridoTextBox.Text = curso.PromedioRequerido.ToString();

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



        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelAdmCursos formPanelAdmCursos = new FormPanelAdmCursos();
            formPanelAdmCursos.Show();
        }

        private void promRequeridoTextBox_TextChanged(object sender, EventArgs e)
        {
            _promedio = promRequeridoTextBox.Text;
        }

        private async void editarBtn_Click(object sender, EventArgs e)
        {

            GestorRequisitos gestorRequisitos = new GestorRequisitos();

            Dictionary<string, string> dictCampos = new Dictionary<string, string>()
            {
                { "promedio", _promedio },
                { "creditos", _cursoSeleccionado.CreditosRequeridos.ToString() }
            };

            RespuestaValidacionInput respuestaValidacion = await gestorRequisitos.GestionarConfirmacionRequisitos(dictCampos, _cursoSeleccionado.CodigoFamilia, _cursoSeleccionado.Correlatividades, _cursoSeleccionado.CreditosRequeridos, Double.Parse(_promedio));

            if (respuestaValidacion.ExistenciaErrores)
            {
                MessageBox.Show(respuestaValidacion.MensajeErrores);
            }
            else
            {  
                MessageBox.Show("Promedio editado correctamente.");
                this.Close();
                FormPanelReqAcademicos FormPanelReqAcademicos = new FormPanelReqAcademicos();
                FormPanelReqAcademicos.Show();
            }

        }
    }
}
