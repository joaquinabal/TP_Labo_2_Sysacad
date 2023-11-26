using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Gestores;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
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
    public partial class FormEditarRequisitoCurso : FormPadre

    {
        private List<Curso> _listaCursos;
        private Curso _cursoSeleccionado;
        private List<string> _listaCorrelatividades = new List<string>();
        private BindingSource miBindingSource = new BindingSource();
        private GestorCursos gestorCursos = new GestorCursos();
        private GestorRequisitos gestorRequisitos = new GestorRequisitos();
        public FormEditarRequisitoCurso(Curso curso)
        {
            InitializeComponent();
            ListaCursos = gestorCursos.ObtenerUnCursoPorCadaCodigoDeFamilia(); 
            CursoSeleccionado = curso;
            ConfigurarBindingSource();
            MostrarCursos();
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
        /// Agrega una lista de cursos al origen de datos enlazado con el DataGridView de cursos.
        /// </summary>
        private void MostrarCursos()
        {
            // Obtenemos el BindingSource que enlaza el DataGridView
            BindingSource bindingSource = (BindingSource)cursosDGV.DataSource;

            // Obtenemos la BindingList<Curso> desde el BindingSource
            BindingList<Curso> bindingListaCursos = (BindingList<Curso>)bindingSource.List;


            foreach (Curso curso in ListaCursos)
            {
                bindingListaCursos.Add(curso);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelReqAcademicos FormPanelReqAcademicos = new FormPanelReqAcademicos();
            FormPanelReqAcademicos.Show();
        }


        private async void agregarCursoBtn_Click(object sender, EventArgs e)
        {
              Dictionary<string, string> dictCampos = new Dictionary<string, string>()
            {
                { "promedio", CursoSeleccionado.PromedioRequerido.ToString() },
                { "creditos", CursoSeleccionado.CreditosRequeridos.ToString() }
            };

            for (int i = 0; i < ListaCursos.Count; i++)
            {
                //    if (Convert.ToBoolean(cursosDGV.Rows[i].Cells["checkBoxColumn"].Value = true))
                if ((string)cursosDGV.Rows[i].Cells["checkBoxColumn"].Value == "T")
                {
                    string cursoCorrelatividad = ListaCursos[i].Nombre.ToUpper().Replace(" ", "");
                    _listaCorrelatividades.Add(cursoCorrelatividad);
                }
            }

            await gestorRequisitos.GestionarConfirmacionRequisitos(dictCampos, CursoSeleccionado.CodigoFamilia, _listaCorrelatividades, CursoSeleccionado.CreditosRequeridos.ToString(), CursoSeleccionado.PromedioRequerido.ToString());
            MessageBox.Show("Cursos requeridos editados correctamente.");

            this.Close();
            FormPanelReqAcademicos FormPanelReqAcademicos = new FormPanelReqAcademicos();
            FormPanelReqAcademicos.Show();
        }

        public List<Curso> ListaCursos
        {
            get { return _listaCursos; }
            set { _listaCursos = value; }
        }

        public Curso CursoSeleccionado
        {
            get { return _cursoSeleccionado; }
            set { _cursoSeleccionado = value; }
        }
    }
}
