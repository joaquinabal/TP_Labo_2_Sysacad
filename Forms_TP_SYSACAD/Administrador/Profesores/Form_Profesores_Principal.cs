using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms_TP_SYSACAD.Administrador.Profesores
{
    public partial class Form_Profesores_Principal : Form
    {
        private List<Profesor> _listaProfesores = new List<Profesor>();
        private Profesor _profesorSeleccionado;

        public Form_Profesores_Principal()
        {
            InitializeComponent();
            lblInfo.Text = "INFORMACION DE PROFESORES:";
            btnAtras.Text = "Atras";
            btnAgregar.Text = "Agregar Profesor";
            btnEditar.Text = "Editar Profesor";
            btnAgregarCurso.Text = "Asignar Curso";
            btnEliminar.Text = "Eliminar Profesor";

            MostrarProfesores();
        }

        private void Form_Profesores_Principal_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Gestion de Profesores";

            listViewProfesores.MultiSelect = false;
            listViewProfesores.FullRowSelect = true;
        }

        private void MostrarProfesores()
        {
            listViewProfesores.Items.Clear();

            _listaProfesores = ConsultasProfesores.Profesores;

            // Itero a través de la lista de cursos disponibles y agrega cada curso a la listView
            if (_listaProfesores.Count > 0)
            {
                foreach (Profesor profesor in _listaProfesores)
                {
                    ListViewItem nuevaFila = new ListViewItem(profesor.Nombre);
                    nuevaFila.SubItems.Add(profesor.Correo);
                    nuevaFila.SubItems.Add(profesor.Telefono);
                    nuevaFila.SubItems.Add(profesor.Especializacion);
                    nuevaFila.SubItems.Add(string.Join(", ", profesor.CodigosCursosDeProfesor));
                    nuevaFila.SubItems.Add(profesor.Direccion);

                    listViewProfesores.Items.Add(nuevaFila);
                }
            }
        }

        private void listViewProfesores_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListViewItem cursoSeleccionadoEnListView = e.Item;

            string nombreProfesorSeleccionado = cursoSeleccionadoEnListView.SubItems[0].Text;
            string correoProfesorSeleccionado = cursoSeleccionadoEnListView.SubItems[1].Text;
            string telefonoProfesorSeleccionado = cursoSeleccionadoEnListView.SubItems[2].Text;
            string especializacionProfesorSeleccionado = cursoSeleccionadoEnListView.SubItems[3].Text;
            List<string> cursosProfesorSeleccionado = new List<string>(cursoSeleccionadoEnListView.SubItems[4].Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries));
            string direccionProfesorSeleccionado = cursoSeleccionadoEnListView.SubItems[5].Text;

            //Creo una copia del curso seleccionado
            _profesorSeleccionado = new Profesor(nombreProfesorSeleccionado, direccionProfesorSeleccionado, telefonoProfesorSeleccionado, correoProfesorSeleccionado, especializacionProfesorSeleccionado, cursosProfesorSeleccionado);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Agregar_Profesor formAgregarProfesor = new Form_Agregar_Profesor();
            formAgregarProfesor.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verifica si no se han agregado cursos
            if (_listaProfesores.Count == 0)
            {
                MessageBox.Show("Primero debe agregar profesores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_profesorSeleccionado is null)
            {
                MessageBox.Show("Debe seleccionar algun profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                Form_Editar_Profesor nuevoFormEditarProfesor = new Form_Editar_Profesor(_profesorSeleccionado);
                nuevoFormEditarProfesor.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifico si al menos una fila está seleccionada
            if (listViewProfesores.SelectedItems.Count > 0 && _profesorSeleccionado != null)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el profesor seleccionado?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    //Elimino el curso de la BD
                    ConsultasProfesores.EliminarProfesorBD(_profesorSeleccionado.Correo);

                    // Elimina el curso de la lista local
                    _listaProfesores.Remove(_profesorSeleccionado);

                    //Actualizo el listView
                    MostrarProfesores();
                }
                else
                {
                    // El usuario presiono "Cancelar" y no se realiza ninguna acción
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar algun profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            // Verifica si no se han agregado cursos
            if (_listaProfesores.Count == 0)
            {
                MessageBox.Show("Primero debe agregar profesores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_profesorSeleccionado is null)
            {
                MessageBox.Show("Debe seleccionar algun profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                Form_Agregar_Curso_A_Profesor formAgregaCursoProfesor = new Form_Agregar_Curso_A_Profesor(_profesorSeleccionado);
                formAgregaCursoProfesor.Show();
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
