using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
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
    public partial class Form_Agregar_Profesor : Form
    {
        private string _nombre;
        private string _correo;
        private string _direccion;
        private string _especializacion;
        private string _telefono;

        public Form_Agregar_Profesor()
        {
            InitializeComponent();

            lblInfo.Text = "Ingrese los datos del nuevo profesor";
            lblCorreo.Text = "Correo:";
            tbCorreo.PlaceholderText = "Por ej: david_vincent@gmail.com";
            lblDireccion.Text = "Direccion:";
            tbDireccion.PlaceholderText = "Por ej: Av Santa Fe 1245";
            lblEspecializacion.Text = "Especializacion";
            tbEspecializacion.PlaceholderText = "Por ej: Matematica Discreta";
            lblNombre.Text = "Nombre:";
            tbNombre.PlaceholderText = "Por ej: David Vincent";
            lblTelefono.Text = "Telefono:";
            tbTelefono.PlaceholderText = "Por ej: 1156124587";

            btnAtras.Text = "Atras";
            btnAgregar.Text = "Agregar";
        }

        private void Form_Agregar_Profesor_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Agregar Profesor";
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

        private void btnAgregar_Click(object sender, EventArgs e)
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
                //ValidadorInputProfesores validacionDelInput = new ValidadorInputProfesores();
                //RespuestaValidacionInput resultadoInputs = validacionDelInput.ValidarDatosProfesor(camposIngresados);

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

                bool validacionDuplicados = ValidadorDuplicados.ValidarDuplicadosProfesores(_correo);

                if (validacionDuplicados)
                {
                    throw new Exception("El profesor ya se encuentra registrado en el sistema");
                }

                // Creo una instancia de Curso y registrar el nuevo curso
                Profesor nuevoProfesor = new Profesor(_nombre, _direccion, _telefono, _correo, _especializacion);
                nuevoProfesor.RegistrarProfesor();

                MessageBox.Show("Profesor registrado exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Cerrar el formulario actual y mostrar el formulario principal de profesores
                this.Hide();
                Form_Profesores_Principal form_Profesores_Principal = new Form_Profesores_Principal();
                form_Profesores_Principal.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
