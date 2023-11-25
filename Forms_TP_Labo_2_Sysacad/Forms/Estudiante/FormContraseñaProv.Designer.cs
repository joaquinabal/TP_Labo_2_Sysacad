namespace Forms_TP_Labo_2_Sysacad
{
    partial class FormContraseñaProv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContraseñaProv));
            repContraseñaTextbox = new TextBox();
            confirmBtn = new Button();
            repContraseñaLbl = new Label();
            contraseñaLbl = new Label();
            contraseñaTxtbox = new TextBox();
            estLbl = new Label();
            backBtn = new Button();
            SysacadLbl = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // repContraseñaTextbox
            // 
            repContraseñaTextbox.Location = new Point(108, 226);
            repContraseñaTextbox.Name = "repContraseñaTextbox";
            repContraseñaTextbox.PasswordChar = '*';
            repContraseñaTextbox.Size = new Size(100, 23);
            repContraseñaTextbox.TabIndex = 17;
            repContraseñaTextbox.TextChanged += repContraseñaTextbox_TextChanged;
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = Color.Goldenrod;
            confirmBtn.FlatStyle = FlatStyle.Flat;
            confirmBtn.Location = new Point(118, 282);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(75, 23);
            confirmBtn.TabIndex = 16;
            confirmBtn.Text = "Confirmar";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // repContraseñaLbl
            // 
            repContraseñaLbl.AutoSize = true;
            repContraseñaLbl.Location = new Point(108, 208);
            repContraseñaLbl.Name = "repContraseñaLbl";
            repContraseñaLbl.Size = new Size(110, 15);
            repContraseñaLbl.TabIndex = 15;
            repContraseñaLbl.Text = "Repetir Contraseña:";
            // 
            // contraseñaLbl
            // 
            contraseñaLbl.AutoSize = true;
            contraseñaLbl.Location = new Point(108, 151);
            contraseñaLbl.Name = "contraseñaLbl";
            contraseñaLbl.Size = new Size(107, 15);
            contraseñaLbl.TabIndex = 14;
            contraseñaLbl.Text = "Nueva Contraseña:";
            // 
            // contraseñaTxtbox
            // 
            contraseñaTxtbox.Location = new Point(108, 169);
            contraseñaTxtbox.Name = "contraseñaTxtbox";
            contraseñaTxtbox.Size = new Size(100, 23);
            contraseñaTxtbox.TabIndex = 18;
            contraseñaTxtbox.TextChanged += contraseñaTxtbox_TextChanged_1;
            // 
            // estLbl
            // 
            estLbl.AutoSize = true;
            estLbl.Font = new Font("Lucida Sans", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            estLbl.Location = new Point(16, 91);
            estLbl.Name = "estLbl";
            estLbl.Size = new Size(292, 23);
            estLbl.TabIndex = 12;
            estLbl.Text = "CAMBIO DE CONTRASEÑA";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(5, 344);
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
            SysacadLbl.Location = new Point(66, 11);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 10;
            SysacadLbl.Text = "SYSACAD";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(259, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 78;
            pictureBox1.TabStop = false;
            // 
            // FormContraseñaProv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 384);
            Controls.Add(pictureBox1);
            Controls.Add(repContraseñaTextbox);
            Controls.Add(confirmBtn);
            Controls.Add(repContraseñaLbl);
            Controls.Add(contraseñaLbl);
            Controls.Add(contraseñaTxtbox);
            Controls.Add(estLbl);
            Controls.Add(backBtn);
            Controls.Add(SysacadLbl);
            Name = "FormContraseñaProv";
            Text = "";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox repContraseñaTextbox;
        private Button confirmBtn;
        private Label repContraseñaLbl;
        private Label contraseñaLbl;
        private TextBox contraseñaTxtbox;
        private Label estLbl;
        private Button backBtn;
        private Label SysacadLbl;
        private PictureBox pictureBox1;
    }
}