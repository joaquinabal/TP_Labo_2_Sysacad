using Libreria_Clases_TP_SYSACAD.Validaciones;
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
    public partial class Form_Inicio : Form
    {
        public Form_Inicio()
        {
            InitializeComponent();

            lblInfoInicio.Text = "Bienvenido a SYSACAD";
            btnEstudiante.Text = "Ingresar como Estudiante";
            btnAdmin.Text = "Ingresar como Administrador";
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_LogIn_Estudiante formLogInEstudiante = new Form_LogIn_Estudiante();
            formLogInEstudiante.Show();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "btnAdmin" para que un administrador inicie sesión.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Muestra un cuadro de diálogo de entrada de contraseña
            string codigoIngresado = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la contraseña:", "Verificar Contraseña", "");

            //Valido la contraseña ingresada
            ValidadorCredenciales validadorCodigoAcceso = new ValidadorCredenciales();
            bool resultadoValidacion = validadorCodigoAcceso.ValidarCodigoAccesoAdmins(codigoIngresado);

            if (resultadoValidacion)
            {
                this.Hide();
                Form_LogIn_Administrador formLogInAdmin = new Form_LogIn_Administrador();
                formLogInAdmin.Show();
            }
            else
            {
                MessageBox.Show("Acceso Denegado", "Codigo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_Inicio_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Bienvenido";
        }
    }
}
