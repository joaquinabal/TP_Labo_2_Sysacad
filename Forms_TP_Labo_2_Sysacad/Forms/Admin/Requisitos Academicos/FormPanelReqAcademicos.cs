using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
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
    public partial class FormPanelReqAcademicos : FormPadre
    {
        private List<Curso> _listaCursos;
        private Curso? _cursoSeleccionado;
        private BindingSource miBindingSource = new BindingSource();
        private GestorCursos gestorCursos = new GestorCursos();
        public FormPanelReqAcademicos()
        {
            InitializeComponent();
            ListaCursos = gestorCursos.ObtenerUnCursoPorCadaCodigoDeFamilia();
            cursosDGV.Columns[4].DataPropertyName = "Correlatividades";
            ConfigurarBindingSource();
            MostrarCursos();
            // Suscribir al evento CellFormatting
            cursosDGV.CellFormatting += cursosDGV_CellFormatting;
        }

        /// <summary>
        /// Configura el enlace de datos entre una lista de cursos y un DataGridView mediante un BindingSource.
        /// </summary>
        private void ConfigurarBindingSource()
        {
            BindingList<Curso> bindingListaCursos = new BindingList<Curso>();
            // Aquí puedes agregar los cursos a la BindingList<Curso>

            // Asigna la BindingList<Curso> al BindingSource
            miBindingSource.DataSource = bindingListaCursos;

            // Enlaza el DataGridView al BindingSource
            cursosDGV.DataSource = miBindingSource;
        }

        /// <summary>
        /// Actualiza la visualización de cursos en un DataGridView.
        /// </summary>
        private void MostrarCursos()
        {
            // Obtenemos el BindingSource que enlaza el DataGridView
            BindingSource bindingSource = (BindingSource)cursosDGV.DataSource;

            // Obtenemos la BindingList<Curso> desde el BindingSource
            BindingList<Curso> bindingListaCursos = (BindingList<Curso>)bindingSource.List;


            for (int i = 0; i < ListaCursos.Count; i++)
            {
                bindingListaCursos.Add(ListaCursos[i]);
                cursosDGV.Rows[i].Cells["CorrelatividadesColumn"].Value = string.Join(" / ", ListaCursos[i].Correlatividades);
            }
        }

        private void editarCursoBtn_Click(object sender, EventArgs e)
        {
            if (CursoSeleccionado is not null)
            {
                if (cursosReqRadioBtn.Checked)
                {
                    this.Close();
                    FormEditarRequisitoCurso FormEditarRequisitoCurso = new FormEditarRequisitoCurso(CursoSeleccionado);
                    FormEditarRequisitoCurso.Show();
                }
                else if (promedioReqRadioBtn.Checked)
                {
                    this.Close();
                    FormEditarPromedioRequerido FormEditarPromedioRequerido = new FormEditarPromedioRequerido(CursoSeleccionado);
                    FormEditarPromedioRequerido.Show();
                }
                else if (creditosReqRadioBtn.Checked)
                {
                    this.Close();
                    FormEditarCreditosRequeridos FormEditarCreditosRequeridos = new FormEditarCreditosRequeridos(CursoSeleccionado);
                    FormEditarCreditosRequeridos.Show();
                }
                else
                {
                    MessageBox.Show("Seleccione una opción para editar.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un curso.");
            }

        }

        private void cursosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = cursosDGV.CurrentRow;

            string codigoCursoSeleccionado = filaSeleccionada.Cells[1].Value.ToString();

            CursoSeleccionado = gestorCursos.ObtenerCursoDesdeCodigo(codigoCursoSeleccionado);
        }

        private void cursosDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == cursosDGV.Columns["CorrelatividadesColumn"].Index && e.Value != null)
            {
                // Verificar si el valor es una lista de strings
                if (e.Value is List<string> correlatividades)
                {
                    // Convertir la lista de strings a una cadena y asignarla al valor de la celda
                    e.Value = string.Join(", ", correlatividades);
                    e.FormattingApplied = true;
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelAdministrador FormPanelAdministrador = new FormPanelAdministrador();
            FormPanelAdministrador.Show();
        }

        public List<Curso> ListaCursos
        {
            get { return _listaCursos; }
            set { _listaCursos = value; }
        }

        public Curso? CursoSeleccionado
        {
            get { return _cursoSeleccionado; }
            set { _cursoSeleccionado = value; }
        }
    }
}
