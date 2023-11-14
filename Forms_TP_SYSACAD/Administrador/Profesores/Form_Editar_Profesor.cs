using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
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

namespace Forms_TP_SYSACAD.Administrador.Profesores
{
    public partial class Form_Editar_Profesor : Form
    {
        private string _nombre;
        private string _correo;
        private string _direccion;
        private string _especializacion;
        private string _telefono;
        private string _correoOriginal;

        public Form_Editar_Profesor(Profesor profesorSeleccionado)
        {
            InitializeComponent();

            lblInfo.Text = "Edite los datos del profesore seleccionado";
            lblCorreo.Text = "Correo:";
            tbCorreo.Text = profesorSeleccionado.Correo;
            lblDireccion.Text = "Direccion:";
            tbDireccion.Text = profesorSeleccionado.Direccion;
            lblEspecializacion.Text = "Especializacion";
            tbEspecializacion.Text = profesorSeleccionado.Especializacion;
            lblNombre.Text = "Nombre:";
            tbNombre.Text = profesorSeleccionado.Nombre;
            lblTelefono.Text = "Telefono:";
            tbTelefono.Text = profesorSeleccionado.Telefono;

            btnAtras.Text = "Atras";
            btnGuardar.Text = "Confirmar";

            _correoOriginal = profesorSeleccionado.Correo;
        }

        private void Form_Editar_Profesor_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Editar Profesor";
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            _nombre = tbNombre.Text;
        }

        private void tbCorreo_TextChanged(object sender, EventArgs e)
        {
            _correo = tbCorreo.Text;
        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {
            _telefono = tbTelefono.Text;
        }

        private void tbDireccion_TextChanged(object sender, EventArgs e)
        {
            _direccion = tbDireccion.Text;
        }

        private void tbEspecializacion_TextChanged(object sender, EventArgs e)
        {
            _especializacion = tbEspecializacion.Text;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Profesores_Principal form_Profesores_Principal = new Form_Profesores_Principal();
            form_Profesores_Principal.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Creo un diccionario con los campos ingresados por el usuario
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
                {
                    { "nombre", _nombre },
                    { "correo", _correo },
                    { "direccion", _direccion },
                    { "especializacion", _especializacion },
                    { "telefono", _telefono }
                };

                // Crear una instancia de ValidadorInputCursos para validar los datos ingresados
                ValidadorInputGenerico validacionDelInput = new ValidadorInputGenerico();
                RespuestaValidacionInput resultadoInputs = validacionDelInput.ValidarDatos(camposIngresados, ModoValidacionInput.Profesores);

                if (!resultadoInputs.AusenciaCamposVacios)
                {
                    throw new Exception("Asegúrese de completar los campos solicitados");
                }

                if (resultadoInputs.ExistenciaErrores)
                {
                    throw new Exception(resultadoInputs.MensajeErrores);
                }

                //Corroboro si el codigo se cambio
                bool cambioDeCorreo;
                if (_correoOriginal != _correo)
                {
                    cambioDeCorreo = true;
                }
                else
                {
                    cambioDeCorreo = false;
                }

                // Si se cambio el correo compruebo si hay duplicados
                if (cambioDeCorreo)
                {
                    bool validacionDuplicados = ValidadorDuplicados.ValidarDuplicadosProfesores(_correo);

                    if (!validacionDuplicados)
                    {
                        ConsultasProfesores.EditarProfesor(_correo, _direccion, _especializacion, _nombre, _telefono, _correoOriginal);

                        // Cerrar el formulario actual y mostrar el formulario principal de profesores
                        this.Hide();
                        Form_Profesores_Principal form_Profesores_Principal = new Form_Profesores_Principal();
                        form_Profesores_Principal.Show();
                    }
                    else
                    {
                        throw new Exception("Error... Correo de profesor duplicado");
                    }
                }
                else
                {
                    ConsultasProfesores.EditarProfesor(_correo, _direccion, _especializacion, _nombre, _telefono, _correoOriginal);

                    // Cerrar el formulario actual y mostrar el formulario principal de profesores
                    this.Hide();
                    Form_Profesores_Principal form_Profesores_Principal = new Form_Profesores_Principal();
                    form_Profesores_Principal.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
