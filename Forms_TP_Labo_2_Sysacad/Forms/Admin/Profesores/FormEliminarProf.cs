using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.Gestores;
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
    public partial class FormEliminarProf : FormPadre
    {
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _correo;
        private string _especializacion;
        private GestorProfesores gestorProfesores = new GestorProfesores();
        public FormEliminarProf(Profesor profesor)
        {
            InitializeComponent();

            nombreTextbox.Text = profesor.Nombre;
            direccionTextbox.Text = profesor.Direccion;
            telefonoTextbox.Text += profesor.Telefono;
            correoTextbox.Text += profesor.Correo;
            especializacionCombobox.SelectedIndex = devolverIndiceEspecializacion(profesor);


        }
        /// <summary>
        /// Devuelve el índice correspondiente a la especialización del profesor.
        /// </summary>
        /// <param name="profesor">El profesor del cual se desea obtener el índice de especialización.</param>
        /// <returns>El índice correspondiente a la especialización del profesor.</returns>
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


        private async void editarBtn_Click(object sender, EventArgs e)
        {
            await gestorProfesores.EliminarProfesor(_correo);
            MessageBox.Show("Profesor eliminado exitosmente.");
            this.Close();
            FormPanelAdmProf FormPanelAdmProf = new FormPanelAdmProf();
            FormPanelAdmProf.Show();
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelAdmProf FormPanelAdmProf = new FormPanelAdmProf();
            FormPanelAdmProf.Show();
        }
    }
}
