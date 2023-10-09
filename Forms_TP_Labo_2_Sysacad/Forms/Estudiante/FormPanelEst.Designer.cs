namespace Forms_TP_Labo_2_Sysacad
{
    partial class FormPanelEst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanelEst));
            bnvLbl = new Label();
            panelEstLbl = new Label();
            gestionarCursosBtn = new Button();
            RealizarPagosBtn = new Button();
            SysacadLbl = new Label();
            backBtn = new Button();
            consultarHorariosBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bnvLbl
            // 
            bnvLbl.AutoSize = true;
            bnvLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bnvLbl.Location = new Point(1, -1);
            bnvLbl.Name = "bnvLbl";
            bnvLbl.Size = new Size(0, 21);
            bnvLbl.TabIndex = 22;
            // 
            // panelEstLbl
            // 
            panelEstLbl.AutoSize = true;
            panelEstLbl.Font = new Font("Lucida Sans", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            panelEstLbl.Location = new Point(157, 71);
            panelEstLbl.Name = "panelEstLbl";
            panelEstLbl.Size = new Size(262, 23);
            panelEstLbl.TabIndex = 21;
            panelEstLbl.Text = "PANEL DE ESTUDIANTE";
            // 
            // gestionarCursosBtn
            // 
            gestionarCursosBtn.AutoSize = true;
            gestionarCursosBtn.BackColor = Color.Goldenrod;
            gestionarCursosBtn.FlatStyle = FlatStyle.Flat;
            gestionarCursosBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            gestionarCursosBtn.Location = new Point(6, 130);
            gestionarCursosBtn.Name = "gestionarCursosBtn";
            gestionarCursosBtn.Size = new Size(193, 37);
            gestionarCursosBtn.TabIndex = 20;
            gestionarCursosBtn.Text = "Gestionar Cursos";
            gestionarCursosBtn.UseVisualStyleBackColor = false;
            gestionarCursosBtn.Click += gestionarCursosBtn_Click;
            // 
            // RealizarPagosBtn
            // 
            RealizarPagosBtn.AutoSize = true;
            RealizarPagosBtn.BackColor = Color.Goldenrod;
            RealizarPagosBtn.FlatStyle = FlatStyle.Flat;
            RealizarPagosBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RealizarPagosBtn.Location = new Point(378, 130);
            RealizarPagosBtn.Name = "RealizarPagosBtn";
            RealizarPagosBtn.Size = new Size(193, 37);
            RealizarPagosBtn.TabIndex = 19;
            RealizarPagosBtn.Text = "Realizar Pagos";
            RealizarPagosBtn.UseVisualStyleBackColor = false;
            RealizarPagosBtn.Click += RealizarPagosBtn_Click;
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(186, 11);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 18;
            SysacadLbl.Text = "SYSACAD";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(5, 253);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 17;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click_1;
            // 
            // consultarHorariosBtn
            // 
            consultarHorariosBtn.AutoSize = true;
            consultarHorariosBtn.BackColor = Color.Goldenrod;
            consultarHorariosBtn.FlatStyle = FlatStyle.Flat;
            consultarHorariosBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            consultarHorariosBtn.Location = new Point(6, 187);
            consultarHorariosBtn.Name = "consultarHorariosBtn";
            consultarHorariosBtn.Size = new Size(193, 37);
            consultarHorariosBtn.TabIndex = 23;
            consultarHorariosBtn.Text = "Consultar Horarios";
            consultarHorariosBtn.UseVisualStyleBackColor = false;
            consultarHorariosBtn.Click += consultarHorariosBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(509, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            // 
            // FormPanelEst
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 292);
            Controls.Add(pictureBox1);
            Controls.Add(consultarHorariosBtn);
            Controls.Add(bnvLbl);
            Controls.Add(panelEstLbl);
            Controls.Add(gestionarCursosBtn);
            Controls.Add(RealizarPagosBtn);
            Controls.Add(SysacadLbl);
            Controls.Add(backBtn);
            Name = "FormPanelEst";
            Text = "";
            Load += FormPanelEst_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bnvLbl;
        private Label panelEstLbl;
        private Button gestionarCursosBtn;
        private Button RealizarPagosBtn;
        private Label SysacadLbl;
        private Button backBtn;
        private Button consultarHorariosBtn;
        private PictureBox pictureBox1;
    }
}