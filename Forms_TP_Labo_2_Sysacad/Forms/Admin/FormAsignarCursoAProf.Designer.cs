namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    partial class FormAsignarCursoAProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsignarCursoAProf));
            pictureBox1 = new PictureBox();
            backBtn = new Button();
            asignarCursoBtn = new Button();
            cursosAsignadosDGV = new DataGridView();
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
            asignarCursoLbl = new Label();
            SysacadLbl = new Label();
            cursosDGV = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosAsignadosDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosDGV).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(760, 6);
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
            backBtn.Location = new Point(7, 429);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 30;
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
            asignarCursoBtn.Location = new Point(371, 405);
            asignarCursoBtn.Name = "asignarCursoBtn";
            asignarCursoBtn.Size = new Size(127, 33);
            asignarCursoBtn.TabIndex = 28;
            asignarCursoBtn.Text = "Asignar Curso";
            asignarCursoBtn.UseVisualStyleBackColor = false;
            asignarCursoBtn.Click += asignarCursoBtn_Click;
            // 
            // cursosAsignadosDGV
            // 
            cursosAsignadosDGV.AllowUserToAddRows = false;
            cursosAsignadosDGV.AllowUserToDeleteRows = false;
            cursosAsignadosDGV.AutoGenerateColumns = false;
            cursosAsignadosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cursosAsignadosDGV.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, cupoMaximoDataGridViewTextBoxColumn, cupoDisponibleDataGridViewTextBoxColumn, turnoDataGridViewTextBoxColumn, aulaDataGridViewTextBoxColumn, diaDataGridViewTextBoxColumn, carreraDataGridViewTextBoxColumn, creditosRequeridosDataGridViewTextBoxColumn, promedioRequeridoDataGridViewTextBoxColumn, codigoFamiliaDataGridViewTextBoxColumn, listaDeEsperaDataGridViewTextBoxColumn });
            cursosAsignadosDGV.DataSource = cursoBindingSource;
            cursosAsignadosDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            cursosAsignadosDGV.Location = new Point(15, 87);
            cursosAsignadosDGV.Name = "cursosAsignadosDGV";
            cursosAsignadosDGV.ReadOnly = true;
            cursosAsignadosDGV.RowHeadersWidth = 5;
            cursosAsignadosDGV.RowTemplate.Height = 25;
            cursosAsignadosDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cursosAsignadosDGV.Size = new Size(808, 114);
            cursosAsignadosDGV.TabIndex = 26;
            cursosAsignadosDGV.CellClick += cursosDGV_CellContentClick;
            cursosAsignadosDGV.CellContentClick += cursosDGV_CellContentClick;
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
            // asignarCursoLbl
            // 
            asignarCursoLbl.AutoSize = true;
            asignarCursoLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            asignarCursoLbl.Location = new Point(299, 53);
            asignarCursoLbl.Name = "asignarCursoLbl";
            asignarCursoLbl.Size = new Size(246, 25);
            asignarCursoLbl.TabIndex = 25;
            asignarCursoLbl.Text = "CURSOS ASIGNADOS";
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(320, 5);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 24;
            SysacadLbl.Text = "SYSACAD";
            // 
            // cursosDGV
            // 
            cursosDGV.AllowUserToAddRows = false;
            cursosDGV.AllowUserToDeleteRows = false;
            cursosDGV.AutoGenerateColumns = false;
            cursosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cursosDGV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13 });
            cursosDGV.DataSource = cursoBindingSource;
            cursosDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            cursosDGV.Location = new Point(15, 249);
            cursosDGV.Name = "cursosDGV";
            cursosDGV.ReadOnly = true;
            cursosDGV.RowHeadersWidth = 5;
            cursosDGV.RowTemplate.Height = 25;
            cursosDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cursosDGV.Size = new Size(808, 150);
            cursosDGV.TabIndex = 33;
            cursosDGV.CellClick += cursosDGV_CellClick;
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
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "Carrera";
            dataGridViewTextBoxColumn9.HeaderText = "Carrera";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "CreditosRequeridos";
            dataGridViewTextBoxColumn10.HeaderText = "CreditosRequeridos";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "PromedioRequerido";
            dataGridViewTextBoxColumn11.HeaderText = "PromedioRequerido";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "CodigoFamilia";
            dataGridViewTextBoxColumn12.HeaderText = "CodigoFamilia";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "ListaDeEspera";
            dataGridViewTextBoxColumn13.HeaderText = "ListaDeEspera";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(315, 221);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
            label1.TabIndex = 34;
            label1.Text = "ASIGNAR CURSOS";
            // 
            // FormAsignarCursoAProf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 468);
            Controls.Add(label1);
            Controls.Add(cursosDGV);
            Controls.Add(pictureBox1);
            Controls.Add(backBtn);
            Controls.Add(asignarCursoBtn);
            Controls.Add(cursosAsignadosDGV);
            Controls.Add(asignarCursoLbl);
            Controls.Add(SysacadLbl);
            Name = "FormAsignarCursoAProf";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosAsignadosDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button backBtn;
        private Button asignarCursoBtn;
        private DataGridView cursosAsignadosDGV;
        private Label asignarCursoLbl;
        private Label SysacadLbl;
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
        private DataGridView cursosDGV;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private Label label1;
    }
}