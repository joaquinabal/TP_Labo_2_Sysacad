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

namespace Forms_TP_SYSACAD
{
    public partial class Form_Registro : Form
    {
        private string _correoRegistro;
        private string _contraseñaRegistro;

        public string Correo
        {
            get
            {
                return _correoRegistro;
            }
            set
            {
                _correoRegistro = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return _contraseñaRegistro;
            }
            set
            {
                _contraseñaRegistro = value;
            }
        }

        public Form_Registro()
        {
            InitializeComponent();
            lblInformacionRegistro.Text = "Para poder registrarse, ingrese los siguientes datos:";
            lblEmailRegistro.Text = "Ingrese su direccion de email:";
            lblContraseñaRegistro.Text = "Ingrese su contraseña:";
            btnRegistroUsuario.Text = "Registrarse";

            lblInformacionRegistro.Font = new Font("Arial", 15, FontStyle.Bold | FontStyle.Italic);
            lblEmailRegistro.Font = new Font("Arial", 15);
            lblContraseñaRegistro.Font = new Font("Arial", 15);
        }

        private void Form_Registro_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Registro de Usuario";
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            Correo = textBoxEmail.Text;
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            Contraseña = textBoxContraseña.Text;
        }

        private void btnRegistroUsuario_Click(object sender, EventArgs e)
        {
            bool resultadoValidacion = ValidadorIngresoUsuario.ValidarCorreoYContraseña(_correoRegistro, _contraseñaRegistro);

            if (resultadoValidacion == true) 
            {
                Administrador nuevoAdministrador = new Administrador(_correoRegistro, _contraseñaRegistro);

                bool resultadoBusquedaUsuario = ValidadorIngresoUsuario.ComprobarSiUsuarioExiste(_correoRegistro, _contraseñaRegistro);

                if (resultadoBusquedaUsuario == true)
                {
                    MessageBox.Show("Usuario registrado exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    Form_LogIn formLogIn = new Form_LogIn();
                    formLogIn.Show();
                }
                else
                {
                    MessageBox.Show("No se ha guardado el usuario en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Asegurese de completar los campos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
