using Libreria_Clases_TP_SYSACAD;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_Clases_TP_SYSACAD.Entidades_Secundarias;

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

        private async void confirmBtn_Click(object sender, EventArgs e)
        {
            GestorNuevaContrasenia gestorNuevaContrasenia = new GestorNuevaContrasenia();
            if (RepContraseña == NuevaContraseña)
            {
               await gestorNuevaContrasenia.GestionarCambioContrasenia(Mail, NuevaContraseña);
                Sistema.IngresarEstudianteComoUsuarioActivo(Mail);
                Sistema.EstudianteLogueado.DebeCambiarContrasenia = false;
                this.Close();
                FormPanelEst formPanelEst = new FormPanelEst();
                formPanelEst.Show();
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
            formLoginEst.Show();
        }

        public string NuevaContraseña { get { return _nuevaContraseña; } set { _nuevaContraseña = value; } }

        public string RepContraseña { get { return _repContraseña; } set { _repContraseña = value; } }

        public string Mail { get { return _mail; } set { _mail = value; } }
    }
}
