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

namespace Forms_TP_Labo_2_Sysacad
{
    public partial class FormLoginEst : FormPadre
    {
        private string _mailLogInEst;
        private string _passwordLogInEst;

        public string Mail
        {
            get { return _mailLogInEst; }
            set { _mailLogInEst = value; }
        }

        public string Password
        {
            get { return _passwordLogInEst; }
            set { _passwordLogInEst = value; }
        }

        public FormLoginEst()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void mailTxtbox_TextChanged(object sender, EventArgs e)
        {
            _mailLogInEst = mailTxtbox.Text;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            ValidadorCredenciales validadorCredenciales = new ValidadorCredenciales();

            string resultadoValidacion = validadorCredenciales.ValidarCredenciales(Mail, Password, Log.Estudiante);

            if (resultadoValidacion == "OK")
            {
                if (Sistema.BaseDatosEstudiantes.BuscarSiUsuarioDebeCambiarContrasenia(Mail))
                {
                    this.Close();
                    FormContraseñaProv formContraseñaProv = new FormContraseñaProv(Mail);
                    formContraseñaProv.Show();
                }

                Sistema.IngresarEstudianteComoUsuarioActivo(Mail);
                this.Hide();
                FormPanelEst formPanelEst = new FormPanelEst();
                formPanelEst.Show();
            }
            else if (resultadoValidacion == "CAMPOS VACIOS")
            {
                MessageBox.Show("Asegurese de completar los campos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (resultadoValidacion == "NO ENCONTRADO")
            {

                MessageBox.Show("Credenciales de inicio incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void autBtn_Click(object sender, EventArgs e)
        {
            mailTxtbox.Text = "aaaa@hotmail.com";
            passwordTextbox.Text = "123456";
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            _passwordLogInEst = passwordTextbox.Text;
        }
    }
}
