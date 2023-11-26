namespace Forms_TP_Labo_2_Sysacad
{
    partial class FormPanelAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanelAdministrador));
            backBtn = new Button();
            SysacadLbl = new Label();
            registrarEstBtn = new Button();
            gestionarCursosBtn = new Button();
            label1 = new Label();
            bnvLbl = new Label();
            pictureBox1 = new PictureBox();
            gestProfBtn = new Button();
            listasEsperaBtn = new Button();
            reqAcademicosBtn = new Button();
            reporteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(6, 345);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 11;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(236, 23);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 12;
            SysacadLbl.Text = "SYSACAD";
            // 
            // registrarEstBtn
            // 
            registrarEstBtn.AutoSize = true;
            registrarEstBtn.BackColor = Color.Goldenrod;
            registrarEstBtn.FlatStyle = FlatStyle.Flat;
            registrarEstBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            registrarEstBtn.Location = new Point(12, 136);
            registrarEstBtn.Name = "registrarEstBtn";
            registrarEstBtn.Size = new Size(292, 37);
            registrarEstBtn.TabIndex = 13;
            registrarEstBtn.Text = "Registrar Estudiante";
            registrarEstBtn.UseVisualStyleBackColor = false;
            registrarEstBtn.Click += registrarEstBtn_Click;
            // 
            // gestionarCursosBtn
            // 
            gestionarCursosBtn.AutoSize = true;
            gestionarCursosBtn.BackColor = Color.Goldenrod;
            gestionarCursosBtn.FlatStyle = FlatStyle.Popup;
            gestionarCursosBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            gestionarCursosBtn.Location = new Point(362, 136);
            gestionarCursosBtn.Name = "gestionarCursosBtn";
            gestionarCursosBtn.Size = new Size(302, 35);
            gestionarCursosBtn.TabIndex = 14;
            gestionarCursosBtn.Text = "Gestionar Cursos";
            gestionarCursosBtn.UseVisualStyleBackColor = false;
            gestionarCursosBtn.Click += gestionarCursosBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(139, 79);
            label1.Name = "label1";
            label1.Size = new Size(357, 29);
            label1.TabIndex = 15;
            label1.Text = "PANEL DE ADMINISTRADOR";
            // 
            // bnvLbl
            // 
            bnvLbl.AutoSize = true;
            bnvLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bnvLbl.Location = new Point(-2, -2);
            bnvLbl.Name = "bnvLbl";
            bnvLbl.Size = new Size(145, 21);
            bnvLbl.TabIndex = 16;
            bnvLbl.Text = "Bienvenido, admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(603, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // gestProfBtn
            // 
            gestProfBtn.AutoSize = true;
            gestProfBtn.BackColor = Color.Goldenrod;
            gestProfBtn.FlatStyle = FlatStyle.Popup;
            gestProfBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            gestProfBtn.Location = new Point(362, 191);
            gestProfBtn.Name = "gestProfBtn";
            gestProfBtn.Size = new Size(302, 35);
            gestProfBtn.TabIndex = 23;
            gestProfBtn.Text = "Gestionar Profesores";
            gestProfBtn.UseVisualStyleBackColor = false;
            gestProfBtn.Click += gestProfBtn_Click;
            // 
            // listasEsperaBtn
            // 
            listasEsperaBtn.AutoSize = true;
            listasEsperaBtn.BackColor = Color.Goldenrod;
            listasEsperaBtn.FlatStyle = FlatStyle.Popup;
            listasEsperaBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listasEsperaBtn.Location = new Point(12, 191);
            listasEsperaBtn.Name = "listasEsperaBtn";
            listasEsperaBtn.Size = new Size(292, 35);
            listasEsperaBtn.TabIndex = 24;
            listasEsperaBtn.Text = "Manejar Listas de Espera";
            listasEsperaBtn.UseVisualStyleBackColor = false;
            listasEsperaBtn.Click += listasEsperaBtn_Click;
            // 
            // reqAcademicosBtn
            // 
            reqAcademicosBtn.AutoSize = true;
            reqAcademicosBtn.BackColor = Color.Goldenrod;
            reqAcademicosBtn.FlatStyle = FlatStyle.Popup;
            reqAcademicosBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            reqAcademicosBtn.Location = new Point(362, 244);
            reqAcademicosBtn.Name = "reqAcademicosBtn";
            reqAcademicosBtn.Size = new Size(304, 35);
            reqAcademicosBtn.TabIndex = 25;
            reqAcademicosBtn.Text = "Gestionar Requisitos Académicos";
            reqAcademicosBtn.UseVisualStyleBackColor = false;
            reqAcademicosBtn.Click += reqAcademicosBtn_Click;
            // 
            // reporteBtn
            // 
            reporteBtn.AutoSize = true;
            reporteBtn.BackColor = Color.Goldenrod;
            reporteBtn.FlatStyle = FlatStyle.Popup;
            reporteBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            reporteBtn.Location = new Point(12, 244);
            reporteBtn.Name = "reporteBtn";
            reporteBtn.Size = new Size(292, 35);
            reporteBtn.TabIndex = 26;
            reporteBtn.Text = "Generar Reporte";
            reporteBtn.UseVisualStyleBackColor = false;
            reporteBtn.Click += reporteBtn_Click;
            // 
            // FormPanelAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(676, 383);
            Controls.Add(reporteBtn);
            Controls.Add(reqAcademicosBtn);
            Controls.Add(listasEsperaBtn);
            Controls.Add(gestProfBtn);
            Controls.Add(pictureBox1);
            Controls.Add(bnvLbl);
            Controls.Add(label1);
            Controls.Add(gestionarCursosBtn);
            Controls.Add(registrarEstBtn);
            Controls.Add(SysacadLbl);
            Controls.Add(backBtn);
            Name = "FormPanelAdministrador";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private Label SysacadLbl;
        private Button registrarEstBtn;
        private Button gestionarCursosBtn;
        private Label label1;
        private Label bnvLbl;
        private PictureBox pictureBox1;
        private Button gestProfBtn;
        private Button listasEsperaBtn;
        private Button reqAcademicosBtn;
        private Button reporteBtn;
    }
}