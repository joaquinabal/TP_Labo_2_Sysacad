using Libreria_Clases_TP_SYSACAD;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Validaciones;
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
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Gestores;

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

        private GestorEstudiantes gestorEstudiantes = new GestorEstudiantes();
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

            MensajeRespuestaValidacionCredencialesContraseña resultadoValidacion = validadorCredenciales.ValidarCredenciales(Mail, Password, Log.Estudiante);

            if (resultadoValidacion == MensajeRespuestaValidacionCredencialesContraseña.OK)
            {
                if (gestorEstudiantes.BuscarSiUsuarioDebeCambiarContrasenia(Mail))
                {
                    this.Close();
                    FormContraseñaProv formContraseñaProv = new FormContraseñaProv(Mail);
                    formContraseñaProv.Show();
                }
                else
                {
                Sistema.IngresarEstudianteComoUsuarioActivo(Mail);
                this.Hide();
                FormPanelEst formPanelEst = new FormPanelEst();
                formPanelEst.Show();
                }
            }
            else if (resultadoValidacion == MensajeRespuestaValidacionCredencialesContraseña.camposVacios)
            {
                MessageBox.Show("Asegurese de completar los campos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (resultadoValidacion == MensajeRespuestaValidacionCredencialesContraseña.noEncontrado)
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
