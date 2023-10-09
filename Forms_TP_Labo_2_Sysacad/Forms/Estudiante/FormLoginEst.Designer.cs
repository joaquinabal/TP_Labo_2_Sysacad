namespace Forms_TP_Labo_2_Sysacad
{
    partial class FormLoginEst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginEst));
            SysacadLbl = new Label();
            backBtn = new Button();
            estLbl = new Label();
            mailTxtbox = new TextBox();
            mailLbl = new Label();
            passwordLbl = new Label();
            loginBtn = new Button();
            passwordTextbox = new TextBox();
            autBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(60, 12);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 1;
            SysacadLbl.Text = "SYSACAD";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(3, 303);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 2;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // estLbl
            // 
            estLbl.AutoSize = true;
            estLbl.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            estLbl.Location = new Point(22, 84);
            estLbl.Name = "estLbl";
            estLbl.Size = new Size(263, 22);
            estLbl.TabIndex = 3;
            estLbl.Text = "INGRESO DE ESTUDIANTE";
            // 
            // mailTxtbox
            // 
            mailTxtbox.Location = new Point(89, 160);
            mailTxtbox.Name = "mailTxtbox";
            mailTxtbox.Size = new Size(132, 23);
            mailTxtbox.TabIndex = 4;
            mailTxtbox.TextChanged += mailTxtbox_TextChanged;
            // 
            // mailLbl
            // 
            mailLbl.AutoSize = true;
            mailLbl.Location = new Point(89, 142);
            mailLbl.Name = "mailLbl";
            mailLbl.Size = new Size(108, 15);
            mailLbl.TabIndex = 6;
            mailLbl.Text = "Correo Electrónico:";
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(89, 208);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(70, 15);
            passwordLbl.TabIndex = 7;
            passwordLbl.Text = "Contraseña:";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Goldenrod;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Location = new Point(116, 271);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 8;
            loginBtn.Text = "Ingresar";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(89, 226);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PasswordChar = '*';
            passwordTextbox.Size = new Size(132, 23);
            passwordTextbox.TabIndex = 9;
            passwordTextbox.TextChanged += passwordTextbox_TextChanged;
            // 
            // autBtn
            // 
            autBtn.BackColor = Color.Goldenrod;
            autBtn.FlatStyle = FlatStyle.Flat;
            autBtn.Location = new Point(220, 317);
            autBtn.Name = "autBtn";
            autBtn.Size = new Size(92, 23);
            autBtn.TabIndex = 10;
            autBtn.Text = "Automatizar";
            autBtn.UseVisualStyleBackColor = false;
            autBtn.Click += autBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(257, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // FormLoginEst
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 341);
            Controls.Add(pictureBox1);
            Controls.Add(autBtn);
            Controls.Add(passwordTextbox);
            Controls.Add(loginBtn);
            Controls.Add(passwordLbl);
            Controls.Add(mailLbl);
            Controls.Add(mailTxtbox);
            Controls.Add(estLbl);
            Controls.Add(backBtn);
            Controls.Add(SysacadLbl);
            Name = "FormLoginEst";
            Text = "";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SysacadLbl;
        private Button backBtn;
        private Label estLbl;
        private TextBox mailTxtbox;
        private Label mailLbl;
        private Label passwordLbl;
        private Button loginBtn;
        private TextBox passwordTextbox;
        private Button autBtn;
        private PictureBox pictureBox1;
    }
}