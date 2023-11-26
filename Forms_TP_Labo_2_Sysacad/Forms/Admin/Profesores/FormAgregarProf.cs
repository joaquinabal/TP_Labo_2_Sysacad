using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.Gestores;
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

namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    public partial class FormAgregarProf : FormPadre
    {
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _correo;
        private string _especializacion;
        private GestorProfesores gestorProfesores = new GestorProfesores(); 
        public FormAgregarProf()
        {
            InitializeComponent();
        }

        private void FormAgregarProf_Load(object sender, EventArgs e)
        {
            especializacionCombobox.SelectedIndex = 0;
        }

        private async void agregarBtn_Click(object sender, EventArgs e)
        {
            Profesor nuevoProfesor = new Profesor(_nombre, _direccion, _telefono, _correo, _especializacion);

            Dictionary<string, string> dictCampos = new Dictionary<string, string>()
            {

                {"nombre", _nombre },
                {"direccion", _direccion },
                {"telefono", _telefono },
                {"correo", _correo },
                {"especializacion", _especializacion}

            };

            RespuestaValidacionInput validacionProfesor = gestorProfesores.ValidarInputsProfesor(dictCampos);

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
                bool validacionDuplicado = await gestorProfesores.GestionarAgregarProfesorEnBaseADuplicados(nuevoProfesor);

                if (!validacionDuplicado)
                {
                    MessageBox.Show("Profesor registrado exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

        private void nombreTextbox_TextChanged(object sender, EventArgs e)
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
