using Libreria_Clases_TP_SYSACAD;
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
    public partial class FormConsultarHorario : FormPadre
    {
        public FormConsultarHorario()
        {
            InitializeComponent();
            cargarFilasEnDGV();
            agregarCursoATablaHorario();
        }

        /// <summary>
        /// Carga filas iniciales en el DataGridView "horariosDGV" con los días de la semana y celdas vacías para los horarios.
        /// </summary>
        private void cargarFilasEnDGV()
        {
            string[] diasSemana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
            foreach (string dia in diasSemana)
            {
                horariosDGV.Rows.Add(dia, "", "", ""); // Puedes dejar en blanco las celdas de mañana y tarde inicialmente
            }
        }

        /// <summary>
        /// Agrega cursos inscritos por el estudiante al horario en el DataGridView "horariosDGV".
        /// </summary>
        private void agregarCursoATablaHorario()
        {
            foreach (Curso curso in Sistema.EstudianteLogueado.CursosInscriptos)
            {
                switch (curso.Dia)
                {
                    case "Lunes":
                        switch (curso.Turno)
                        {
                            case "Mañana":
                                horariosDGV.Rows[0].Cells[1].Value = curso.Nombre; break;

                            case "Tarde":
                                horariosDGV.Rows[0].Cells[2].Value = curso.Nombre; break;

                            case "Noche":
                                horariosDGV.Rows[0].Cells[3].Value = curso.Nombre; break;
                        }
                        break;

                    case "Martes":
                        switch (curso.Turno)
                        {
                            case "Mañana":
                                horariosDGV.Rows[1].Cells[1].Value = curso.Nombre; break;

                            case "Tarde":
                                horariosDGV.Rows[1].Cells[2].Value = curso.Nombre; break;

                            case "Noche":
                                horariosDGV.Rows[1].Cells[3].Value = curso.Nombre; break;
                        }
                        break;

                    case "Miércoles":
                        switch (curso.Turno)
                        {
                            case "Mañana":
                                horariosDGV.Rows[2].Cells[1].Value = curso.Nombre; break;

                            case "Tarde":
                                horariosDGV.Rows[2].Cells[2].Value = curso.Nombre; break;

                            case "Noche":
                                horariosDGV.Rows[2].Cells[3].Value = curso.Nombre; break;
                        }
                        break;

                    case "Jueves":
                        switch (curso.Turno)
                        {
                            case "Mañana":
                                horariosDGV.Rows[3].Cells[1].Value = curso.Nombre; break;

                            case "Tarde":
                                horariosDGV.Rows[3].Cells[2].Value = curso.Nombre; break;

                            case "Noche":
                                horariosDGV.Rows[3].Cells[3].Value = curso.Nombre; break;
                        }
                        break;

                    case "Viernes":
                        switch (curso.Turno)
                        {
                            case "Mañana":
                                horariosDGV.Rows[4].Cells[1].Value = curso.Nombre; break;

                            case "Tarde":
                                horariosDGV.Rows[4].Cells[2].Value = curso.Nombre; break;

                            case "Noche":
                                horariosDGV.Rows[4].Cells[3].Value = curso.Nombre; break;
                        }
                        break;
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelEst formPanelEst = new FormPanelEst();
            formPanelEst.Show();
        }

    }
}
