namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    partial class FormParamCursoEspecifico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParamCursoEspecifico));
            pictureBox1 = new PictureBox();
            backBtn = new Button();
            cursoBindingSource = new BindingSource(components);
            panelLbl = new Label();
            SysacadLbl = new Label();
            generarReporteBtn = new Button();
            estudianteBindingSource = new BindingSource(components);
            cursosDGV = new DataGridView();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cupoMaximoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cupoDisponibleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            turnoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carreraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creditosRequeridosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            promedioRequeridoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoFamiliaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            listaDeEsperaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cursoBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estudianteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(757, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(4, 335);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 30;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // cursoBindingSource
            // 
            cursoBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesPrimarias.Curso);
            // 
            // panelLbl
            // 
            panelLbl.AutoSize = true;
            panelLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            panelLbl.Location = new Point(313, 71);
            panelLbl.Name = "panelLbl";
            panelLbl.Size = new Size(199, 25);
            panelLbl.TabIndex = 25;
            panelLbl.Text = "ELIJA UN CURSO";
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(317, 10);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 24;
            SysacadLbl.Text = "SYSACAD";
            // 
            // generarReporteBtn
            // 
            generarReporteBtn.AutoSize = true;
            generarReporteBtn.BackColor = Color.Goldenrod;
            generarReporteBtn.FlatStyle = FlatStyle.Flat;
            generarReporteBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            generarReporteBtn.Location = new Point(348, 259);
            generarReporteBtn.Name = "generarReporteBtn";
            generarReporteBtn.Size = new Size(144, 33);
            generarReporteBtn.TabIndex = 27;
            generarReporteBtn.Text = "Generar Reporte";
            generarReporteBtn.UseVisualStyleBackColor = false;
            generarReporteBtn.Click += generarReporteBtn_Click;
            // 
            // estudianteBindingSource
            // 
            estudianteBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesPrimarias.Estudiante);
            // 
            // cursosDGV
            // 
            cursosDGV.AutoGenerateColumns = false;
            cursosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cursosDGV.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, cupoMaximoDataGridViewTextBoxColumn, cupoDisponibleDataGridViewTextBoxColumn, turnoDataGridViewTextBoxColumn, aulaDataGridViewTextBoxColumn, diaDataGridViewTextBoxColumn, carreraDataGridViewTextBoxColumn, creditosRequeridosDataGridViewTextBoxColumn, promedioRequeridoDataGridViewTextBoxColumn, codigoFamiliaDataGridViewTextBoxColumn, listaDeEsperaDataGridViewTextBoxColumn });
            cursosDGV.DataSource = cursoBindingSource1;
            cursosDGV.Location = new Point(22, 103);
            cursosDGV.Name = "cursosDGV";
            cursosDGV.RowTemplate.Height = 25;
            cursosDGV.Size = new Size(782, 150);
            cursosDGV.TabIndex = 32;
            cursosDGV.CellClick += cursosDGV_CellClick_1;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cupoMaximoDataGridViewTextBoxColumn
            // 
            cupoMaximoDataGridViewTextBoxColumn.DataPropertyName = "CupoMaximo";
            cupoMaximoDataGridViewTextBoxColumn.HeaderText = "CupoMaximo";
            cupoMaximoDataGridViewTextBoxColumn.Name = "cupoMaximoDataGridViewTextBoxColumn";
            cupoMaximoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cupoDisponibleDataGridViewTextBoxColumn
            // 
            cupoDisponibleDataGridViewTextBoxColumn.DataPropertyName = "CupoDisponible";
            cupoDisponibleDataGridViewTextBoxColumn.HeaderText = "CupoDisponible";
            cupoDisponibleDataGridViewTextBoxColumn.Name = "cupoDisponibleDataGridViewTextBoxColumn";
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            turnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aulaDataGridViewTextBoxColumn
            // 
            aulaDataGridViewTextBoxColumn.DataPropertyName = "Aula";
            aulaDataGridViewTextBoxColumn.HeaderText = "Aula";
            aulaDataGridViewTextBoxColumn.Name = "aulaDataGridViewTextBoxColumn";
            aulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaDataGridViewTextBoxColumn
            // 
            diaDataGridViewTextBoxColumn.DataPropertyName = "Dia";
            diaDataGridViewTextBoxColumn.HeaderText = "Dia";
            diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            diaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carreraDataGridViewTextBoxColumn
            // 
            carreraDataGridViewTextBoxColumn.DataPropertyName = "Carrera";
            carreraDataGridViewTextBoxColumn.HeaderText = "Carrera";
            carreraDataGridViewTextBoxColumn.Name = "carreraDataGridViewTextBoxColumn";
            carreraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creditosRequeridosDataGridViewTextBoxColumn
            // 
            creditosRequeridosDataGridViewTextBoxColumn.DataPropertyName = "CreditosRequeridos";
            creditosRequeridosDataGridViewTextBoxColumn.HeaderText = "CreditosRequeridos";
            creditosRequeridosDataGridViewTextBoxColumn.Name = "creditosRequeridosDataGridViewTextBoxColumn";
            // 
            // promedioRequeridoDataGridViewTextBoxColumn
            // 
            promedioRequeridoDataGridViewTextBoxColumn.DataPropertyName = "PromedioRequerido";
            promedioRequeridoDataGridViewTextBoxColumn.HeaderText = "PromedioRequerido";
            promedioRequeridoDataGridViewTextBoxColumn.Name = "promedioRequeridoDataGridViewTextBoxColumn";
            // 
            // codigoFamiliaDataGridViewTextBoxColumn
            // 
            codigoFamiliaDataGridViewTextBoxColumn.DataPropertyName = "CodigoFamilia";
            codigoFamiliaDataGridViewTextBoxColumn.HeaderText = "CodigoFamilia";
            codigoFamiliaDataGridViewTextBoxColumn.Name = "codigoFamiliaDataGridViewTextBoxColumn";
            codigoFamiliaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listaDeEsperaDataGridViewTextBoxColumn
            // 
            listaDeEsperaDataGridViewTextBoxColumn.DataPropertyName = "ListaDeEspera";
            listaDeEsperaDataGridViewTextBoxColumn.HeaderText = "ListaDeEspera";
            listaDeEsperaDataGridViewTextBoxColumn.Name = "listaDeEsperaDataGridViewTextBoxColumn";
            listaDeEsperaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cursoBindingSource1
            // 
            cursoBindingSource1.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesPrimarias.Curso);
            // 
            // FormParamCursoEspecifico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 377);
            Controls.Add(cursosDGV);
            Controls.Add(pictureBox1);
            Controls.Add(backBtn);
            Controls.Add(generarReporteBtn);
            Controls.Add(panelLbl);
            Controls.Add(SysacadLbl);
            Name = "FormParamCursoEspecifico";
            Text = "FormParamCursoEspecifico";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)estudianteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button backBtn;
        private BindingSource cursoBindingSource;
        private Label panelLbl;
        private Label SysacadLbl;
        private Button generarReporteBtn;
        private BindingSource estudianteBindingSource;
        private DataGridView cursosDGV;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cupoMaximoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cupoDisponibleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carreraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creditosRequeridosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn promedioRequeridoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoFamiliaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn listaDeEsperaDataGridViewTextBoxColumn;
        private BindingSource cursoBindingSource1;
    }
}