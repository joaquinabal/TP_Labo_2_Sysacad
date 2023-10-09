namespace Forms_TP_Labo_2_Sysacad
{
    partial class FormPanelAdmCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanelAdmCursos));
            cursosDGV = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            turnoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cursosBindingSource = new BindingSource(components);
            baseDatosCursosBindingSource = new BindingSource(components);
            SysacadLbl = new Label();
            panelLbl = new Label();
            agregarCursoBtn = new Button();
            editarCursoBtn = new Button();
            eliminarCursoBtn = new Button();
            backBtn = new Button();
            cursosBindingSource1 = new BindingSource(components);
            cursosBindingSource2 = new BindingSource(components);
            cursosBindingSource3 = new BindingSource(components);
            baseDatosCursosBindingSource1 = new BindingSource(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cursosDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baseDatosCursosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baseDatosCursosBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cursosDGV
            // 
            cursosDGV.AllowUserToAddRows = false;
            cursosDGV.AllowUserToDeleteRows = false;
            cursosDGV.AutoGenerateColumns = false;
            cursosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cursosDGV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, turnoDataGridViewTextBoxColumn, aulaDataGridViewTextBoxColumn, diaDataGridViewTextBoxColumn });
            cursosDGV.DataSource = cursosBindingSource;
            cursosDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            cursosDGV.Location = new Point(12, 102);
            cursosDGV.Name = "cursosDGV";
            cursosDGV.ReadOnly = true;
            cursosDGV.RowHeadersWidth = 5;
            cursosDGV.RowTemplate.Height = 25;
            cursosDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cursosDGV.Size = new Size(808, 150);
            cursosDGV.TabIndex = 17;
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
            // cursosBindingSource
            // 
            cursosBindingSource.DataMember = "Cursos";
            cursosBindingSource.DataSource = baseDatosCursosBindingSource;
            // 
            // baseDatosCursosBindingSource
            // 
            baseDatosCursosBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.BaseDatosCursos);
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(317, 9);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 1;
            SysacadLbl.Text = "SYSACAD";
            // 
            // panelLbl
            // 
            panelLbl.AutoSize = true;
            panelLbl.Font = new Font("Lucida Sans", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            panelLbl.Location = new Point(313, 70);
            panelLbl.Name = "panelLbl";
            panelLbl.Size = new Size(211, 23);
            panelLbl.TabIndex = 16;
            panelLbl.Text = "PANEL DE CURSOS";
            // 
            // agregarCursoBtn
            // 
            agregarCursoBtn.AutoSize = true;
            agregarCursoBtn.BackColor = Color.Goldenrod;
            agregarCursoBtn.FlatStyle = FlatStyle.Flat;
            agregarCursoBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            agregarCursoBtn.Location = new Point(139, 259);
            agregarCursoBtn.Name = "agregarCursoBtn";
            agregarCursoBtn.Size = new Size(128, 33);
            agregarCursoBtn.TabIndex = 18;
            agregarCursoBtn.Text = "Agregar Curso";
            agregarCursoBtn.UseVisualStyleBackColor = false;
            agregarCursoBtn.Click += agregarCursoBtn_Click;
            // 
            // editarCursoBtn
            // 
            editarCursoBtn.AutoSize = true;
            editarCursoBtn.BackColor = Color.Goldenrod;
            editarCursoBtn.FlatStyle = FlatStyle.Flat;
            editarCursoBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editarCursoBtn.Location = new Point(347, 259);
            editarCursoBtn.Name = "editarCursoBtn";
            editarCursoBtn.Size = new Size(126, 33);
            editarCursoBtn.TabIndex = 19;
            editarCursoBtn.Text = "Editar Curso";
            editarCursoBtn.UseVisualStyleBackColor = false;
            editarCursoBtn.Click += editarCursoBtn_Click;
            // 
            // eliminarCursoBtn
            // 
            eliminarCursoBtn.AutoSize = true;
            eliminarCursoBtn.BackColor = Color.Goldenrod;
            eliminarCursoBtn.FlatStyle = FlatStyle.Flat;
            eliminarCursoBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            eliminarCursoBtn.Location = new Point(554, 259);
            eliminarCursoBtn.Name = "eliminarCursoBtn";
            eliminarCursoBtn.Size = new Size(126, 33);
            eliminarCursoBtn.TabIndex = 20;
            eliminarCursoBtn.Text = "Eliminar Curso";
            eliminarCursoBtn.UseVisualStyleBackColor = false;
            eliminarCursoBtn.Click += eliminarCursoBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(4, 334);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 21;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click_1;
            // 
            // cursosBindingSource1
            // 
            cursosBindingSource1.DataMember = "Cursos";
            cursosBindingSource1.DataSource = baseDatosCursosBindingSource;
            // 
            // cursosBindingSource2
            // 
            cursosBindingSource2.DataMember = "Cursos";
            cursosBindingSource2.DataSource = baseDatosCursosBindingSource;
            // 
            // cursosBindingSource3
            // 
            cursosBindingSource3.DataMember = "Cursos";
            cursosBindingSource3.DataSource = baseDatosCursosBindingSource;
            // 
            // baseDatosCursosBindingSource1
            // 
            baseDatosCursosBindingSource1.DataSource = typeof(Libreria_Clases_TP_SYSACAD.BaseDatosCursos);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(757, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // FormPanelAdmCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 375);
            Controls.Add(pictureBox1);
            Controls.Add(backBtn);
            Controls.Add(eliminarCursoBtn);
            Controls.Add(editarCursoBtn);
            Controls.Add(agregarCursoBtn);
            Controls.Add(cursosDGV);
            Controls.Add(panelLbl);
            Controls.Add(SysacadLbl);
            Name = "FormPanelAdmCursos";
            Text = "";
            ((System.ComponentModel.ISupportInitialize)cursosDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)baseDatosCursosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)baseDatosCursosBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SysacadLbl;
        private Label panelLbl;
        private BindingSource baseDatosCursosBindingSource;
        private Button agregarCursoBtn;
        private Button editarCursoBtn;
        private Button eliminarCursoBtn;
        private Button backBtn;
        private BindingSource cursosBindingSource;
        private BindingSource cursosBindingSource1;
        private BindingSource cursosBindingSource2;
        private BindingSource cursosBindingSource3;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn cupoMaximo;
        private DataGridViewTextBoxColumn cupoDisponible;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cupoMaximoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cupoDisponibleDataGridViewTextBoxColumn;
        private DataGridView cursosDGV;
        private DataGridViewTextBoxColumn cupoMaximoDataDGV;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private BindingSource baseDatosCursosBindingSource1;
        private PictureBox pictureBox1;
    }
}