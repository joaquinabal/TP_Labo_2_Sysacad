namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    partial class FormPanelAdmProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanelAdmProf));
            pictureBox1 = new PictureBox();
            backBtn = new Button();
            eliminarCursoBtn = new Button();
            editarProfBtn = new Button();
            agregarProfBtn = new Button();
            profDGV = new DataGridView();
            profesorBindingSource = new BindingSource(components);
            panelLbl = new Label();
            SysacadLbl = new Label();
            gestCursosBtn = new Button();
            codigosCursosDeProfesorBindingSource = new BindingSource(components);
            codigosCursosDeProfesorBindingSource1 = new BindingSource(components);
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            especializacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profesorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)codigosCursosDeProfesorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)codigosCursosDeProfesorBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(752, 5);
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
            backBtn.Location = new Point(4, 339);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 30;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // eliminarCursoBtn
            // 
            eliminarCursoBtn.AutoSize = true;
            eliminarCursoBtn.BackColor = Color.Goldenrod;
            eliminarCursoBtn.FlatStyle = FlatStyle.Flat;
            eliminarCursoBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            eliminarCursoBtn.Location = new Point(329, 263);
            eliminarCursoBtn.Name = "eliminarCursoBtn";
            eliminarCursoBtn.Size = new Size(146, 33);
            eliminarCursoBtn.TabIndex = 29;
            eliminarCursoBtn.Text = "Eliminar Profesor";
            eliminarCursoBtn.UseVisualStyleBackColor = false;
            eliminarCursoBtn.Click += eliminarCursoBtn_Click;
            // 
            // editarProfBtn
            // 
            editarProfBtn.AutoSize = true;
            editarProfBtn.BackColor = Color.Goldenrod;
            editarProfBtn.FlatStyle = FlatStyle.Flat;
            editarProfBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editarProfBtn.Location = new Point(180, 263);
            editarProfBtn.Name = "editarProfBtn";
            editarProfBtn.Size = new Size(131, 33);
            editarProfBtn.TabIndex = 28;
            editarProfBtn.Text = "Editar Profesor";
            editarProfBtn.UseVisualStyleBackColor = false;
            editarProfBtn.Click += editarProfBtn_Click;
            // 
            // agregarProfBtn
            // 
            agregarProfBtn.AutoSize = true;
            agregarProfBtn.BackColor = Color.Goldenrod;
            agregarProfBtn.FlatStyle = FlatStyle.Flat;
            agregarProfBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            agregarProfBtn.Location = new Point(12, 263);
            agregarProfBtn.Name = "agregarProfBtn";
            agregarProfBtn.Size = new Size(149, 33);
            agregarProfBtn.TabIndex = 27;
            agregarProfBtn.Text = "Agregar Profesor";
            agregarProfBtn.UseVisualStyleBackColor = false;
            agregarProfBtn.Click += agregarProfBtn_Click;
            // 
            // profDGV
            // 
            profDGV.AllowUserToAddRows = false;
            profDGV.AllowUserToDeleteRows = false;
            profDGV.AutoGenerateColumns = false;
            profDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            profDGV.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn, especializacionDataGridViewTextBoxColumn });
            profDGV.DataSource = profesorBindingSource;
            profDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            profDGV.Location = new Point(12, 107);
            profDGV.Name = "profDGV";
            profDGV.ReadOnly = true;
            profDGV.RowHeadersWidth = 5;
            profDGV.RowTemplate.Height = 25;
            profDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            profDGV.Size = new Size(808, 150);
            profDGV.TabIndex = 26;
            profDGV.CellClick += profDGV_CellClick;
            // 
            // profesorBindingSource
            // 
            profesorBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.Entidades_Primarias.Profesor);
            // 
            // panelLbl
            // 
            panelLbl.AutoSize = true;
            panelLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            panelLbl.Location = new Point(274, 79);
            panelLbl.Name = "panelLbl";
            panelLbl.Size = new Size(286, 25);
            panelLbl.TabIndex = 25;
            panelLbl.Text = "PANEL DE PROFESORES";
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(317, 14);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 24;
            SysacadLbl.Text = "SYSACAD";
            // 
            // gestCursosBtn
            // 
            gestCursosBtn.AutoSize = true;
            gestCursosBtn.BackColor = Color.Goldenrod;
            gestCursosBtn.FlatStyle = FlatStyle.Flat;
            gestCursosBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gestCursosBtn.Location = new Point(587, 263);
            gestCursosBtn.Name = "gestCursosBtn";
            gestCursosBtn.Size = new Size(234, 33);
            gestCursosBtn.TabIndex = 32;
            gestCursosBtn.Text = "Gestionar Cursos en Profesor";
            gestCursosBtn.UseVisualStyleBackColor = false;
            gestCursosBtn.Click += gestCursosBtn_Click_1;
            // 
            // codigosCursosDeProfesorBindingSource
            // 
            codigosCursosDeProfesorBindingSource.DataMember = "CodigosCursosDeProfesor";
            codigosCursosDeProfesorBindingSource.DataSource = profesorBindingSource;
            // 
            // codigosCursosDeProfesorBindingSource1
            // 
            codigosCursosDeProfesorBindingSource1.DataMember = "CodigosCursosDeProfesor";
            codigosCursosDeProfesorBindingSource1.DataSource = profesorBindingSource;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // especializacionDataGridViewTextBoxColumn
            // 
            especializacionDataGridViewTextBoxColumn.DataPropertyName = "Especializacion";
            especializacionDataGridViewTextBoxColumn.HeaderText = "Especializacion";
            especializacionDataGridViewTextBoxColumn.Name = "especializacionDataGridViewTextBoxColumn";
            especializacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormPanelAdmProf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 381);
            Controls.Add(gestCursosBtn);
            Controls.Add(pictureBox1);
            Controls.Add(backBtn);
            Controls.Add(eliminarCursoBtn);
            Controls.Add(editarProfBtn);
            Controls.Add(agregarProfBtn);
            Controls.Add(profDGV);
            Controls.Add(panelLbl);
            Controls.Add(SysacadLbl);
            Name = "FormPanelAdmProf";
            Load += FormPanelAdmProf_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)profDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)profesorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)codigosCursosDeProfesorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)codigosCursosDeProfesorBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button backBtn;
        private Button eliminarCursoBtn;
        private Button editarProfBtn;
        private Button agregarProfBtn;
        private DataGridView profDGV;
        private BindingSource profesorBindingSource;
        private Label panelLbl;
        private Label SysacadLbl;
        private Button gestCursosBtn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn especializacionDataGridViewTextBoxColumn;
        private BindingSource codigosCursosDeProfesorBindingSource;
        private BindingSource codigosCursosDeProfesorBindingSource1;
    }
}