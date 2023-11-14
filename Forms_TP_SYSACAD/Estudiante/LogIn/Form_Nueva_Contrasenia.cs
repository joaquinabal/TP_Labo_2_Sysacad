using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
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
    public partial class Form_Nueva_Contrasenia : Form
    {
        private string _correo;
        private string _nuevaContraseña;

        public Form_Nueva_Contrasenia(string correo)
        {
            InitializeComponent();

            lblInfo.Text = "Ingrese su nueva contraseña";
            tbContra.PlaceholderText = "Al menos 6 caracteres";
            btnCambiar.Text = "Cambiar Contraseña";

            _correo = correo;
        }

        private void Form_Nueva_Contrasenia_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Debe cambiar su contraseña";
        }

        private void tbContra_TextChanged(object sender, EventArgs e)
        {
            _nuevaContraseña = tbContra.Text;
        }

        /// <summary>
        /// Maneja el evento de hacer clic en el botón "Cambiar" para cambiar la contraseña del estudiante.
        /// </summary>
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            // Valido contraseñas
            ValidadorInputNuevaContrasenia validadorInputContraseña = new ValidadorInputNuevaContrasenia();
            MensajeRespuestaValidacionCredencialesContraseña resultadoValidacion = validadorInputContraseña.ValidarNuevaContrasenia(_nuevaContraseña);

            if (resultadoValidacion == MensajeRespuestaValidacionCredencialesContraseña.camposVacios)
            {
                MessageBox.Show("Asegurese de completar el campo solicitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (resultadoValidacion == MensajeRespuestaValidacionCredencialesContraseña.OK)
            {
                //Sistema.BaseDatosEstudiantes.CambiarContraseñaAEstudiante(_correo, _nuevaContraseña);
                ConsultasEstudiantes.CambiarContraseñaAEstudiante(_correo, _nuevaContraseña);

                this.Close();
            }
            else
            {
                MessageBox.Show("Ha ingresado una contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
