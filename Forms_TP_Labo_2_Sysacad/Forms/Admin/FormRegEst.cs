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
    public partial class FormRegEst : FormPadre
    {
        private string _nombre = "";
        private string _legajo = "";
        private string _direccion = "";
        private string _numeroTelefono = "";
        private string _correo = "";
        private string _contraseñaProvisional = "";


        public FormRegEst()
        {
            InitializeComponent();
        }

        private void nombreTextbox_TextChanged(object sender, EventArgs e)
        {
            _nombre = nombreTextbox.Text;
        }

        private void legajoTextbox_TextChanged(object sender, EventArgs e)
        {
            _legajo = legajoTextbox.Text;
        }

        private void direccionTxtbox_TextChanged(object sender, EventArgs e)
        {
            _direccion = direccionTxtbox.Text;
        }

        private void telefonoTextbox_TextChanged(object sender, EventArgs e)
        {
            _numeroTelefono = telefonoTextbox.Text;
        }

        private void mailTxtbox_TextChanged(object sender, EventArgs e)
        {
            _correo = mailTxtbox.Text;
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            _contraseñaProvisional = passwordTextbox.Text;
        }

        private void registrarBtn_Click(object sender, EventArgs e)
        {

            ValidadorInputEstudiantes validadorInputEstudiantes = new ValidadorInputEstudiantes();

            Dictionary<string, string> dictCampos = new Dictionary<string, string>()
            {

                {"nombre", _nombre },
                {"legajo", _legajo },
                {"direccion", _direccion },
                {"telefono", _numeroTelefono },
                {"correo", _correo },
                {"contrasenia", _contraseñaProvisional }

            };

            bool resultadoValidacion = ValidadorDuplicados.ValidarDuplicados(legajo: _legajo, correo: _correo);

            RespuestaValidacionInput validacionEstudiante = validadorInputEstudiantes.ValidarDatosEstudiantes(dictCampos);
            if (!validacionEstudiante.AusenciaCamposVacios)
            {
                MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (validacionEstudiante.ExistenciaErrores)
            {
                MessageBox.Show(validacionEstudiante.MensajeErrores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!resultadoValidacion)
                {
                    Estudiante nuevoEstudiante = new Estudiante(_nombre, _legajo, _direccion, _numeroTelefono, _correo, _contraseñaProvisional, false);

                    if (provisionalCheckbox.Checked)
                    {
                        nuevoEstudiante.DebeCambiarContrasenia = true;
                    }

                    nuevoEstudiante.RegistrarEstudiante();
                    EmisorCorreoElectronico.EnviarCorreoElectronico(nuevoEstudiante, _contraseñaProvisional);

                    MessageBox.Show("Estudiante registrado exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.Close();
                    FormPanelAdministrador formPanelAdministrador = new FormPanelAdministrador();
                    formPanelAdministrador.Show();

                }
                else if (resultadoValidacion)
                {
                    MessageBox.Show("Ya existe un estudiante con esos datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPanelAdministrador formPanelAdministrador = new FormPanelAdministrador();
            formPanelAdministrador.ShowDialog();
        }
    }
}
