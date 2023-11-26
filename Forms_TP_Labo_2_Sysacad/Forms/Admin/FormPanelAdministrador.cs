using Forms_TP_Labo_2_Sysacad.Forms.Admin;
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
    public partial class FormPanelAdministrador : FormPadre
    {
        public FormPanelAdministrador()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void registrarEstBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegEst formRegEst = new FormRegEst();
            formRegEst.Show();
        }

        private void gestionarCursosBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPanelAdmCursos formPanelAdmCursos = new FormPanelAdmCursos();
            formPanelAdmCursos.Show();
        }

        private void gestProfBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPanelAdmProf formPanelAdmProf = new FormPanelAdmProf();
            formPanelAdmProf.Show();
        }

        private void reqAcademicosBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPanelReqAcademicos FormPanelReqAcademicos = new FormPanelReqAcademicos();
            FormPanelReqAcademicos.Show();
        }

        private void reporteBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPanelReportes FormPanelReportes = new FormPanelReportes();
            FormPanelReportes.Show();
        }

        private void listasEsperaBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPanelListasEspera FormPanelListasEspera = new FormPanelListasEspera();
            FormPanelListasEspera.Show();
        }
    }
}
