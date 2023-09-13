using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TP_SYSACAD
{
    public partial class Form_Panel_Administracion : Form
    {
        public Form_Panel_Administracion()
        {
            InitializeComponent();
            lblInformacionPanel.Text = "TAREAS:";
            lblOpcionEstudiante.Text = "Estudiantes:";
            btnRegistroEstudiante.Text = "Registrar";
            lblSeccionCursos.Text = "Cursos:";


            lblInformacionPanel.Font = new Font("Arial", 15, FontStyle.Bold | FontStyle.Italic);
            lblOpcionEstudiante.Font = new Font("Arial", 15);
            lblSeccionCursos.Font = new Font("Arial", 15);

        }

        private void Form_Panel_Administracion_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Panel de Administracion";
        }

        private void btnRegistroEstudiante_Click(object sender, EventArgs e)
        {

        }
    }
}
