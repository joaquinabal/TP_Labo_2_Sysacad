namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    partial class FormPanelListasEsperaEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanelListasEsperaEstudiantes));
            pictureBox1 = new PictureBox();
            backBtn = new Button();
            agregarEstBtn = new Button();
            estListaLbl = new Label();
            SysacadLbl = new Label();
            eliminarBtn = new Button();
            estudiantesDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estudiantesDGV).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(762, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(7, 299);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 42;
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
            agregarEstBtn.Location = new Point(233, 256);
            agregarEstBtn.Name = "agregarEstBtn";
            agregarEstBtn.Size = new Size(162, 33);
            agregarEstBtn.TabIndex = 41;
            agregarEstBtn.Text = "Agregar Estudiante";
            agregarEstBtn.UseVisualStyleBackColor = false;
            agregarEstBtn.Click += agregarEstBtn_Click;
            // 
            // estListaLbl
            // 
            estListaLbl.AutoSize = true;
            estListaLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            estListaLbl.Location = new Point(233, 55);
            estListaLbl.Name = "estListaLbl";
            estListaLbl.Size = new Size(413, 25);
            estListaLbl.TabIndex = 39;
            estListaLbl.Text = "ESTUDIANTES EN LISTA DE ESPERA";
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(322, 7);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 38;
            SysacadLbl.Text = "SYSACAD";
            // 
            // eliminarBtn
            // 
            eliminarBtn.AutoSize = true;
            eliminarBtn.BackColor = Color.Goldenrod;
            eliminarBtn.FlatStyle = FlatStyle.Flat;
            eliminarBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            eliminarBtn.Location = new Point(474, 256);
            eliminarBtn.Name = "eliminarBtn";
            eliminarBtn.Size = new Size(162, 33);
            eliminarBtn.TabIndex = 44;
            eliminarBtn.Text = "Eliminar Estudiante";
            eliminarBtn.UseVisualStyleBackColor = false;
            eliminarBtn.Click += eliminarBtn_Click;
            // 
            // estudiantesDGV
            // 
            estudiantesDGV.AllowUserToAddRows = false;
            estudiantesDGV.AllowUserToDeleteRows = false;
            estudiantesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            estudiantesDGV.Location = new Point(47, 100);
            estudiantesDGV.Name = "estudiantesDGV";
            estudiantesDGV.ReadOnly = true;
            estudiantesDGV.RowTemplate.Height = 25;
            estudiantesDGV.Size = new Size(710, 150);
            estudiantesDGV.TabIndex = 45;
            estudiantesDGV.CellClick += estudiantesDGV_CellClick;
            // 
            // FormPanelListasEsperaEstudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 340);
            Controls.Add(estudiantesDGV);
            Controls.Add(eliminarBtn);
            Controls.Add(pictureBox1);
            Controls.Add(backBtn);
            Controls.Add(agregarEstBtn);
            Controls.Add(estListaLbl);
            Controls.Add(SysacadLbl);
            Name = "FormPanelListasEsperaEstudiantes";
            Text = "FormPanelListasEsperaEstudiantes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)estudiantesDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button backBtn;
        private Button agregarEstBtn;
        private Label estListaLbl;
        private Label SysacadLbl;
        private Button eliminarBtn;
        private DataGridView estudiantesDGV;
    }
}