namespace Forms_TP_Labo_2_Sysacad
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            SysacadLbl = new Label();
            bnvLbl = new Label();
            estBtn = new Button();
            admBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(118, 24);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 0;
            SysacadLbl.Text = "SYSACAD";
            // 
            // bnvLbl
            // 
            bnvLbl.AutoSize = true;
            bnvLbl.Font = new Font("Lucida Sans", 18F, FontStyle.Bold, GraphicsUnit.Point);
            bnvLbl.Location = new Point(129, 84);
            bnvLbl.Name = "bnvLbl";
            bnvLbl.Size = new Size(173, 27);
            bnvLbl.TabIndex = 1;
            bnvLbl.Text = "BIENVENIDO";
            // 
            // estBtn
            // 
            estBtn.BackColor = Color.Goldenrod;
            estBtn.FlatStyle = FlatStyle.Flat;
            estBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            estBtn.Location = new Point(12, 144);
            estBtn.Name = "estBtn";
            estBtn.Size = new Size(164, 55);
            estBtn.TabIndex = 2;
            estBtn.Text = "Ingresar como Estudiante";
            estBtn.UseVisualStyleBackColor = false;
            estBtn.Click += estBtn_Click;
            // 
            // admBtn
            // 
            admBtn.BackColor = Color.Goldenrod;
            admBtn.FlatStyle = FlatStyle.Flat;
            admBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            admBtn.Location = new Point(265, 144);
            admBtn.Name = "admBtn";
            admBtn.Size = new Size(164, 55);
            admBtn.TabIndex = 3;
            admBtn.Text = "Ingresar como Administrador";
            admBtn.UseVisualStyleBackColor = false;
            admBtn.Click += admBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(366, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 203);
            Controls.Add(pictureBox1);
            Controls.Add(admBtn);
            Controls.Add(estBtn);
            Controls.Add(bnvLbl);
            Controls.Add(SysacadLbl);
            Name = "FormPrincipal";
            Text = ". ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SysacadLbl;
        private Label bnvLbl;
        private Button estBtn;
        private Button admBtn;
        private PictureBox pictureBox1;
    }
}