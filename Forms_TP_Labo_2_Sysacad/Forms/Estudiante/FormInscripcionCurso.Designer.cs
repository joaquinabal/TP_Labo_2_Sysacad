namespace Forms_TP_Labo_2_Sysacad
{
    partial class FormInscripcionCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscripcionCurso));
            backBtn = new Button();
            cursosDGV = new DataGridView();
            consultasCursosBindingSource = new BindingSource(components);
            cursosBindingSource = new BindingSource(components);
            baseDatosCursosBindingSource = new BindingSource(components);
            panelLbl = new Label();
            SysacadLbl = new Label();
            inscribirseBtn = new Button();
            pictureBox1 = new PictureBox();
            cursoBindingSource = new BindingSource(components);
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            carreraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creditosRequeridosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            promedioRequeridoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoFamiliaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            listaDeEsperaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)cursosDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)consultasCursosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baseDatosCursosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(8, 334);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 33;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // cursosDGV
            // 
            cursosDGV.AllowUserToAddRows = false;
            cursosDGV.AllowUserToDeleteRows = false;
            cursosDGV.AutoGenerateColumns = false;
            cursosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cursosDGV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, carreraDataGridViewTextBoxColumn, creditosRequeridosDataGridViewTextBoxColumn, promedioRequeridoDataGridViewTextBoxColumn, codigoFamiliaDataGridViewTextBoxColumn, listaDeEsperaDataGridViewTextBoxColumn });
            cursosDGV.DataSource = cursoBindingSource;
            cursosDGV.Location = new Point(12, 116);
            cursosDGV.Name = "cursosDGV";
            cursosDGV.ReadOnly = true;
            cursosDGV.RowTemplate.Height = 25;
            cursosDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cursosDGV.Size = new Size(844, 150);
            cursosDGV.TabIndex = 31;
            cursosDGV.CellClick += cursosDGV_CellClick;
            // 
            // consultasCursosBindingSource
            // 
            consultasCursosBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.BaseDeDatos.ConsultasCursos);
            // 
            // cursosBindingSource
            // 
            cursosBindingSource.DataMember = "Cursos";
            cursosBindingSource.DataSource = baseDatosCursosBindingSource;
            // 
            // baseDatosCursosBindingSource
            // 
            baseDatosCursosBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesPrimarias.Curso);
            // 
            // panelLbl
            // 
            panelLbl.AutoSize = true;
            panelLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            panelLbl.Location = new Point(261, 67);
            panelLbl.Name = "panelLbl";
            panelLbl.Size = new Size(388, 25);
            panelLbl.TabIndex = 30;
            panelLbl.Text = "INSCRIBIRSE A UN NUEVO CURSO";
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(332, 9);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 29;
            SysacadLbl.Text = "SYSACAD";
            // 
            // inscribirseBtn
            // 
            inscribirseBtn.BackColor = Color.Goldenrod;
            inscribirseBtn.FlatStyle = FlatStyle.Flat;
            inscribirseBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            inscribirseBtn.Location = new Point(382, 282);
            inscribirseBtn.Name = "inscribirseBtn";
            inscribirseBtn.Size = new Size(112, 33);
            inscribirseBtn.TabIndex = 34;
            inscribirseBtn.Text = "Inscribirse";
            inscribirseBtn.UseVisualStyleBackColor = false;
            inscribirseBtn.Click += inscribirseBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(797, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            // 
            // cursoBindingSource
            // 
            cursoBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesPrimarias.Curso);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Codigo";
            dataGridViewTextBoxColumn2.HeaderText = "Codigo";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "CupoMaximo";
            dataGridViewTextBoxColumn4.HeaderText = "CupoMaximo";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "CupoDisponible";
            dataGridViewTextBoxColumn5.HeaderText = "CupoDisponible";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Turno";
            dataGridViewTextBoxColumn6.HeaderText = "Turno";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Aula";
            dataGridViewTextBoxColumn7.HeaderText = "Aula";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Dia";
            dataGridViewTextBoxColumn8.HeaderText = "Dia";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
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
            // FormInscripcionCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 376);
            Controls.Add(pictureBox1);
            Controls.Add(inscribirseBtn);
            Controls.Add(backBtn);
            Controls.Add(cursosDGV);
            Controls.Add(panelLbl);
            Controls.Add(SysacadLbl);
            Name = "FormInscripcionCurso";
            Text = "";
            Load += FormInscripcionCurso_Load;
            ((System.ComponentModel.ISupportInitialize)cursosDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)consultasCursosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private DataGridView cursosDGV;
        private BindingSource baseDatosCursosBindingSource;
        private Label panelLbl;
        private Label SysacadLbl;
        private Button inscribirseBtn;
        private BindingSource cursosBindingSource;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cupoMaximoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cupoDisponibleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private PictureBox pictureBox1;
        private BindingSource consultasCursosBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn carreraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creditosRequeridosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn promedioRequeridoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoFamiliaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn listaDeEsperaDataGridViewTextBoxColumn;
        private BindingSource cursoBindingSource;
    }
}