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
    public partial class Form_Registro_Estudiantes : Form
    {
        private string _nombre;
        private string _legajo;
        private string _direccion;
        private string _numeroTelefono;
        private string _correo;
        private string _contraseñaProvisional;
        private bool _cambioContraseña;

        public Form_Registro_Estudiantes()
        {
            InitializeComponent();
            lblInfoRegistro.Text = "Ingrese los datos del estudiante:";
            lblNombre.Text = "Nombre:";
            lblLegajo.Text = "Legajo";
            lblDireccion.Text = "Direccion";
            lblTelefono.Text = "Numero de telefono";
            lblCorreo.Text = "Direccion e-mail";
            lblContraseñaProv.Text = "Contraseña provisional";
            lblCambioContraseña.Text = "Cambio de contraseña";
            checkBoxCambioContraseña.Text = "Debe cambiar contraseña provisional";
            btnRegistrar.Text = "Registrar";

            lblInfoRegistro.Font = new Font("Arial", 15, FontStyle.Bold | FontStyle.Italic);
            lblNombre.Font = new Font("Arial", 15);
            lblLegajo.Font = new Font("Arial", 15);
            lblDireccion.Font = new Font("Arial", 15);
            lblDireccion.Font = new Font("Arial", 15);
            lblTelefono.Font = new Font("Arial", 15);
            lblCorreo.Font = new Font("Arial", 15);
            lblContraseñaProv.Font = new Font("Arial", 15);
            lblCambioContraseña.Font = new Font("Arial", 15);
            checkBoxCambioContraseña.Font = new Font("Arial", 15);
        }

        private void Form_Registro_Estudiantes_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Registro de Estudiantes";
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            _nombre = textBoxNombre.Text;
        }

        private void textBoxLegajo_TextChanged(object sender, EventArgs e)
        {
            _legajo = textBoxLegajo.Text;
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {
            _direccion = textBoxDireccion.Text;
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            _numeroTelefono = textBoxTelefono.Text;
        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {
            _correo = textBoxCorreo.Text;
        }

        private void textBoxContraseñaProv_TextChanged(object sender, EventArgs e)
        {
            _contraseñaProvisional = textBoxContraseñaProv.Text;
        }

        private void checkBoxCambioContraseña_CheckedChanged(object sender, EventArgs e)
        {
            _cambioContraseña = checkBoxCambioContraseña.Checked;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool resultadoValidacion = ValidadorIngresoUsuario.ValidarIngresoDatosEstudiante(_nombre, _legajo, _direccion,
                _numeroTelefono, _correo, _contraseñaProvisional);

            if (resultadoValidacion == true)
            {
                Estudiante nuevoEstudiante = new Estudiante(_nombre, _legajo, _direccion,
                _numeroTelefono, _correo, _contraseñaProvisional, _cambioContraseña);

                bool resultadoBusquedaUsuario = ValidadorIngresoUsuario.ComprobarSiEstudianteExiste(nuevoEstudiante.Correo, nuevoEstudiante.Legajo);

                if (resultadoBusquedaUsuario == true)
                {
                    MessageBox.Show("El estudiante ya se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    nuevoEstudiante.RegistrarEstudiante(nuevoEstudiante);
                    
                    MessageBox.Show("Usuario registrado exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();

                    bool resultadoEmisionCorreo = EmisorCorreoElectronico.EnviarCorreoElectronico(nuevoEstudiante);
                    if (resultadoEmisionCorreo == true)
                    {
                        MessageBox.Show("Se ha enviado las credenciales al correo del estudiante", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Error al enviar email con credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Form_Panel_Administracion formPanelAdministracion = new Form_Panel_Administracion();
                    formPanelAdministracion.Show();
                }
            }
            else
            {
                MessageBox.Show("Asegurese de completar los campos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
