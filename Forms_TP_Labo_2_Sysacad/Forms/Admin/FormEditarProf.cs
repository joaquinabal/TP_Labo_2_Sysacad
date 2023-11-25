using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
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
using Xceed.Document.NET;

namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    public partial class FormEditarProf : FormPadre
    {
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _correo;
        private string _especializacion;
        private string _correoOriginal;

        public FormEditarProf(Profesor profesor)
        {
            InitializeComponent();

            nombreTextbox.Text = profesor.Nombre;
            direccionTextbox.Text = profesor.Direccion;
            telefonoTextbox.Text += profesor.Telefono;
            correoTextbox.Text += profesor.Correo;
            especializacionCombobox.SelectedIndex = devolverIndiceEspecializacion(profesor);
            _correoOriginal = profesor.Correo;
        }

        private int devolverIndiceEspecializacion(Profesor profesor)
        {
            int indice = 0;
            switch (profesor.Especializacion)
            {
                case "Esp 1":
                    indice = 0;
                    break;

                case "Esp 2":
                    indice = 1;
                    break;

                case "Esp 3":
                    indice = 2;
                    break;
                case "Esp 4":
                    indice = 3;
                    break;
            }

            return indice;
        }


        private void nombreTextbox_TextChanged(object sender, EventArgs e)
        {
            _nombre = nombreTextbox.Text;
        }

        private void direccionTextbox_TextChanged(object sender, EventArgs e)
        {
            _direccion = direccionTextbox.Text;
        }

        private void telefonoTextbox_TextChanged(object sender, EventArgs e)
        {
            _telefono = telefonoTextbox.Text;
        }

        private void correoTextbox_TextChanged(object sender, EventArgs e)
        {

            _correo = correoTextbox.Text;
        }

        private void especializacionCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _especializacion = especializacionCombobox.SelectedItem.ToString();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            ValidadorInputGenerico validadorInputProfesores = new ValidadorInputGenerico();

            Dictionary<string, string> dictCampos = new Dictionary<string, string>()
            {

                {"nombre", _nombre },
                {"direccion", _direccion },
                {"telefono", _telefono },
                {"correo", _correo },
                {"especializacion", _especializacion}

            };

            bool validacionDuplicado = ValidadorDuplicados.ValidarDuplicadosProfesores(_correo);

            RespuestaValidacionInput validacionProfesor = validadorInputProfesores.ValidarDatos(dictCampos, ModoValidacionInput.Profesores);

            if (!validacionProfesor.AusenciaCamposVacios)
            {
                MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validacionProfesor.ExistenciaErrores)
            {
                MessageBox.Show(validacionProfesor.MensajeErrores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!validacionDuplicado)
                {
                    ConsultasProfesores.EditarProfesor(_correo, _nombre, _direccion, _especializacion, _telefono, _correoOriginal);

                    MessageBox.Show("Profesor editado exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.Close();
                    FormPanelAdmProf FormPanelAdmProf = new FormPanelAdmProf();
                    FormPanelAdmProf.Show();
                }
                else
                {
                    MessageBox.Show("Ya existe un profesor con esos datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void nombreTextbox_TextChanged_1(object sender, EventArgs e)
        {
            _nombre = nombreTextbox.Text;
        }

        private void direccionTextbox_TextChanged_1(object sender, EventArgs e)
        {
            _direccion = direccionTextbox.Text;
        }

        private void telefonoTextbox_TextChanged_1(object sender, EventArgs e)
        {
            _telefono = telefonoTextbox.Text;
        }

        private void correoTextbox_TextChanged_1(object sender, EventArgs e)
        {

            _correo = correoTextbox.Text;
        }

        private void especializacionCombobox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _especializacion = especializacionCombobox.SelectedItem.ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelAdmProf FormPanelAdmProf = new FormPanelAdmProf();
            FormPanelAdmProf.Show();
        }
    }
}

