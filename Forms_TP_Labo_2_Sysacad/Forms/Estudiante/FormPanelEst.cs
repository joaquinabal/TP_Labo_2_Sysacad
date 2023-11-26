using Libreria_Clases_TP_SYSACAD;
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

namespace Forms_TP_Labo_2_Sysacad
{
    public partial class FormPanelEst : FormPadre
    {
        public FormPanelEst()
        {
            InitializeComponent();
        }

        private void FormPanelEst_Load(object sender, EventArgs e)
        {
            bnvLbl.Text = $"Bienvenido, {Sistema.EstudianteLogueado.Nombre}";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void gestionarCursosBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPanelEstCursos formPanelEstCursos = new FormPanelEstCursos();
            formPanelEstCursos.Show();
        }

        private void consultarHorariosBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsultarHorario formConsultarHorario = new FormConsultarHorario();
            formConsultarHorario.Show();
        }

        private void RealizarPagosBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGestionarPagos formGestionarPagos = new FormGestionarPagos();
            formGestionarPagos.Show();
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }
    }
}
