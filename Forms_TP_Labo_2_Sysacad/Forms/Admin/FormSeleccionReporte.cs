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
    public partial class FormPanelReportes : FormPadre
    {



        public FormPanelReportes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void inscripPeriodoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormParamFechas FormParamFechas = new FormParamFechas(Reporte.InscripcionPorPeriodo);
            FormParamFechas.Show();
        }

        private void estInscriptoCursoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormParamCursoEspecifico FormParamCursoEspecifico = new FormParamCursoEspecifico();
            FormParamCursoEspecifico.Show();
        }

        private void listasEsperaBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormParamFechas FormParamFechas = new FormParamFechas(Reporte.ListaDeEsperaDeCursos);
            FormParamFechas.Show();
        }

        private void IngresosConceptosPagoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormParamFechas FormParamFechas = new FormParamFechas(Reporte.IngresoPorConceptoDePago);
            FormParamFechas.Show();
        }

        private void estadisticasCarreraBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormParamFechas FormParamFechas = new FormParamFechas(Reporte.InscripcionPorCarrera);
            FormParamFechas.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelAdministrador FormPanelAdministrador = new FormPanelAdministrador();
            FormPanelAdministrador.Show();
        }
    }
}

/*
      public enum Reporte
    {
        InscripcionPorPeriodo,
        EstudiantesEnCursoEspecifico,
        IngresoPorConceptoDePago,
        InscripcionPorCarrera,
        ListaDeEsperaDeCursos
    }*/
