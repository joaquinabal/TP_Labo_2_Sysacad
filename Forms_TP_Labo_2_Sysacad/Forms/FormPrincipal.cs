using Libreria_Clases_TP_SYSACAD;

namespace Forms_TP_Labo_2_Sysacad
{
    public partial class FormPrincipal : FormPadre
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void estBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoginEst formLoginEst = new FormLoginEst();
            formLoginEst.ShowDialog();
        }

        private void admBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoginAdm formLoginAdm = new FormLoginAdm();
            formLoginAdm.ShowDialog();
        }

    }
}