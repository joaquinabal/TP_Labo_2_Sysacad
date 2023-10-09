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
    public partial class FormContraseñaProv : FormPadre
    {
        private string _nuevaContraseña;
        private string _repContraseña;
        private string _mail;
        public FormContraseñaProv(string mail)
        {
            InitializeComponent();
            _mail = mail;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (RepContraseña == NuevaContraseña)
            {
                Sistema.BaseDatosEstudiantes.CambiarContraseñaAEstudiante(Mail, NuevaContraseña);
                Sistema.IngresarEstudianteComoUsuarioActivo(Mail);
                Sistema.EstudianteLogueado.DebeCambiarContrasenia = false;
                this.Close();
                FormPanelEst formPanelEst = new FormPanelEst();
                formPanelEst.ShowDialog();
            }
            else
            {
                MessageBox.Show("Las contraseñas no son iguales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void repContraseñaTextbox_TextChanged(object sender, EventArgs e)
        {
            RepContraseña = repContraseñaTextbox.Text;
        }

        private void contraseñaTxtbox_TextChanged_1(object sender, EventArgs e)
        {
            NuevaContraseña = contraseñaTxtbox.Text;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLoginEst formLoginEst = new FormLoginEst();
            formLoginEst.ShowDialog();
        }

        public string NuevaContraseña { get { return _nuevaContraseña; } set { _nuevaContraseña = value; } }

        public string RepContraseña { get { return _repContraseña; } set { _repContraseña = value; } }

        public string Mail { get { return _mail; } set { _mail = value; } }
    }
}
