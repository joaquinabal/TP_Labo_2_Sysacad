using Libreria_Clases_TP_SYSACAD.Herramientas;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
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
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;

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
            btnAtras.Text = "Atras";

            textBoxNombre.PlaceholderText = "Esteban Sanchez";
            textBoxLegajo.PlaceholderText = "Num 8 cifras";
            textBoxDireccion.PlaceholderText = "Av. 25 de Mayo";
            textBoxTelefono.PlaceholderText = "1135156482";
            textBoxCorreo.PlaceholderText = "pepe@hotmail.com";
            textBoxContraseñaProv.PlaceholderText = "Al menos 6 caracteres";
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

        /// <summary>
        /// Maneja el evento de hacer clic en el botón "Registrar" para registrar a un nuevo estudiante.
        /// </summary>
        //private void btnRegistrar_Click(object sender, EventArgs e)
        //{
        //    // Creo un diccionario con los campos ingresados
        //    Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
        //    {
        //        { "nombre", _nombre},
        //        { "legajo", _legajo },
        //        { "direccion", _direccion},
        //        { "telefono", _numeroTelefono},
        //        { "correo", _correo},
        //        { "contrasenia", _contraseñaProvisional }
        //    };

        //    // Valido los campos ingresados
        //    ValidadorInputEstudiantes validacionDelInput = new ValidadorInputEstudiantes();
        //    RespuestaValidacionInput resultadoInputs = validacionDelInput.ValidarDatosEstudiantes(camposIngresados);

        //    // Si hay campos vacios
        //    if (!resultadoInputs.AusenciaCamposVacios)
        //    {
        //        MessageBox.Show("Asegurese de completar los campos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        // Si hay errores de input
        //        if (resultadoInputs.ExistenciaErrores)
        //        {
        //            MessageBox.Show(resultadoInputs.MensajeErrores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        else
        //        {
        //            // Valido si hay duplicados
        //            bool validacionDuplicados = ValidadorDuplicados.ValidarDuplicados(_legajo, _correo);

        //            if (!validacionDuplicados)
        //            {
        //                //Creo y registro al estudiante
        //                Estudiante nuevoEstudiante = new Estudiante(_nombre, _legajo, _direccion,
        //                _numeroTelefono, _correo, _contraseñaProvisional, _cambioContraseña);
        //                nuevoEstudiante.RegistrarEstudiante();

        //                MessageBox.Show("Usuario registrado exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        //                Form_Espera formEspera = new Form_Espera();
        //                formEspera.ShowDialog();

        //                //Enviar mail
        //                bool resultadoEmisionCorreo = EmisorCorreoElectronico.EnviarCorreoElectronico(nuevoEstudiante, _contraseñaProvisional);
        //                if (resultadoEmisionCorreo == true)
        //                {
        //                    formEspera.Hide();
        //                    MessageBox.Show("Se ha enviado las credenciales al correo del estudiante", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //                }
        //                else
        //                {
        //                    formEspera.Hide();
        //                    MessageBox.Show("Error al enviar email con credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }

        //                //Cerrar form
        //                this.Hide();
        //                Form_Panel_Administracion formPanelAdministracion = new Form_Panel_Administracion();
        //                formPanelAdministracion.Show();
        //            }
        //            else
        //            {
        //                MessageBox.Show("El estudiante ya se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //}

        //REGISTRAR QUE ANDA BIEN
        //private void btnRegistrar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
        //        {
        //            { "nombre", _nombre},
        //            { "legajo", _legajo },
        //            { "direccion", _direccion},
        //            { "telefono", _numeroTelefono},
        //            { "correo", _correo},
        //            { "contrasenia", _contraseñaProvisional }
        //        };

        //        //ValidadorInputEstudiantes validacionDelInput = new ValidadorInputEstudiantes();
        //        //RespuestaValidacionInput resultadoInputs = validacionDelInput.ValidarDatosEstudiantes(camposIngresados);

        //        ValidadorInputGenerico validacionDelInput = new ValidadorInputGenerico();
        //        RespuestaValidacionInput resultadoInputs = validacionDelInput.ValidarDatos(camposIngresados, ModoValidacionInput.Estudiantes);

        //        if (!resultadoInputs.AusenciaCamposVacios)
        //        {
        //            throw new Exception("Asegúrese de completar los campos solicitados");
        //        }

        //        if (resultadoInputs.ExistenciaErrores)
        //        {
        //            throw new Exception(resultadoInputs.MensajeErrores);
        //        }

        //        bool validacionDuplicados = ValidadorDuplicados.ValidarDuplicadosEstudiantes(_legajo, _correo);

        //        if (!validacionDuplicados)
        //        {
        //            Estudiante nuevoEstudiante = new Estudiante(_nombre, _legajo, _direccion, _numeroTelefono, _correo, _contraseñaProvisional, _cambioContraseña);
        //            nuevoEstudiante.RegistrarEstudiante();

        //            MessageBox.Show("Usuario registrado exitosamente. A continuacion, se enviarán las credenciales al correo del estudiante. Este proceso puede llevar unos segundos", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        //            bool resultadoEmisionCorreo = EmisorCorreoElectronico.EnviarCorreoElectronico(nuevoEstudiante, _contraseñaProvisional);

        //            if (resultadoEmisionCorreo)
        //            {
        //                MessageBox.Show("Se ha enviado las credenciales al correo del estudiante", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Error al enviar email con credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }

        //            this.Hide();
        //            Form_Panel_Administracion formPanelAdministracion = new Form_Panel_Administracion();
        //            formPanelAdministracion.Show();
        //        }
        //        else
        //        {
        //            throw new Exception("El estudiante ya se encuentra registrado en el sistema");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
                {
                    { "nombre", _nombre},
                    { "legajo", _legajo },
                    { "direccion", _direccion},
                    { "telefono", _numeroTelefono},
                    { "correo", _correo},
                    { "contrasenia", _contraseñaProvisional }
                };

                ValidadorInputGenerico validacionDelInput = new ValidadorInputGenerico();
                RespuestaValidacionInput resultadoInputs = validacionDelInput.ValidarDatos(camposIngresados, ModoValidacionInput.Estudiantes);

                if (!resultadoInputs.AusenciaCamposVacios)
                {
                    throw new Exception("Asegúrese de completar los campos solicitados");
                }

                if (resultadoInputs.ExistenciaErrores)
                {
                    throw new Exception(resultadoInputs.MensajeErrores);
                }

                bool validacionDuplicados = ValidadorDuplicados.ValidarDuplicadosEstudiantes(_legajo, _correo);

                if (!validacionDuplicados)
                {
                    Estudiante nuevoEstudiante = new Estudiante(_nombre, _legajo, _direccion, _numeroTelefono, _correo, _contraseñaProvisional, _cambioContraseña);
                    nuevoEstudiante.RegistrarEstudiante();

                    MessageBox.Show("Usuario registrado exitosamente. A continuacion, se enviarán las credenciales al correo del estudiante. Este proceso puede llevar unos segundos", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    bool resultadoEmisionCorreo = await EmisorCorreoElectronico.EnviarCorreoElectronicoCredenciales(nuevoEstudiante, _contraseñaProvisional);

                    if (resultadoEmisionCorreo)
                    {
                        MessageBox.Show("Se ha enviado las credenciales al correo del estudiante", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Error al enviar email con credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //this.Hide();
                    //Form_Panel_Administracion formPanelAdministracion = new Form_Panel_Administracion();
                    //formPanelAdministracion.Show();
                }
                else
                {
                    throw new Exception("El estudiante ya se encuentra registrado en el sistema");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Panel_Administracion formPanelAdministrador = new Form_Panel_Administracion();
            formPanelAdministrador.Show();
        }
    }
}
