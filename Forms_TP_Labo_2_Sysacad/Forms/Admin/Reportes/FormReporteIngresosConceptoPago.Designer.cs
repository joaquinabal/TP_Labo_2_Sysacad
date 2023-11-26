namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    partial class FormReporteIngresosConceptoPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteIngresosConceptoPago));
            fechaPopularLabel = new Label();
            mediaPorDiaLabel = new Label();
            inscripcionesTotalesLabel = new Label();
            hastaLabel = new Label();
            desdeLabel = new Label();
            registrosDePagoDGV = new DataGridView();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            conceptoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            legajoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreEstudianteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingresoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            registroDePagoBindingSource = new BindingSource(components);
            ExportarPDFBtn = new Button();
            backBtn = new Button();
            pictureBox1 = new PictureBox();
            lbl = new Label();
            SysacadLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)registrosDePagoDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registroDePagoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // fechaPopularLabel
            // 
            fechaPopularLabel.AutoSize = true;
            fechaPopularLabel.Location = new Point(539, 313);
            fechaPopularLabel.Name = "fechaPopularLabel";
            fechaPopularLabel.Size = new Size(140, 15);
            fechaPopularLabel.TabIndex = 57;
            fechaPopularLabel.Text = "Fecha con Más Registros:";
            // 
            // mediaPorDiaLabel
            // 
            mediaPorDiaLabel.AutoSize = true;
            mediaPorDiaLabel.Location = new Point(326, 313);
            mediaPorDiaLabel.Name = "mediaPorDiaLabel";
            mediaPorDiaLabel.Size = new Size(84, 15);
            mediaPorDiaLabel.TabIndex = 56;
            mediaPorDiaLabel.Text = "Media por Día:";
            // 
            // inscripcionesTotalesLabel
            // 
            inscripcionesTotalesLabel.AutoSize = true;
            inscripcionesTotalesLabel.Location = new Point(64, 313);
            inscripcionesTotalesLabel.Name = "inscripcionesTotalesLabel";
            inscripcionesTotalesLabel.Size = new Size(118, 15);
            inscripcionesTotalesLabel.TabIndex = 55;
            inscripcionesTotalesLabel.Text = "Inscripciones Totales:";
            // 
            // hastaLabel
            // 
            hastaLabel.AutoSize = true;
            hastaLabel.Location = new Point(33, 110);
            hastaLabel.Name = "hastaLabel";
            hastaLabel.Size = new Size(40, 15);
            hastaLabel.TabIndex = 54;
            hastaLabel.Text = "Hasta:";
            // 
            // desdeLabel
            // 
            desdeLabel.AutoSize = true;
            desdeLabel.Location = new Point(33, 55);
            desdeLabel.Name = "desdeLabel";
            desdeLabel.Size = new Size(45, 15);
            desdeLabel.TabIndex = 53;
            desdeLabel.Text = "Desde: ";
            // 
            // registrosDePagoDGV
            // 
            registrosDePagoDGV.AutoGenerateColumns = false;
            registrosDePagoDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registrosDePagoDGV.Columns.AddRange(new DataGridViewColumn[] { fechaDataGridViewTextBoxColumn, conceptoDataGridViewTextBoxColumn, legajoDataGridViewTextBoxColumn, nombreEstudianteDataGridViewTextBoxColumn, ingresoDataGridViewTextBoxColumn });
            registrosDePagoDGV.DataSource = registroDePagoBindingSource;
            registrosDePagoDGV.Location = new Point(64, 144);
            registrosDePagoDGV.Name = "registrosDePagoDGV";
            registrosDePagoDGV.RowTemplate.Height = 25;
            registrosDePagoDGV.Size = new Size(644, 150);
            registrosDePagoDGV.TabIndex = 52;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conceptoDataGridViewTextBoxColumn
            // 
            conceptoDataGridViewTextBoxColumn.DataPropertyName = "Concepto";
            conceptoDataGridViewTextBoxColumn.HeaderText = "Concepto";
            conceptoDataGridViewTextBoxColumn.Name = "conceptoDataGridViewTextBoxColumn";
            conceptoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // legajoDataGridViewTextBoxColumn
            // 
            legajoDataGridViewTextBoxColumn.DataPropertyName = "Legajo";
            legajoDataGridViewTextBoxColumn.HeaderText = "Legajo";
            legajoDataGridViewTextBoxColumn.Name = "legajoDataGridViewTextBoxColumn";
            legajoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreEstudianteDataGridViewTextBoxColumn
            // 
            nombreEstudianteDataGridViewTextBoxColumn.DataPropertyName = "NombreEstudiante";
            nombreEstudianteDataGridViewTextBoxColumn.HeaderText = "NombreEstudiante";
            nombreEstudianteDataGridViewTextBoxColumn.Name = "nombreEstudianteDataGridViewTextBoxColumn";
            nombreEstudianteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingresoDataGridViewTextBoxColumn
            // 
            ingresoDataGridViewTextBoxColumn.DataPropertyName = "Ingreso";
            ingresoDataGridViewTextBoxColumn.HeaderText = "Ingreso";
            ingresoDataGridViewTextBoxColumn.Name = "ingresoDataGridViewTextBoxColumn";
            ingresoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registroDePagoBindingSource
            // 
            registroDePagoBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesSecundarias.RegistroDePago);
            // 
            // ExportarPDFBtn
            // 
            ExportarPDFBtn.AutoSize = true;
            ExportarPDFBtn.BackColor = Color.Goldenrod;
            ExportarPDFBtn.FlatStyle = FlatStyle.Flat;
            ExportarPDFBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExportarPDFBtn.Location = new Point(314, 365);
            ExportarPDFBtn.Name = "ExportarPDFBtn";
            ExportarPDFBtn.Size = new Size(144, 33);
            ExportarPDFBtn.TabIndex = 51;
            ExportarPDFBtn.Text = "Exportar PDF";
            ExportarPDFBtn.UseVisualStyleBackColor = false;
            ExportarPDFBtn.Click += ExportarPDFBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(6, 379);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 50;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(721, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(299, 99);
            lbl.Name = "lbl";
            lbl.Size = new Size(137, 29);
            lbl.TabIndex = 48;
            lbl.Text = "REPORTE";
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(278, 39);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 47;
            SysacadLbl.Text = "SYSACAD";
            // 
            // FormReporteIngresosConceptoPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fechaPopularLabel);
            Controls.Add(mediaPorDiaLabel);
            Controls.Add(inscripcionesTotalesLabel);
            Controls.Add(hastaLabel);
            Controls.Add(desdeLabel);
            Controls.Add(registrosDePagoDGV);
            Controls.Add(ExportarPDFBtn);
            Controls.Add(backBtn);
            Controls.Add(pictureBox1);
            Controls.Add(lbl);
            Controls.Add(SysacadLbl);
            Name = "FormReporteIngresosConceptoPago";
            Text = "FormReporteIngresosConceptoPago";
            ((System.ComponentModel.ISupportInitialize)registrosDePagoDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)registroDePagoBindingSource).EndInit();
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
        private DataGridView registrosDePagoDGV;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn conceptoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn legajoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreEstudianteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ingresoDataGridViewTextBoxColumn;
        private BindingSource registroDePagoBindingSource;
        private Button ExportarPDFBtn;
        private Button backBtn;
        private PictureBox pictureBox1;
        private Label lbl;
        private Label SysacadLbl;
    }
}