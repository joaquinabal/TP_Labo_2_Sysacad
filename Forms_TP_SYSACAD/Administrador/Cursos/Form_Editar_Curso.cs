using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms_TP_SYSACAD
{
    public partial class Form_Editar_Curso : Form
    {
        //Nuevos datos
        private string _nombre;
        private string _codigo;
        private string _descripcion;
        private string _cupo;
        private string _turno;
        private string _aula;
        private string _dia;

        //Datos originales
        private string _codigoOriginal;

        //Recibe la copia del codigo seleccionado
        public Form_Editar_Curso(Curso cursoSeleccionado)
        {
            InitializeComponent();

            //Codigo del curso tal cual como aparecia en el ListView
            _codigoOriginal = cursoSeleccionado.Codigo;

            //Labels y Buttons
            lblInfoEditar.Text = "Edite los datos del curso seleccionado";
            lblNombre.Text = "Nombre: ";
            lblCodigo.Text = "Codigo";
            lblDescripcion.Text = "Descripcion";
            lblCupo.Text = "Cupo Maximo";
            lblAula.Text = "Aula";
            lblTurno.Text = "Turno";
            lblDia.Text = "Dia";

            cbTurno.Items.Add("Mañana");
            cbTurno.Items.Add("Tarde");
            cbTurno.Items.Add("Noche");

            cbDia.Items.Add("Lunes");
            cbDia.Items.Add("Martes");
            cbDia.Items.Add("Miercoles");
            cbDia.Items.Add("Jueves");
            cbDia.Items.Add("Viernes");

            btnConfirmarEdicion.Text = "Confirmar";
            btnAtras.Text = "Atras";

            //Asigno valores default a los campos de texto
            textBoxNombre.Text = cursoSeleccionado.Nombre;
            textBoxCodigo.Text = cursoSeleccionado.Codigo;
            richTextBoxDecripcion.Text = cursoSeleccionado.Descripcion;
            textBoxCupo.Text = cursoSeleccionado.CupoMaximo.ToString();
            tbAula.Text = cursoSeleccionado.Aula;
            cbTurno.SelectedItem = cursoSeleccionado.Turno;
            cbDia.SelectedItem = cursoSeleccionado.Dia;

            //Inicializar estos atributos con los del curso seleccionado me sirven luego para la correcta validacion
            _nombre = cursoSeleccionado.Nombre;
            _codigo = cursoSeleccionado.Codigo;
            _descripcion = cursoSeleccionado.Descripcion;
            _cupo = cursoSeleccionado.CupoMaximo.ToString();
            _aula = cursoSeleccionado.Aula;
            _turno = cursoSeleccionado.Turno;
            _dia = cursoSeleccionado.Dia;
        }

        private void Form_Editar_Curso_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Editar Curso";
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            _nombre = textBoxNombre.Text;
        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {
            _codigo = textBoxCodigo.Text;
        }

        private void richTextBoxDecripcion_TextChanged(object sender, EventArgs e)
        {
            _descripcion = richTextBoxDecripcion.Text;
        }

        private void textBoxCupo_TextChanged(object sender, EventArgs e)
        {
            _cupo = textBoxCupo.Text;
        }

        private void cbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            _turno = cbTurno.SelectedItem.ToString();
        }

        private void cbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dia = cbDia.SelectedItem.ToString();
        }

        private void tbAula_TextChanged(object sender, EventArgs e)
        {
            _aula = tbAula.Text;
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Confirmar Edición".
        /// Valida los datos ingresados, confirma la edición del curso y actualiza la lista de cursos disponibles.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        //private void btnConfirmarEdicion_Click(object sender, EventArgs e)
        //{
        //    Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
        //    {
        //        { "nombre", _nombre},
        //        { "codigo", _codigo },
        //        { "aula", _aula},
        //        { "descripcion", _descripcion},
        //        { "cupoMax", _cupo}
        //    };

        //    //Corroboro si el codigo se cambio
        //    bool cambioDeCodigo;
        //    if (_codigoOriginal != _codigo)
        //    {
        //        cambioDeCodigo = true;
        //    }
        //    else
        //    {
        //        cambioDeCodigo = false;
        //    }

        //    // Valido los datos ingresados
        //    ValidadorInputCursos validacionDelInput = new ValidadorInputCursos();
        //    RespuestaValidacionInput resultadoInputs = validacionDelInput.ValidarDatosCurso(camposIngresados, ModoValidacionInputCurso.AgregarOEditar);

        //    // Compruebo si hay campos vacíos
        //    if (!resultadoInputs.AusenciaCamposVacios)
        //    {
        //        MessageBox.Show("Asegurese de completar los campos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        // Compruebo si hay errores de input
        //        if (resultadoInputs.ExistenciaErrores)
        //        {
        //            MessageBox.Show(resultadoInputs.MensajeErrores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        else
        //        {
        //            //Si se cambio el codigo compruebo si hay duplicados
        //            if (cambioDeCodigo)
        //            {
        //                bool validacionDuplicados = ValidadorDuplicados.ValidarDuplicados(_codigo);

        //                if (!validacionDuplicados)
        //                {
        //                    Sistema.BaseDatosCursos.EditarCursoBD(_codigoOriginal, _nombre, _codigo, _descripcion, int.Parse(_cupo), _turno, _dia, _aula);

        //                    this.Hide();
        //                    Form_Cursos_Disponibles formCursosDisponibles = new Form_Cursos_Disponibles();
        //                    formCursosDisponibles.Show();
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Error... Codigo de curso duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }
        //            else
        //            {
        //                Sistema.BaseDatosCursos.EditarCursoBD(_codigoOriginal, _nombre, _codigo, _descripcion, int.Parse(_cupo), _turno, _dia, _aula);

        //                this.Hide();
        //                Form_Cursos_Disponibles formCursosDisponibles = new Form_Cursos_Disponibles();
        //                formCursosDisponibles.Show();
        //            }
        //        }
        //    }
        //}

        private void btnConfirmarEdicion_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
                {
                    { "nombre", _nombre },
                    { "codigo", _codigo },
                    { "aula", _aula },
                    { "descripcion", _descripcion },
                    { "cupoMax", _cupo }
                };

                //Corroboro si el codigo se cambio
                bool cambioDeCodigo;
                if (_codigoOriginal != _codigo)
                {
                    cambioDeCodigo = true;
                }
                else
                {
                    cambioDeCodigo = false;
                }

                //ValidadorInputCursos validacionDelInput = new ValidadorInputCursos();
                //RespuestaValidacionInput resultadoInputs = validacionDelInput.ValidarDatosCurso(camposIngresados, ModoValidacionInputCurso.AgregarOEditar);

                ValidadorInputGenerico validacionDelInput = new ValidadorInputGenerico();
                RespuestaValidacionInput resultadoInputs = validacionDelInput.ValidarDatos(camposIngresados, ModoValidacionInput.CursoAgregarOEditar);

                if (!resultadoInputs.AusenciaCamposVacios)
                {
                    throw new Exception("Asegúrese de completar los campos solicitados");
                }

                if (resultadoInputs.ExistenciaErrores)
                {
                    throw new Exception(resultadoInputs.MensajeErrores);
                }

                //Si se cambio el codigo compruebo si hay duplicados
                if (cambioDeCodigo)
                {
                    bool validacionDuplicados = ValidadorDuplicados.ValidarDuplicadosCursos(_codigo);

                    if (!validacionDuplicados)
                    {
                        string nuevoCodigoFamilia = ConsultasCursos.ObtenerCodigoDeFamilia(_codigo);

                        ConsultasCursos.EditarCursoBD(_codigoOriginal, _nombre, _codigo, _descripcion, int.Parse(_cupo), _turno, _dia, _aula, nuevoCodigoFamilia);

                        this.Hide();
                        Form_Cursos_Disponibles formCursosDisponibles = new Form_Cursos_Disponibles();
                        formCursosDisponibles.Show();
                    }
                    else
                    {
                        throw new Exception("Error... Codigo de curso duplicado");
                    }
                }
                else
                {
                    ConsultasCursos.EditarCursoBD(_codigoOriginal, _nombre, _codigo, _descripcion, int.Parse(_cupo), _turno, _dia, _aula);

                    this.Hide();
                    Form_Cursos_Disponibles formCursosDisponibles = new Form_Cursos_Disponibles();
                    formCursosDisponibles.Show();
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
            Form_Cursos_Disponibles formCursosDisponibles = new Form_Cursos_Disponibles();
            formCursosDisponibles.Show();
        }
    }
}
