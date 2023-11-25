using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Secundarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
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
        private GestorRequisitos gestorRequisitos = new GestorRequisitos();
        public FormEditarRequisitoCurso(Curso curso)
        {
            InitializeComponent();
            ListaCursos = gestorRequisitos.ObtenerUnCursoPorCadaCodigoDeFamilia(); 
            CursoSeleccionado = curso;
            ConfigurarBindingSource();
            MostrarCursos();
        }

        private List<Curso> ObtenerListaCursosSegunCorrelatividades(List<string> correlatividades)
        {
            List<Curso> listaCursosCorrelatividades = new List<Curso>();
            foreach (string codFamilia in correlatividades)
            {
                Curso? cursoAAgregar = gestorRequisitos.ObtenerCursoDesdeCodigoDeFamilia(codFamilia);
                listaCursosCorrelatividades.Add(cursoAAgregar);
            }
            return listaCursosCorrelatividades;
        }
        private void ConfigurarBindingSource()
        {
            BindingList<Curso> bindingListaCursos = new BindingList<Curso>();
            // Aquí puedes agregar los cursos a la BindingList<Curso>

            // Asigna la BindingList<Curso> al BindingSource
            miBindingSource.DataSource = bindingListaCursos;

            // Enlaza el DataGridView al BindingSource
            cursosDGV.DataSource = miBindingSource;
        }

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

            await gestorRequisitos.GestionarConfirmacionRequisitos(dictCampos, CursoSeleccionado.CodigoFamilia, _listaCorrelatividades, CursoSeleccionado.CreditosRequeridos, CursoSeleccionado.PromedioRequerido);
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
