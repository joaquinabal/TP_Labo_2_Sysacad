namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    partial class FormAgregarEstudianteAListaDeEspera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarEstudianteAListaDeEspera));
            pictureBox1 = new PictureBox();
            backBtn = new Button();
            agregarEstBtn = new Button();
            estudiantesDGV = new DataGridView();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            legajoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creditosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            promedioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estudianteBindingSource = new BindingSource(components);
            estListaLbl = new Label();
            SysacadLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estudiantesDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estudianteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(757, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(2, 302);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 49;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // agregarEstBtn
            // 
            agregarEstBtn.AutoSize = true;
            agregarEstBtn.BackColor = Color.Goldenrod;
            agregarEstBtn.FlatStyle = FlatStyle.Flat;
            agregarEstBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            agregarEstBtn.Location = new Point(336, 275);
            agregarEstBtn.Name = "agregarEstBtn";
            agregarEstBtn.Size = new Size(162, 33);
            agregarEstBtn.TabIndex = 48;
            agregarEstBtn.Text = "Agregar Estudiante";
            agregarEstBtn.UseVisualStyleBackColor = false;
            agregarEstBtn.Click += agregarEstBtn_Click;
            // 
            // estudiantesDGV
            // 
            estudiantesDGV.AllowUserToAddRows = false;
            estudiantesDGV.AllowUserToDeleteRows = false;
            estudiantesDGV.AutoGenerateColumns = false;
            estudiantesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            estudiantesDGV.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, legajoDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn, creditosDataGridViewTextBoxColumn, promedioDataGridViewTextBoxColumn });
            estudiantesDGV.DataSource = estudianteBindingSource;
            estudiantesDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            estudiantesDGV.Location = new Point(12, 103);
            estudiantesDGV.Name = "estudiantesDGV";
            estudiantesDGV.ReadOnly = true;
            estudiantesDGV.RowHeadersWidth = 5;
            estudiantesDGV.RowTemplate.Height = 25;
            estudiantesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            estudiantesDGV.Size = new Size(808, 150);
            estudiantesDGV.TabIndex = 47;
            estudiantesDGV.CellClick += estudiantesDGV_CellClick_1;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // legajoDataGridViewTextBoxColumn
            // 
            legajoDataGridViewTextBoxColumn.DataPropertyName = "Legajo";
            legajoDataGridViewTextBoxColumn.HeaderText = "Legajo";
            legajoDataGridViewTextBoxColumn.Name = "legajoDataGridViewTextBoxColumn";
            legajoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creditosDataGridViewTextBoxColumn
            // 
            creditosDataGridViewTextBoxColumn.DataPropertyName = "Creditos";
            creditosDataGridViewTextBoxColumn.HeaderText = "Creditos";
            creditosDataGridViewTextBoxColumn.Name = "creditosDataGridViewTextBoxColumn";
            creditosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // promedioDataGridViewTextBoxColumn
            // 
            promedioDataGridViewTextBoxColumn.DataPropertyName = "Promedio";
            promedioDataGridViewTextBoxColumn.HeaderText = "Promedio";
            promedioDataGridViewTextBoxColumn.Name = "promedioDataGridViewTextBoxColumn";
            promedioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estudianteBindingSource
            // 
            estudianteBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesPrimarias.Estudiante);
            // 
            // estListaLbl
            // 
            estListaLbl.AutoSize = true;
            estListaLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            estListaLbl.Location = new Point(228, 58);
            estListaLbl.Name = "estListaLbl";
            estListaLbl.Size = new Size(413, 25);
            estListaLbl.TabIndex = 46;
            estListaLbl.Text = "ESTUDIANTES EN LISTA DE ESPERA";
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(317, 10);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 45;
            SysacadLbl.Text = "SYSACAD";
            // 
            // FormAgregarEstudianteAListaDeEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 343);
            Controls.Add(pictureBox1);
            Controls.Add(backBtn);
            Controls.Add(agregarEstBtn);
            Controls.Add(estudiantesDGV);
            Controls.Add(estListaLbl);
            Controls.Add(SysacadLbl);
            Name = "FormAgregarEstudianteAListaDeEspera";
            Text = "FormAgregarEstudianteAListaDeEspera";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)estudiantesDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)estudianteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button backBtn;
        private Button agregarEstBtn;
        private DataGridView estudiantesDGV;
        private BindingSource estudianteBindingSource;
        private Label estListaLbl;
        private Label SysacadLbl;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn legajoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creditosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn promedioDataGridViewTextBoxColumn;
    }
}