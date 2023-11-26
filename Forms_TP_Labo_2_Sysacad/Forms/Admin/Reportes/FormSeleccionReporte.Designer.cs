namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    partial class FormPanelReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanelReportes));
            IngresosConceptosPagoBtn = new Button();
            estInscriptoCursoBtn = new Button();
            estadisticasCarreraBtn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            inscripPeriodoBtn = new Button();
            SysacadLbl = new Label();
            backBtn = new Button();
            listasEsperaBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // IngresosConceptosPagoBtn
            // 
            IngresosConceptosPagoBtn.AutoSize = true;
            IngresosConceptosPagoBtn.BackColor = Color.Goldenrod;
            IngresosConceptosPagoBtn.FlatStyle = FlatStyle.Popup;
            IngresosConceptosPagoBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            IngresosConceptosPagoBtn.Location = new Point(27, 246);
            IngresosConceptosPagoBtn.Name = "IngresosConceptosPagoBtn";
            IngresosConceptosPagoBtn.Size = new Size(296, 35);
            IngresosConceptosPagoBtn.TabIndex = 36;
            IngresosConceptosPagoBtn.Text = "Ingresos por Conceptos de Pago";
            IngresosConceptosPagoBtn.UseVisualStyleBackColor = false;
            IngresosConceptosPagoBtn.Click += IngresosConceptosPagoBtn_Click;
            // 
            // estInscriptoCursoBtn
            // 
            estInscriptoCursoBtn.AutoSize = true;
            estInscriptoCursoBtn.BackColor = Color.Goldenrod;
            estInscriptoCursoBtn.FlatStyle = FlatStyle.Popup;
            estInscriptoCursoBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            estInscriptoCursoBtn.Location = new Point(27, 193);
            estInscriptoCursoBtn.Name = "estInscriptoCursoBtn";
            estInscriptoCursoBtn.Size = new Size(292, 35);
            estInscriptoCursoBtn.TabIndex = 34;
            estInscriptoCursoBtn.Text = "Estudiantes en Curso Específico";
            estInscriptoCursoBtn.UseVisualStyleBackColor = false;
            estInscriptoCursoBtn.Click += estInscriptoCursoBtn_Click;
            // 
            // estadisticasCarreraBtn
            // 
            estadisticasCarreraBtn.AutoSize = true;
            estadisticasCarreraBtn.BackColor = Color.Goldenrod;
            estadisticasCarreraBtn.FlatStyle = FlatStyle.Popup;
            estadisticasCarreraBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            estadisticasCarreraBtn.Location = new Point(27, 354);
            estadisticasCarreraBtn.Name = "estadisticasCarreraBtn";
            estadisticasCarreraBtn.Size = new Size(292, 35);
            estadisticasCarreraBtn.TabIndex = 33;
            estadisticasCarreraBtn.Text = "Estadísticas por Carrera";
            estadisticasCarreraBtn.UseVisualStyleBackColor = false;
            estadisticasCarreraBtn.Click += estadisticasCarreraBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(279, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 85);
            label1.Name = "label1";
            label1.Size = new Size(286, 29);
            label1.TabIndex = 31;
            label1.Text = "PANEL DE REPORTES";
            // 
            // inscripPeriodoBtn
            // 
            inscripPeriodoBtn.AutoSize = true;
            inscripPeriodoBtn.BackColor = Color.Goldenrod;
            inscripPeriodoBtn.FlatStyle = FlatStyle.Flat;
            inscripPeriodoBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            inscripPeriodoBtn.Location = new Point(27, 138);
            inscripPeriodoBtn.Name = "inscripPeriodoBtn";
            inscripPeriodoBtn.Size = new Size(292, 37);
            inscripPeriodoBtn.TabIndex = 29;
            inscripPeriodoBtn.Text = "Inscripciones por Periodo";
            inscripPeriodoBtn.UseVisualStyleBackColor = false;
            inscripPeriodoBtn.Click += inscripPeriodoBtn_Click;
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(69, 25);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 28;
            SysacadLbl.Text = "SYSACAD";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(3, 428);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 27;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // listasEsperaBtn
            // 
            listasEsperaBtn.AutoSize = true;
            listasEsperaBtn.BackColor = Color.Goldenrod;
            listasEsperaBtn.FlatStyle = FlatStyle.Popup;
            listasEsperaBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listasEsperaBtn.Location = new Point(27, 300);
            listasEsperaBtn.Name = "listasEsperaBtn";
            listasEsperaBtn.Size = new Size(296, 35);
            listasEsperaBtn.TabIndex = 37;
            listasEsperaBtn.Text = "Lista de Espera por Cursos";
            listasEsperaBtn.UseVisualStyleBackColor = false;
            listasEsperaBtn.Click += listasEsperaBtn_Click;
            // 
            // FormPanelReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 467);
            Controls.Add(listasEsperaBtn);
            Controls.Add(IngresosConceptosPagoBtn);
            Controls.Add(estInscriptoCursoBtn);
            Controls.Add(estadisticasCarreraBtn);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(inscripPeriodoBtn);
            Controls.Add(SysacadLbl);
            Controls.Add(backBtn);
            Name = "FormPanelReportes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button IngresosConceptosPagoBtn;
        private Button estInscriptoCursoBtn;
        private Button estadisticasCarreraBtn;
        private PictureBox pictureBox1;
        private Label label1;
        private Button inscripPeriodoBtn;
        private Label SysacadLbl;
        private Button backBtn;
        private Button listasEsperaBtn;
    }
}