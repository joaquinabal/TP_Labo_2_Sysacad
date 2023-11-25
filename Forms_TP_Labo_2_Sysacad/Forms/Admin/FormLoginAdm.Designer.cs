namespace Forms_TP_Labo_2_Sysacad
{
    partial class FormLoginAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginAdm));
            loginBtn = new Button();
            passwordLbl = new Label();
            mailLbl = new Label();
            passwordTextbox = new TextBox();
            mailTxtbox = new TextBox();
            estLbl = new Label();
            SysacadLbl = new Label();
            backBtn = new Button();
            autBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Goldenrod;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Location = new Point(118, 246);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 16;
            loginBtn.Text = "Ingresar";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(93, 187);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(70, 15);
            passwordLbl.TabIndex = 15;
            passwordLbl.Text = "Contraseña:";
            // 
            // mailLbl
            // 
            mailLbl.AutoSize = true;
            mailLbl.Location = new Point(93, 121);
            mailLbl.Name = "mailLbl";
            mailLbl.Size = new Size(108, 15);
            mailLbl.TabIndex = 14;
            mailLbl.Text = "Correo Electrónico:";
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(93, 205);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PasswordChar = '*';
            passwordTextbox.Size = new Size(133, 23);
            passwordTextbox.TabIndex = 13;
            passwordTextbox.TextChanged += passwordTextbox_TextChanged;
            // 
            // mailTxtbox
            // 
            mailTxtbox.Location = new Point(93, 139);
            mailTxtbox.Name = "mailTxtbox";
            mailTxtbox.Size = new Size(133, 23);
            mailTxtbox.TabIndex = 12;
            mailTxtbox.TextChanged += mailTxtbox_TextChanged;
            // 
            // estLbl
            // 
            estLbl.AutoSize = true;
            estLbl.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            estLbl.Location = new Point(5, 71);
            estLbl.Name = "estLbl";
            estLbl.Size = new Size(307, 22);
            estLbl.TabIndex = 11;
            estLbl.Text = "INGRESO DE ADMINISTRADOR";
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(57, 9);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 9;
            SysacadLbl.Text = "SYSACAD";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.ForeColor = Color.Black;
            backBtn.Location = new Point(5, 288);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 18;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click_1;
            // 
            // autBtn
            // 
            autBtn.BackColor = Color.Goldenrod;
            autBtn.FlatStyle = FlatStyle.Flat;
            autBtn.Location = new Point(211, 296);
            autBtn.Name = "autBtn";
            autBtn.Size = new Size(92, 23);
            autBtn.TabIndex = 19;
            autBtn.Text = "Automatizar";
            autBtn.UseVisualStyleBackColor = false;
            autBtn.Click += autBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(258, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // FormLoginAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 326);
            Controls.Add(pictureBox1);
            Controls.Add(autBtn);
            Controls.Add(backBtn);
            Controls.Add(loginBtn);
            Controls.Add(passwordLbl);
            Controls.Add(mailLbl);
            Controls.Add(passwordTextbox);
            Controls.Add(mailTxtbox);
            Controls.Add(estLbl);
            Controls.Add(SysacadLbl);
            Name = "FormLoginAdm";
            Text = "";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBtn;
        private Label passwordLbl;
        private Label mailLbl;
        private TextBox passwordTextbox;
        private TextBox mailTxtbox;
        private Label estLbl;
        private Button backBtn;
        private Label SysacadLbl;
        private Button button1;
        private Button autBtn;
        private PictureBox pictureBox1;
    }
}