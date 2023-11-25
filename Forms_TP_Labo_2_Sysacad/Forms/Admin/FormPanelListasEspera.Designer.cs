namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    partial class FormPanelListasEspera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanelListasEspera));
            pictureBox1 = new PictureBox();
            backBtn = new Button();
            asignarCursoBtn = new Button();
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
            cursoBindingSource = new BindingSource(components);
            cursoLbl = new Label();
            SysacadLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(763, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(8, 301);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 36;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // asignarCursoBtn
            // 
            asignarCursoBtn.AutoSize = true;
            asignarCursoBtn.BackColor = Color.Goldenrod;
            asignarCursoBtn.FlatStyle = FlatStyle.Flat;
            asignarCursoBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            asignarCursoBtn.Location = new Point(353, 259);
            asignarCursoBtn.Name = "asignarCursoBtn";
            asignarCursoBtn.Size = new Size(158, 33);
            asignarCursoBtn.TabIndex = 35;
            asignarCursoBtn.Text = "Ver Lista de Espera";
            asignarCursoBtn.UseVisualStyleBackColor = false;
            asignarCursoBtn.Click += VerListaEsperaBtn_Click;
            // 
            // cursosDGV
            // 
            cursosDGV.AllowUserToAddRows = false;
            cursosDGV.AllowUserToDeleteRows = false;
            cursosDGV.AutoGenerateColumns = false;
            cursosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cursosDGV.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, cupoMaximoDataGridViewTextBoxColumn, cupoDisponibleDataGridViewTextBoxColumn, turnoDataGridViewTextBoxColumn, aulaDataGridViewTextBoxColumn, diaDataGridViewTextBoxColumn, carreraDataGridViewTextBoxColumn, creditosRequeridosDataGridViewTextBoxColumn, promedioRequeridoDataGridViewTextBoxColumn, codigoFamiliaDataGridViewTextBoxColumn, listaDeEsperaDataGridViewTextBoxColumn });
            cursosDGV.DataSource = cursoBindingSource;
            cursosDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            cursosDGV.Location = new Point(18, 102);
            cursosDGV.Name = "cursosDGV";
            cursosDGV.ReadOnly = true;
            cursosDGV.RowHeadersWidth = 5;
            cursosDGV.RowTemplate.Height = 25;
            cursosDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cursosDGV.Size = new Size(808, 150);
            cursosDGV.TabIndex = 34;
            cursosDGV.CellClick += cursosDGV_CellClick;
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
            cupoDisponibleDataGridViewTextBoxColumn.ReadOnly = true;
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
            creditosRequeridosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // promedioRequeridoDataGridViewTextBoxColumn
            // 
            promedioRequeridoDataGridViewTextBoxColumn.DataPropertyName = "PromedioRequerido";
            promedioRequeridoDataGridViewTextBoxColumn.HeaderText = "PromedioRequerido";
            promedioRequeridoDataGridViewTextBoxColumn.Name = "promedioRequeridoDataGridViewTextBoxColumn";
            promedioRequeridoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cursoBindingSource
            // 
            cursoBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesPrimarias.Curso);
            // 
            // cursoLbl
            // 
            cursoLbl.AutoSize = true;
            cursoLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            cursoLbl.Location = new Point(234, 57);
            cursoLbl.Name = "cursoLbl";
            cursoLbl.Size = new Size(382, 25);
            cursoLbl.TabIndex = 33;
            cursoLbl.Text = "CURSOS CON CUPOS AGOTADOS";
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(323, 9);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 32;
            SysacadLbl.Text = "SYSACAD";
            // 
            // FormPanelListasEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 343);
            Controls.Add(pictureBox1);
            Controls.Add(backBtn);
            Controls.Add(asignarCursoBtn);
            Controls.Add(cursosDGV);
            Controls.Add(cursoLbl);
            Controls.Add(SysacadLbl);
            Name = "FormPanelListasEspera";
            Text = "FormPanelListasEspera";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button backBtn;
        private Button asignarCursoBtn;
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
        private BindingSource cursoBindingSource;
        private Label cursoLbl;
        private Label SysacadLbl;
    }
}