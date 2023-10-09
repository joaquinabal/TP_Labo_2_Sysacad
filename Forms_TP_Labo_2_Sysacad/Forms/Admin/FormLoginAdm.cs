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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms_TP_Labo_2_Sysacad
{
    public partial class FormLoginAdm : FormPadre
    {
        private string _mailLogInAdm;
        private string _passwordLogInAdm;

        public string Mail
        {
            get { return _mailLogInAdm; }
            set { _mailLogInAdm = value; }
        }

        public string Password
        {
            get { return _passwordLogInAdm; }
            set { _passwordLogInAdm = value; }
        }

        public FormLoginAdm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.ShowDialog();
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.ShowDialog();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            ValidadorCredenciales validadorCredenciales = new ValidadorCredenciales();

            string resultadoValidacion = validadorCredenciales.ValidarCredenciales(Mail, Password, Log.Admin);
            Console.WriteLine(resultadoValidacion);

            if (resultadoValidacion == "OK")
            {

                this.Hide();

                FormPanelAdministrador formPanelAdm = new FormPanelAdministrador();
                formPanelAdm.ShowDialog();
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

        private void mailTxtbox_TextChanged(object sender, EventArgs e)
        {
            _mailLogInAdm = mailTxtbox.Text;
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            _passwordLogInAdm = passwordTextbox.Text;
        }

        private void autBtn_Click(object sender, EventArgs e)
        {
            mailTxtbox.Text = "johntravolta@hotmail.com";
            passwordTextbox.Text = "666666";
        }
    }
}
