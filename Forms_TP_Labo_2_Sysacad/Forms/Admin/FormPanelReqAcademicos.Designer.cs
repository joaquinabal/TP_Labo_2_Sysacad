namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    partial class FormPanelReqAcademicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanelReqAcademicos));
            pictureBox1 = new PictureBox();
            backBtn = new Button();
            editarCursoBtn = new Button();
            cursosDGV = new DataGridView();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creditosRequeridosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            promedioRequeridoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CorrelatividadesColumn = new DataGridViewTextBoxColumn();
            cursoBindingSource1 = new BindingSource(components);
            cursoBindingSource = new BindingSource(components);
            panelLbl = new Label();
            SysacadLbl = new Label();
            creditosReqRadioBtn = new RadioButton();
            promedioReqRadioBtn = new RadioButton();
            cursosReqRadioBtn = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(738, 3);
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
            backBtn.Location = new Point(5, 338);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 30;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // editarCursoBtn
            // 
            editarCursoBtn.AutoSize = true;
            editarCursoBtn.BackColor = Color.Goldenrod;
            editarCursoBtn.FlatStyle = FlatStyle.Flat;
            editarCursoBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editarCursoBtn.Location = new Point(349, 315);
            editarCursoBtn.Name = "editarCursoBtn";
            editarCursoBtn.Size = new Size(144, 33);
            editarCursoBtn.TabIndex = 28;
            editarCursoBtn.Text = "Editar Requisito";
            editarCursoBtn.UseVisualStyleBackColor = false;
            editarCursoBtn.Click += editarCursoBtn_Click;
            // 
            // cursosDGV
            // 
            cursosDGV.AllowUserToAddRows = false;
            cursosDGV.AllowUserToDeleteRows = false;
            cursosDGV.AutoGenerateColumns = false;
            cursosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cursosDGV.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, creditosRequeridosDataGridViewTextBoxColumn, promedioRequeridoDataGridViewTextBoxColumn, CorrelatividadesColumn });
            cursosDGV.DataSource = cursoBindingSource1;
            cursosDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            cursosDGV.Location = new Point(13, 106);
            cursosDGV.Name = "cursosDGV";
            cursosDGV.ReadOnly = true;
            cursosDGV.RowHeadersWidth = 5;
            cursosDGV.RowTemplate.Height = 25;
            cursosDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cursosDGV.Size = new Size(788, 150);
            cursosDGV.TabIndex = 26;
            cursosDGV.CellClick += cursosDGV_CellClick;
            cursosDGV.CellFormatting += cursosDGV_CellFormatting;
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
            // CorrelatividadesColumn
            // 
            CorrelatividadesColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CorrelatividadesColumn.HeaderText = "Correlatividades";
            CorrelatividadesColumn.Name = "CorrelatividadesColumn";
            CorrelatividadesColumn.ReadOnly = true;
            CorrelatividadesColumn.Width = 117;
            // 
            // cursoBindingSource1
            // 
            cursoBindingSource1.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesPrimarias.Curso);
            // 
            // cursoBindingSource
            // 
            cursoBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesPrimarias.Curso);
            // 
            // panelLbl
            // 
            panelLbl.AutoSize = true;
            panelLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            panelLbl.Location = new Point(314, 74);
            panelLbl.Name = "panelLbl";
            panelLbl.Size = new Size(226, 25);
            panelLbl.TabIndex = 25;
            panelLbl.Text = "PANEL DE CURSOS";
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(318, 13);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 24;
            SysacadLbl.Text = "SYSACAD";
            // 
            // creditosReqRadioBtn
            // 
            creditosReqRadioBtn.AutoSize = true;
            creditosReqRadioBtn.Location = new Point(144, 271);
            creditosReqRadioBtn.Name = "creditosReqRadioBtn";
            creditosReqRadioBtn.Size = new Size(131, 19);
            creditosReqRadioBtn.TabIndex = 32;
            creditosReqRadioBtn.TabStop = true;
            creditosReqRadioBtn.Text = "Créditos Requeridos";
            creditosReqRadioBtn.UseVisualStyleBackColor = true;
            // 
            // promedioReqRadioBtn
            // 
            promedioReqRadioBtn.AutoSize = true;
            promedioReqRadioBtn.Location = new Point(349, 271);
            promedioReqRadioBtn.Name = "promedioReqRadioBtn";
            promedioReqRadioBtn.Size = new Size(139, 19);
            promedioReqRadioBtn.TabIndex = 33;
            promedioReqRadioBtn.TabStop = true;
            promedioReqRadioBtn.Text = "Promedio Requeridos";
            promedioReqRadioBtn.UseVisualStyleBackColor = true;
            // 
            // cursosReqRadioBtn
            // 
            cursosReqRadioBtn.AutoSize = true;
            cursosReqRadioBtn.Location = new Point(552, 271);
            cursosReqRadioBtn.Name = "cursosReqRadioBtn";
            cursosReqRadioBtn.Size = new Size(123, 19);
            cursosReqRadioBtn.TabIndex = 34;
            cursosReqRadioBtn.TabStop = true;
            cursosReqRadioBtn.Text = "Cursos Requeridos";
            cursosReqRadioBtn.UseVisualStyleBackColor = true;
            // 
            // FormPanelReqAcademicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 380);
            Controls.Add(cursosReqRadioBtn);
            Controls.Add(promedioReqRadioBtn);
            Controls.Add(creditosReqRadioBtn);
            Controls.Add(pictureBox1);
            Controls.Add(backBtn);
            Controls.Add(editarCursoBtn);
            Controls.Add(cursosDGV);
            Controls.Add(panelLbl);
            Controls.Add(SysacadLbl);
            Name = "FormPanelReqAcademicos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button backBtn;
        private Button editarCursoBtn;
        private DataGridView cursosDGV;
        private Label panelLbl;
        private Label SysacadLbl;
        private BindingSource cursoBindingSource;
        private RadioButton creditosReqRadioBtn;
        private RadioButton promedioReqRadioBtn;
        private RadioButton cursosReqRadioBtn;
        private BindingSource cursoBindingSource1;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creditosRequeridosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn promedioRequeridoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CorrelatividadesColumn;
    }
}