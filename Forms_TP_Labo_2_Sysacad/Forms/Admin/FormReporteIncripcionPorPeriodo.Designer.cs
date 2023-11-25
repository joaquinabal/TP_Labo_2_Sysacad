namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    partial class FormReporteIncripcionPorPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteIncripcionPorPeriodo));
            pictureBox1 = new PictureBox();
            lbl = new Label();
            SysacadLbl = new Label();
            ExportarPDFBtn = new Button();
            backBtn = new Button();
            inscripcionesDGV = new DataGridView();
            legajoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreCursoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoCursoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carreraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            registroDeInscripcionBindingSource = new BindingSource(components);
            desdeLabel = new Label();
            hastaLabel = new Label();
            inscripcionesTotalesLabel = new Label();
            mediaPorDiaLabel = new Label();
            fechaPopularLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inscripcionesDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registroDeInscripcionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(727, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(305, 91);
            lbl.Name = "lbl";
            lbl.Size = new Size(137, 29);
            lbl.TabIndex = 37;
            lbl.Text = "REPORTE";
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(284, 31);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 36;
            SysacadLbl.Text = "SYSACAD";
            // 
            // ExportarPDFBtn
            // 
            ExportarPDFBtn.AutoSize = true;
            ExportarPDFBtn.BackColor = Color.Goldenrod;
            ExportarPDFBtn.FlatStyle = FlatStyle.Flat;
            ExportarPDFBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExportarPDFBtn.Location = new Point(320, 357);
            ExportarPDFBtn.Name = "ExportarPDFBtn";
            ExportarPDFBtn.Size = new Size(144, 33);
            ExportarPDFBtn.TabIndex = 40;
            ExportarPDFBtn.Text = "Exportar PDF";
            ExportarPDFBtn.UseVisualStyleBackColor = false;
            ExportarPDFBtn.Click += ExportarPDFBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(12, 371);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 39;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // inscripcionesDGV
            // 
            inscripcionesDGV.AutoGenerateColumns = false;
            inscripcionesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inscripcionesDGV.Columns.AddRange(new DataGridViewColumn[] { legajoDataGridViewTextBoxColumn, nombreCursoDataGridViewTextBoxColumn, codigoCursoDataGridViewTextBoxColumn, carreraDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn });
            inscripcionesDGV.DataSource = registroDeInscripcionBindingSource;
            inscripcionesDGV.Location = new Point(70, 136);
            inscripcionesDGV.Name = "inscripcionesDGV";
            inscripcionesDGV.RowTemplate.Height = 25;
            inscripcionesDGV.Size = new Size(644, 150);
            inscripcionesDGV.TabIndex = 41;
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
            // desdeLabel
            // 
            desdeLabel.AutoSize = true;
            desdeLabel.Location = new Point(39, 47);
            desdeLabel.Name = "desdeLabel";
            desdeLabel.Size = new Size(45, 15);
            desdeLabel.TabIndex = 42;
            desdeLabel.Text = "Desde: ";
            // 
            // hastaLabel
            // 
            hastaLabel.AutoSize = true;
            hastaLabel.Location = new Point(39, 102);
            hastaLabel.Name = "hastaLabel";
            hastaLabel.Size = new Size(40, 15);
            hastaLabel.TabIndex = 43;
            hastaLabel.Text = "Hasta:";
            // 
            // inscripcionesTotalesLabel
            // 
            inscripcionesTotalesLabel.AutoSize = true;
            inscripcionesTotalesLabel.Location = new Point(70, 305);
            inscripcionesTotalesLabel.Name = "inscripcionesTotalesLabel";
            inscripcionesTotalesLabel.Size = new Size(118, 15);
            inscripcionesTotalesLabel.TabIndex = 44;
            inscripcionesTotalesLabel.Text = "Inscripciones Totales:";
            // 
            // mediaPorDiaLabel
            // 
            mediaPorDiaLabel.AutoSize = true;
            mediaPorDiaLabel.Location = new Point(332, 305);
            mediaPorDiaLabel.Name = "mediaPorDiaLabel";
            mediaPorDiaLabel.Size = new Size(84, 15);
            mediaPorDiaLabel.TabIndex = 45;
            mediaPorDiaLabel.Text = "Media por Día:";
            // 
            // fechaPopularLabel
            // 
            fechaPopularLabel.AutoSize = true;
            fechaPopularLabel.Location = new Point(545, 305);
            fechaPopularLabel.Name = "fechaPopularLabel";
            fechaPopularLabel.Size = new Size(140, 15);
            fechaPopularLabel.TabIndex = 46;
            fechaPopularLabel.Text = "Fecha con Más Registros:";
            // 
            // FormReporteIncripcionPorPeriodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 421);
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
            Name = "FormReporteIncripcionPorPeriodo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)inscripcionesDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)registroDeInscripcionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl;
        private Label SysacadLbl;
        private Button ExportarPDFBtn;
        private Button backBtn;
        private DataGridView inscripcionesDGV;
        private DataGridViewTextBoxColumn legajoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreAlumnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreCursoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoCursoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carreraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private BindingSource registroDeInscripcionBindingSource;
        private Label desdeLabel;
        private Label hastaLabel;
        private Label inscripcionesTotalesLabel;
        private Label mediaPorDiaLabel;
        private Label fechaPopularLabel;
    }
}