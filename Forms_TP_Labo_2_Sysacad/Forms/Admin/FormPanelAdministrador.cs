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
            formPrincipal.ShowDialog();
        }

        private void registrarEstBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegEst formRegEst = new FormRegEst();
            formRegEst.ShowDialog();
        }

        private void gestionarCursosBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPanelAdmCursos formPanelAdmCursos = new FormPanelAdmCursos();
            formPanelAdmCursos.ShowDialog();
        }
    }
}
