using Libreria_Clases_TP_SYSACAD;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
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

namespace Forms_TP_Labo_2_Sysacad
{
    public partial class FormAgregarCurso : FormPadre
    {
        private string _nombre;
        private string _codigo;
        private string _descripcion;
        private string _cupo;
        private string _turno;
        private string _aula;
        private string _dia;
        private int _carrera;
        private GestorCursos gestorCursos = new GestorCursos();
        public FormAgregarCurso()
        {
            InitializeComponent();
        }


        private async void agregarBtn_Click(object sender, EventArgs e)
        { 
            Dictionary<string, string> dictCampos = new Dictionary<string, string>()
            {

                {"nombre", _nombre },
                {"codigo", _codigo },
                {"aula", _aula },
                {"descripcion", _descripcion },
                {"cupoMax", _cupo}

            };

            RespuestaValidacionInput  validacionCurso = gestorCursos.ValidarInputsCursos(dictCampos);

            if (!validacionCurso.AusenciaCamposVacios)
            {
                MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (validacionCurso.ExistenciaErrores)
            {
                MessageBox.Show(validacionCurso.MensajeErrores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool resultadoValidacion = await gestorCursos.GestionarAgregarCurso(_nombre, _codigo, _descripcion, _cupo, _turno, _dia, _aula, (Carrera)_carrera);

                if (!resultadoValidacion)
                {
                    MessageBox.Show("Curso registrado exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.Close();
                    FormPanelAdmCursos formPanelAdmCursos = new FormPanelAdmCursos();
                    formPanelAdmCursos.Show();
                }
                else if (resultadoValidacion)
                {
                    MessageBox.Show("Ya existe un Curso con esos datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormAgregarCurso_Load(object sender, EventArgs e)
        {
            diaCombobox.SelectedIndex = 0;
            turnoCombobox.SelectedIndex = 0;
        }

        private void nombreTextbox_TextChanged_1(object sender, EventArgs e)
        {
            _nombre = nombreTextbox.Text;
        }

        private void codigoTextbox_TextChanged_1(object sender, EventArgs e)
        {
            _codigo = codigoTextbox.Text;
        }

        private void cupoMaxTextbox_TextChanged_1(object sender, EventArgs e)
        {
            _cupo = cupoMaxTextbox.Text;
        }

        private void descripcionTextbox_TextChanged_1(object sender, EventArgs e)
        {

            _descripcion = descripcionTextbox.Text;
        }

        private void aulaTextbox_TextChanged(object sender, EventArgs e)
        {
            _aula = aulaTextbox.Text;
        }

        private void turnoCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _turno = turnoCombobox.SelectedItem.ToString();
        }

        private void diaCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dia = diaCombobox.SelectedItem.ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelAdmCursos formPanelAdmCursos = new FormPanelAdmCursos();
            formPanelAdmCursos.Show();
        }

        private void carreraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _carrera = carreraComboBox.SelectedIndex;
        }
    }
}
