using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TP_SYSACAD
{
    public partial class Form_Gestion_Requisitos : Form
    {
        private string _codigoDeFamiliaDelCursoSeleccionado;
        private Curso _cursoSeleccionado;

        private List<string> _correlatividadesDelCursoSeleccionado = new List<string>();

        private List<Curso> _cursosSeleccionadosDelListView = new List<Curso>();
        private Curso _nuevaCorrelatividadSeleccionada;

        private string _creditos;
        private string _promedio;

        ///////////////////////////////////CONFIGURACION INICIAL////////////////////////////////////////

        public Form_Gestion_Requisitos()
        {
            InitializeComponent();
            InicializarComboBoxCursos();
            MostrarListView();
            ConfigurarTextBoxes();
            ConfigurarComboBoxCorrelatividadesDisponibles();

            lblCurso.Text = "Seleccione un curso:";
            lblRequisitoCursos.Text = "Cursos requeridos:";
            lblRequisitoCreditos.Text = "Creditos requeridos:";
            lblRequisitoPromedio.Text = "Promedio requerido:";
            lblAgregar.Text = "Agregar nuevo curso:";
            lblModificar.Text = "Modificar requisitos";
            lblEliminar.Text = "Eliminar requisito";

            btnAtras.Text = "Atras";
            btnEliminar.Text = "Eliminar";
            btnGuardar.Text = "Guardar Cambios";
            btnAgregar.Text = "Agregar";
        }

        private void InicializarComboBoxCursos()
        {
            List<Curso> listaDeCursosSegunCodigoFamilia = ConsultasCursos.ObtenerUnCursoPorCadaCodigoDeFamilia();

            if (listaDeCursosSegunCodigoFamilia.Count > 0)
            {
                foreach (Curso curso in listaDeCursosSegunCodigoFamilia)
                {
                    string nombreCurso = curso.Nombre;
                    cbCursos.Items.Add(nombreCurso);
                }

                cbCursos.SelectedIndex = 0;

                //Obtengo el codigo de familia a partir del nombre del codigo seleccionado
                _codigoDeFamiliaDelCursoSeleccionado = ConsultasCursos.ObtenerCodigoDeFamiliaDesdeNombre(cbCursos.Text);
                //Obtengo el curso seleccionado a partir de su codigo de familia
                _cursoSeleccionado = ConsultasCursos.ObtenerCursoDesdeCodigoDeFamilia(_codigoDeFamiliaDelCursoSeleccionado);
                //Obtengo las correlatividades que posee la familia. 
                _correlatividadesDelCursoSeleccionado = _cursoSeleccionado.Correlatividades;
            }
        }

        private void ConfigurarComboBoxCorrelatividadesDisponibles()
        {
            cbAgregarCorrelatividad.Items.Clear();

            //Obtengo la lista de nombres de aquellos cursos aun no correlativos al seleccionado
            HashSet<string> nombresDeCursosNoCorrelativos = ConsultasCursos.ObtenerNombresDeCursosNoCorrelativos(_cursoSeleccionado);

            if (nombresDeCursosNoCorrelativos.Count > 0)
            {
                foreach (string nombre in nombresDeCursosNoCorrelativos)
                {
                    cbAgregarCorrelatividad.Items.Add(nombre);
                }
            }
        }

        private void MostrarListView()
        {
            listViewCursosRequisitos.Items.Clear();

            if (_correlatividadesDelCursoSeleccionado.Count > 0)
            {
                //Recorro los codigos de familia de las correlatividades del curso seleccionado
                foreach (string codigoDeFamiliaDeCursoRequerido in _correlatividadesDelCursoSeleccionado)
                {
                    //Obtengo el curso a partir del codigo de familia iterado
                    Curso cursoIterado = ConsultasCursos.ObtenerCursoDesdeCodigoDeFamilia(codigoDeFamiliaDeCursoRequerido);

                    //Muestro la informacion del curso respectivo en el listView
                    if (cursoIterado != null)
                    {
                        ListViewItem nuevaFila = new ListViewItem(cursoIterado.CodigoFamilia);
                        nuevaFila.SubItems.Add(cursoIterado.Nombre);

                        listViewCursosRequisitos.Items.Add(nuevaFila);
                    }
                }
            }
        }

        private void ConfigurarTextBoxes()
        {
            tbCreditos.Text = _cursoSeleccionado.CreditosRequeridos.ToString();
            tbPromedio.Text = _cursoSeleccionado.PromedioRequerido.ToString();

            _creditos = _cursoSeleccionado.CreditosRequeridos.ToString();
            _promedio = _cursoSeleccionado.PromedioRequerido.ToString();
        }

        private void Form_Gestion_Requisitos_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Gestion de Requisitos Academicos";
        }


        //////////////////////////////////LOGICA DE LOS ELEMENTOS DEL FORM/////////////////////////////////

        private void cbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreDeCursoSeleccionado = cbCursos.SelectedItem.ToString();

            //Obtengo el codigo de familia a partir del nombre del codigo seleccionado
            _codigoDeFamiliaDelCursoSeleccionado = ConsultasCursos.ObtenerCodigoDeFamiliaDesdeNombre(nombreDeCursoSeleccionado);
            //Obtengo el curso seleccionado a partir de su codigo de familia
            _cursoSeleccionado = ConsultasCursos.ObtenerCursoDesdeCodigoDeFamilia(_codigoDeFamiliaDelCursoSeleccionado);
            //Obtengo las correlatividades que posee la familia. 
            _correlatividadesDelCursoSeleccionado = _cursoSeleccionado.Correlatividades;

            //Actualizo los displays
            MostrarListView();
            ConfigurarTextBoxes();
            ConfigurarComboBoxCorrelatividadesDisponibles();
        }

        private void tbCreditos_TextChanged(object sender, EventArgs e)
        {
            _creditos = tbCreditos.Text;
        }

        private void tbPromedio_TextChanged(object sender, EventArgs e)
        {
            _promedio = tbPromedio.Text;
        }

        private void listViewCursosRequisitos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _cursosSeleccionadosDelListView = new List<Curso>();

            List<string> codigosSeleccionados = new List<string>();

            //Extraigo los codigos de familia del listView y los meto en una lista "codigosSeleccionados"
            foreach (ListViewItem item in listViewCursosRequisitos.SelectedItems)
            {
                string valorPrimeraColumna = item.SubItems[0].Text;
                codigosSeleccionados.Add(valorPrimeraColumna);
            }

            //Obtengo los cursos a partir de su codigo de familia y los meto en la lista de cursos seleccionados
            foreach (string codigo in codigosSeleccionados)
            {
                _cursosSeleccionadosDelListView.Add(ConsultasCursos.ObtenerCursoDesdeCodigoDeFamilia(codigo));
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_cursosSeleccionadosDelListView.Count > 0)
            {
                //Saco de la lista de correlatividades al curso seleccionado para eliminar
                foreach (Curso cursoRequisitoSeleccionado in _cursosSeleccionadosDelListView)
                {
                    _correlatividadesDelCursoSeleccionado.Remove(cursoRequisitoSeleccionado.CodigoFamilia);
                }

                //Actualizo los display
                MostrarListView();
                ConfigurarComboBoxCorrelatividadesDisponibles();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun curso de la lista de correlatividades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbAgregarCorrelatividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nuevaCorrelatividadCodigoDeFamilia = ConsultasCursos.ObtenerCodigoDeFamiliaDesdeNombre(cbAgregarCorrelatividad.Text);
            _nuevaCorrelatividadSeleccionada = ConsultasCursos.ObtenerCursoDesdeCodigoDeFamilia(nuevaCorrelatividadCodigoDeFamilia);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_nuevaCorrelatividadSeleccionada != null)
            {
                //Meto el curso seleccionado del cb en la lista de correlatividades
                _correlatividadesDelCursoSeleccionado.Add(_nuevaCorrelatividadSeleccionada.CodigoFamilia);
                //Borro la seleccion previa
                _nuevaCorrelatividadSeleccionada = null;
                cbAgregarCorrelatividad.SelectedItem = null;

                //Actualizo los display
                MostrarListView();
                ConfigurarComboBoxCorrelatividadesDisponibles();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna nueva correlatividad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //private void btnGuardar_Click(object sender, EventArgs e)
        //{
        //    Dictionary<string, string> camposIngresados = new Dictionary<string, string>();

        //    camposIngresados["creditos"] = _creditos;
        //    camposIngresados["promedio"] = _promedio;

        //    ValidadorInputCursos validacionInputRequisitos = new ValidadorInputCursos();
        //    RespuestaValidacionInput respuestaValidacion = validacionInputRequisitos.ValidarDatosCurso(camposIngresados, ModoValidacionInputCurso.Requisitos);

        //    if (!respuestaValidacion.AusenciaCamposVacios)
        //    {
        //        MessageBox.Show("Asegurese de completar los campos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        // Verifico si existen errores de input
        //        if (respuestaValidacion.ExistenciaErrores)
        //        {
        //            MessageBox.Show(respuestaValidacion.MensajeErrores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        else
        //        {
        //            Sistema.BaseDatosCursos.ActualizarRequisitosACursos(_cursosDeLaFamiliaDelCursoSeleccionado, _correlatividadesDelCursoSeleccionado, int.Parse(_creditos), Convert.ToDouble(_promedio, CultureInfo.InvariantCulture));

        //            MessageBox.Show("Requisitos Actualizados Exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        //            this.Hide();
        //            Form_Panel_Administracion formPanelAdmin = new Form_Panel_Administracion();
        //            formPanelAdmin.Show();
        //        }
        //    }

        //}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>();

                camposIngresados["creditos"] = _creditos;
                camposIngresados["promedio"] = _promedio;

                //ValidadorInputCursos validacionInputRequisitos = new ValidadorInputCursos();
                //RespuestaValidacionInput respuestaValidacion = validacionInputRequisitos.ValidarDatosCurso(camposIngresados, ModoValidacionInputCurso.Requisitos);

                ValidadorInputGenerico validacionInputRequisitos = new ValidadorInputGenerico();
                RespuestaValidacionInput respuestaValidacion = validacionInputRequisitos.ValidarDatos(camposIngresados, ModoValidacionInput.CursoRequisitos);

                if (!respuestaValidacion.AusenciaCamposVacios)
                {
                    throw new Exception("Asegúrese de completar los campos solicitados");
                }

                if (respuestaValidacion.ExistenciaErrores)
                {
                    throw new Exception(respuestaValidacion.MensajeErrores);
                }

                ConsultasCursos.ActualizarRequisitosACursos(_codigoDeFamiliaDelCursoSeleccionado, _correlatividadesDelCursoSeleccionado, int.Parse(_creditos), Convert.ToDouble(_promedio));

                MessageBox.Show("Requisitos Actualizados Exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Hide();
                Form_Panel_Administracion formPanelAdmin = new Form_Panel_Administracion();
                formPanelAdmin.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
