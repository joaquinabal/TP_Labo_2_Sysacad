using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TP_SYSACAD
{
    public partial class Form_Gestion_Listas_Espera : Form
    {
        private Curso _cursoSeleccionado;
        private List<string> _estudiantesSeleccionados = new List<string>();
        private Dictionary<string, DateTime> _alumnosEnListaDeEspera = new Dictionary<string, DateTime>();
        private string _legajoDelEstudianteAAgregar = "";

        public Form_Gestion_Listas_Espera()
        {
            InitializeComponent();
            InicializarListaCursos();
            ActualizarListView();

            lblCurso.Text = "Cursos con listas de espera:";
            lblListasDeEspera.Text = "Lista de espera ordenada segun fecha de inscripcion:";
            lblAgregar.Text = "Agregar alumno";
            lblEliminar.Text = "Eliminar alumno";
            lblModificar.Text = "Modificar lista";

            btnAtras.Text = "Atras";
            btnAgregar.Text = "Agregar";
            btnEliminar.Text = "Eliminar";
            btnGuardar.Text = "Guardar cambios";

            tbLegajoAlumno.PlaceholderText = "LEGAJO DEL ALUMNO (8 DIGITOS)";
        }

        public void InicializarListaCursos()
        {
            List<Curso> cursosDelSistema = ConsultasCursos.Cursos;

            //Obtengo la lsita de cursos y los muestro de una manera amigable al usuario
            foreach (Curso curso in cursosDelSistema)
            {
                if (curso.ListaDeEspera.Count > 0)
                {
                    cbCursos.Items.Add($"{curso.Nombre} - {curso.Turno}");
                }
            }
        }

        public void ActualizarListView()
        {
            listViewListaEspera.Items.Clear();

            if (_cursoSeleccionado != null)
            {
                // Ordeno a los estudiantes por fecha (Del mas antiguo al mas reciente)
                var estudiantesOrdenados = _alumnosEnListaDeEspera.OrderBy(pair => pair.Value);

                foreach (var parClaveValor in estudiantesOrdenados)
                {
                    string legajo = parClaveValor.Key;
                    DateTime fecha = parClaveValor.Value;

                    //Estudiante estudianteIterado = Sistema.BaseDatosEstudiantes.ObtenerEstudianteSegunLegajo(legajo);
                    Estudiante estudianteIterado = ConsultasEstudiantes.ObtenerEstudianteSegunLegajo(legajo);

                    ListViewItem nuevaFila = new ListViewItem(estudianteIterado.Nombre);
                    nuevaFila.SubItems.Add(estudianteIterado.Legajo);
                    nuevaFila.SubItems.Add(fecha.ToString());

                    listViewListaEspera.Items.Add(nuevaFila);
                }
            }
        }

        private void Form_Gestion_Listas_Espera_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Gestion de Listas de Espera";
        }

        private void cbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtengo la opcion seleccionada en forma de texto y lo proceso para obtener el nombre y turno
            string textoDelCursoSeleccionado = cbCursos.Text;
            string[] partes = textoDelCursoSeleccionado.Split(new char[] { '-' });
            string nombreCurso = partes[0].Trim();
            string turno = partes[1].Trim();

            //Obtengo el curso correspondiente a partir del nombre y turno
            _cursoSeleccionado = ConsultasCursos.ObtenerCursoAPartirDeNombreYTurno(nombreCurso, turno);

            //Actualizo los display la lista de espera
            ConfigurarListaEstudiantesEnListaDeEspera();
            ActualizarListView();
        }

        private void ConfigurarListaEstudiantesEnListaDeEspera()
        {
            foreach (var parClaveValor in _cursoSeleccionado.ListaDeEspera)
            {
                string legajo = parClaveValor.Key;
                DateTime fecha = parClaveValor.Value;

                _alumnosEnListaDeEspera[legajo] = fecha;
            }
        }

        private void listViewListaEspera_ItemSelectionChanged(object sender, EventArgs e)
        {
            _estudiantesSeleccionados.Clear();

            foreach (ListViewItem item in listViewListaEspera.SelectedItems)
            {
                _estudiantesSeleccionados.Add(item.SubItems[1].Text);
            }
        }

        private void tbLegajoAlumno_TextChanged(object sender, EventArgs e)
        {
            _legajoDelEstudianteAAgregar = tbLegajoAlumno.Text;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidadorAdicionDeAlumnoEnListaDeEspera validadorDelInputLegajo = new ValidadorAdicionDeAlumnoEnListaDeEspera();
                RespuestaValidacionInput respuestaValidacion = validadorDelInputLegajo.ValidarAdicionAlumnoEnLista(_legajoDelEstudianteAAgregar, _cursoSeleccionado);

                if (respuestaValidacion.AusenciaCamposVacios)
                {
                    if (respuestaValidacion.ExistenciaErrores)
                    {
                        throw new Exception("Ha ingresado incorrectamente el número de legajo");
                    }

                    if (respuestaValidacion.ExistenciaDelAlumno)
                    {
                        if (respuestaValidacion.ExistenciaEnListaDeEspera)
                        {
                            throw new Exception("El alumno ingresado ya se encuentra en la lista de espera");
                        }

                        _alumnosEnListaDeEspera[_legajoDelEstudianteAAgregar] = DateTime.Now;
                        ActualizarListView();
                    }
                    else
                    {
                        throw new Exception("El legajo ingresado no corresponde a ningún alumno");
                    }
                }
                else
                {
                    throw new Exception("Debe ingresar un número de legajo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_estudiantesSeleccionados.Count > 0)
            {
                foreach (string legajo in _estudiantesSeleccionados)
                {
                    _alumnosEnListaDeEspera.Remove(legajo);
                }

                ActualizarListView();
            }
            else
            {
                MessageBox.Show("No ha seleccionado a ningun estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_cursoSeleccionado != null)
            {
                ConsultasCursos.ActualizarListaDeEsperaDeCurso(_cursoSeleccionado, _alumnosEnListaDeEspera);

                this.Hide();
                Form_Panel_Administracion formPanelAdmin = new Form_Panel_Administracion();
                formPanelAdmin.Show();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Panel_Administracion formPanelAdmin = new Form_Panel_Administracion();
            formPanelAdmin.Show();
        }
    }
}
