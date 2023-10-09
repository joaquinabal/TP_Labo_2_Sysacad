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
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cupoMaximoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cupoDisponibleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            turnoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cursosBindingSource = new BindingSource(components);
            baseDatosCursosBindingSource = new BindingSource(components);
            panelLbl = new Label();
            SysacadLbl = new Label();
            inscribirseBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cursosDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baseDatosCursosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            cursosDGV.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, cupoMaximoDataGridViewTextBoxColumn, cupoDisponibleDataGridViewTextBoxColumn, turnoDataGridViewTextBoxColumn, aulaDataGridViewTextBoxColumn, diaDataGridViewTextBoxColumn });
            cursosDGV.DataSource = cursosBindingSource;
            cursosDGV.Location = new Point(12, 116);
            cursosDGV.Name = "cursosDGV";
            cursosDGV.ReadOnly = true;
            cursosDGV.RowTemplate.Height = 25;
            cursosDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cursosDGV.Size = new Size(844, 150);
            cursosDGV.TabIndex = 31;
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
            // cursosBindingSource
            // 
            cursosBindingSource.DataMember = "Cursos";
            cursosBindingSource.DataSource = baseDatosCursosBindingSource;
            // 
            // baseDatosCursosBindingSource
            // 
            baseDatosCursosBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.BaseDatosCursos);
            // 
            // panelLbl
            // 
            panelLbl.AutoSize = true;
            panelLbl.Font = new Font("Lucida Sans", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            panelLbl.Location = new Point(261, 67);
            panelLbl.Name = "panelLbl";
            panelLbl.Size = new Size(371, 23);
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
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)baseDatosCursosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}