namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    partial class FormReporteInscripcionPorCarrera
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteInscripcionPorCarrera));
            fechaPopularLabel = new Label();
            mediaPorDiaLabel = new Label();
            inscripcionesTotalesLabel = new Label();
            hastaLabel = new Label();
            desdeLabel = new Label();
            inscripcionesDGV = new DataGridView();
            legajoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreCursoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoCursoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carreraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            registroDeInscripcionBindingSource = new BindingSource(components);
            ExportarPDFBtn = new Button();
            backBtn = new Button();
            pictureBox1 = new PictureBox();
            lbl = new Label();
            SysacadLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)inscripcionesDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registroDeInscripcionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // fechaPopularLabel
            // 
            fechaPopularLabel.AutoSize = true;
            fechaPopularLabel.Location = new Point(540, 305);
            fechaPopularLabel.Name = "fechaPopularLabel";
            fechaPopularLabel.Size = new Size(140, 15);
            fechaPopularLabel.TabIndex = 68;
            fechaPopularLabel.Text = "Fecha con Más Registros:";
            // 
            // mediaPorDiaLabel
            // 
            mediaPorDiaLabel.AutoSize = true;
            mediaPorDiaLabel.Location = new Point(327, 305);
            mediaPorDiaLabel.Name = "mediaPorDiaLabel";
            mediaPorDiaLabel.Size = new Size(84, 15);
            mediaPorDiaLabel.TabIndex = 67;
            mediaPorDiaLabel.Text = "Media por Día:";
            // 
            // inscripcionesTotalesLabel
            // 
            inscripcionesTotalesLabel.AutoSize = true;
            inscripcionesTotalesLabel.Location = new Point(65, 305);
            inscripcionesTotalesLabel.Name = "inscripcionesTotalesLabel";
            inscripcionesTotalesLabel.Size = new Size(118, 15);
            inscripcionesTotalesLabel.TabIndex = 66;
            inscripcionesTotalesLabel.Text = "Inscripciones Totales:";
            // 
            // hastaLabel
            // 
            hastaLabel.AutoSize = true;
            hastaLabel.Location = new Point(34, 102);
            hastaLabel.Name = "hastaLabel";
            hastaLabel.Size = new Size(40, 15);
            hastaLabel.TabIndex = 65;
            hastaLabel.Text = "Hasta:";
            // 
            // desdeLabel
            // 
            desdeLabel.AutoSize = true;
            desdeLabel.Location = new Point(34, 47);
            desdeLabel.Name = "desdeLabel";
            desdeLabel.Size = new Size(45, 15);
            desdeLabel.TabIndex = 64;
            desdeLabel.Text = "Desde: ";
            // 
            // inscripcionesDGV
            // 
            inscripcionesDGV.AutoGenerateColumns = false;
            inscripcionesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inscripcionesDGV.Columns.AddRange(new DataGridViewColumn[] { legajoDataGridViewTextBoxColumn, nombreCursoDataGridViewTextBoxColumn, codigoCursoDataGridViewTextBoxColumn, carreraDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn });
            inscripcionesDGV.DataSource = registroDeInscripcionBindingSource;
            inscripcionesDGV.Location = new Point(65, 136);
            inscripcionesDGV.Name = "inscripcionesDGV";
            inscripcionesDGV.RowTemplate.Height = 25;
            inscripcionesDGV.Size = new Size(644, 150);
            inscripcionesDGV.TabIndex = 63;
            // 
            // legajoDataGridViewTextBoxColumn
            // 
            legajoDataGridViewTextBoxColumn.DataPropertyName = "Legajo";
            legajoDataGridViewTextBoxColumn.HeaderText = "Legajo";
            legajoDataGridViewTextBoxColumn.Name = "legajoDataGridViewTextBoxColumn";
            legajoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreCursoDataGridViewTextBoxColumn
            // 
            nombreCursoDataGridViewTextBoxColumn.DataPropertyName = "NombreCurso";
            nombreCursoDataGridViewTextBoxColumn.HeaderText = "NombreCurso";
            nombreCursoDataGridViewTextBoxColumn.Name = "nombreCursoDataGridViewTextBoxColumn";
            nombreCursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoCursoDataGridViewTextBoxColumn
            // 
            codigoCursoDataGridViewTextBoxColumn.DataPropertyName = "CodigoCurso";
            codigoCursoDataGridViewTextBoxColumn.HeaderText = "CodigoCurso";
            codigoCursoDataGridViewTextBoxColumn.Name = "codigoCursoDataGridViewTextBoxColumn";
            codigoCursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carreraDataGridViewTextBoxColumn
            // 
            carreraDataGridViewTextBoxColumn.DataPropertyName = "Carrera";
            carreraDataGridViewTextBoxColumn.HeaderText = "Carrera";
            carreraDataGridViewTextBoxColumn.Name = "carreraDataGridViewTextBoxColumn";
            carreraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registroDeInscripcionBindingSource
            // 
            registroDeInscripcionBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesSecundarias.RegistroDeInscripcion);
            // 
            // ExportarPDFBtn
            // 
            ExportarPDFBtn.AutoSize = true;
            ExportarPDFBtn.BackColor = Color.Goldenrod;
            ExportarPDFBtn.FlatStyle = FlatStyle.Flat;
            ExportarPDFBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExportarPDFBtn.Location = new Point(315, 357);
            ExportarPDFBtn.Name = "ExportarPDFBtn";
            ExportarPDFBtn.Size = new Size(144, 33);
            ExportarPDFBtn.TabIndex = 62;
            ExportarPDFBtn.Text = "Exportar PDF";
            ExportarPDFBtn.UseVisualStyleBackColor = false;
            ExportarPDFBtn.Click += ExportarPDFBtn_Click_1;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(7, 371);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 61;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(722, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(300, 91);
            lbl.Name = "lbl";
            lbl.Size = new Size(137, 29);
            lbl.TabIndex = 59;
            lbl.Text = "REPORTE";
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(279, 31);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 58;
            SysacadLbl.Text = "SYSACAD";
            // 
            // FormReporteInscripcionPorCarrera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 450);
            Controls.Add(fechaPopularLabel);
            Controls.Add(mediaPorDiaLabel);
            Controls.Add(inscripcionesTotalesLabel);
            Controls.Add(hastaLabel);
            Controls.Add(desdeLabel);
            Controls.Add(inscripcionesDGV);
            Controls.Add(ExportarPDFBtn);
            Controls.Add(backBtn);
            Controls.Add(pictureBox1);
            Controls.Add(lbl);
            Controls.Add(SysacadLbl);
            Name = "FormReporteInscripcionPorCarrera";
            Text = "FormReporteInscripcionPorCarrera";
            ((System.ComponentModel.ISupportInitialize)inscripcionesDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)registroDeInscripcionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fechaPopularLabel;
        private Label mediaPorDiaLabel;
        private Label inscripcionesTotalesLabel;
        private Label hastaLabel;
        private Label desdeLabel;
        private DataGridView inscripcionesDGV;
        private DataGridViewTextBoxColumn legajoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreAlumnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreCursoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoCursoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carreraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private BindingSource registroDeInscripcionBindingSource;
        private Button ExportarPDFBtn;
        private Button backBtn;
        private PictureBox pictureBox1;
        private Label lbl;
        private Label SysacadLbl;
    }
}