namespace Forms_TP_Labo_2_Sysacad
{
    partial class FormRegEst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegEst));
            registrarBtn = new Button();
            passwordLbl = new Label();
            mailLbl = new Label();
            passwordTextbox = new TextBox();
            mailTxtbox = new TextBox();
            estLbl = new Label();
            backBtn = new Button();
            SysacadLbl = new Label();
            idLbl = new Label();
            nombreLbl = new Label();
            legajoTextbox = new TextBox();
            nombreTextbox = new TextBox();
            telefonoLbl = new Label();
            direccionLbl = new Label();
            telefonoTextbox = new TextBox();
            direccionTxtbox = new TextBox();
            provisionalCheckbox = new CheckBox();
            provisionalLbl = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // registrarBtn
            // 
            registrarBtn.BackColor = Color.Goldenrod;
            registrarBtn.FlatStyle = FlatStyle.Flat;
            registrarBtn.Location = new Point(119, 394);
            registrarBtn.Name = "registrarBtn";
            registrarBtn.Size = new Size(103, 23);
            registrarBtn.TabIndex = 16;
            registrarBtn.Text = "Registrarse";
            registrarBtn.UseVisualStyleBackColor = false;
            registrarBtn.Click += registrarBtn_Click;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(122, 281);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(70, 15);
            passwordLbl.TabIndex = 15;
            passwordLbl.Text = "Contraseña:";
            // 
            // mailLbl
            // 
            mailLbl.AutoSize = true;
            mailLbl.Location = new Point(122, 227);
            mailLbl.Name = "mailLbl";
            mailLbl.Size = new Size(108, 15);
            mailLbl.TabIndex = 14;
            mailLbl.Text = "Correo Electrónico:";
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(122, 299);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(100, 23);
            passwordTextbox.TabIndex = 13;
            passwordTextbox.TextChanged += passwordTextbox_TextChanged;
            // 
            // mailTxtbox
            // 
            mailTxtbox.Location = new Point(122, 245);
            mailTxtbox.Name = "mailTxtbox";
            mailTxtbox.Size = new Size(100, 23);
            mailTxtbox.TabIndex = 12;
            mailTxtbox.TextChanged += mailTxtbox_TextChanged;
            // 
            // estLbl
            // 
            estLbl.AutoSize = true;
            estLbl.Font = new Font("Lucida Sans", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            estLbl.Location = new Point(20, 75);
            estLbl.Name = "estLbl";
            estLbl.Size = new Size(301, 23);
            estLbl.TabIndex = 11;
            estLbl.Text = "REGISTRO DE ESTUDIANTE";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(4, 411);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 10;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(73, 9);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 9;
            SysacadLbl.Text = "SYSACAD";
            // 
            // idLbl
            // 
            idLbl.AutoSize = true;
            idLbl.Location = new Point(12, 182);
            idLbl.Name = "idLbl";
            idLbl.Size = new Size(45, 15);
            idLbl.TabIndex = 20;
            idLbl.Text = "Legajo:";
            // 
            // nombreLbl
            // 
            nombreLbl.AutoSize = true;
            nombreLbl.Location = new Point(12, 128);
            nombreLbl.Name = "nombreLbl";
            nombreLbl.Size = new Size(110, 15);
            nombreLbl.TabIndex = 19;
            nombreLbl.Text = "Nombre Completo:";
            // 
            // legajoTextbox
            // 
            legajoTextbox.Location = new Point(12, 200);
            legajoTextbox.Name = "legajoTextbox";
            legajoTextbox.Size = new Size(100, 23);
            legajoTextbox.TabIndex = 18;
            legajoTextbox.TextChanged += legajoTextbox_TextChanged;
            // 
            // nombreTextbox
            // 
            nombreTextbox.Location = new Point(12, 146);
            nombreTextbox.Name = "nombreTextbox";
            nombreTextbox.Size = new Size(100, 23);
            nombreTextbox.TabIndex = 17;
            nombreTextbox.TextChanged += nombreTextbox_TextChanged;
            // 
            // telefonoLbl
            // 
            telefonoLbl.AutoSize = true;
            telefonoLbl.Location = new Point(228, 182);
            telefonoLbl.Name = "telefonoLbl";
            telefonoLbl.Size = new Size(55, 15);
            telefonoLbl.TabIndex = 24;
            telefonoLbl.Text = "Teléfono:";
            // 
            // direccionLbl
            // 
            direccionLbl.AutoSize = true;
            direccionLbl.Location = new Point(228, 128);
            direccionLbl.Name = "direccionLbl";
            direccionLbl.Size = new Size(60, 15);
            direccionLbl.TabIndex = 23;
            direccionLbl.Text = "Dirección:";
            // 
            // telefonoTextbox
            // 
            telefonoTextbox.Location = new Point(228, 200);
            telefonoTextbox.Name = "telefonoTextbox";
            telefonoTextbox.Size = new Size(100, 23);
            telefonoTextbox.TabIndex = 22;
            telefonoTextbox.TextChanged += telefonoTextbox_TextChanged;
            // 
            // direccionTxtbox
            // 
            direccionTxtbox.Location = new Point(228, 146);
            direccionTxtbox.Name = "direccionTxtbox";
            direccionTxtbox.Size = new Size(100, 23);
            direccionTxtbox.TabIndex = 21;
            direccionTxtbox.TextChanged += direccionTxtbox_TextChanged;
            // 
            // provisionalCheckbox
            // 
            provisionalCheckbox.AutoSize = true;
            provisionalCheckbox.Location = new Point(63, 328);
            provisionalCheckbox.Name = "provisionalCheckbox";
            provisionalCheckbox.Size = new Size(232, 19);
            provisionalCheckbox.TabIndex = 25;
            provisionalCheckbox.Text = "Elegir que la contraseña sea provisional";
            provisionalCheckbox.UseVisualStyleBackColor = true;
            // 
            // provisionalLbl
            // 
            provisionalLbl.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            provisionalLbl.Location = new Point(67, 346);
            provisionalLbl.Name = "provisionalLbl";
            provisionalLbl.Size = new Size(247, 31);
            provisionalLbl.TabIndex = 26;
            provisionalLbl.Text = "(Una contraseña provisional deberá ser cambiada por el estudiante al hacer su primer inicio de sesión)";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(281, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // FormRegEst
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 450);
            Controls.Add(pictureBox1);
            Controls.Add(provisionalLbl);
            Controls.Add(provisionalCheckbox);
            Controls.Add(telefonoLbl);
            Controls.Add(direccionLbl);
            Controls.Add(telefonoTextbox);
            Controls.Add(direccionTxtbox);
            Controls.Add(idLbl);
            Controls.Add(nombreLbl);
            Controls.Add(legajoTextbox);
            Controls.Add(nombreTextbox);
            Controls.Add(registrarBtn);
            Controls.Add(passwordLbl);
            Controls.Add(mailLbl);
            Controls.Add(passwordTextbox);
            Controls.Add(mailTxtbox);
            Controls.Add(estLbl);
            Controls.Add(backBtn);
            Controls.Add(SysacadLbl);
            Name = "FormRegEst";
            Text = "FormRegEst";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registrarBtn;
        private Label passwordLbl;
        private Label mailLbl;
        private TextBox passwordTextbox;
        private TextBox mailTxtbox;
        private Label estLbl;
        private Button backBtn;
        private Label SysacadLbl;
        private Label idLbl;
        private Label nombreLbl;
        private TextBox idTextbox;
        private TextBox nombreTextbox;
        private Label telefonoLbl;
        private Label direccionLbl;
        private TextBox telefonoTextbox;
        private TextBox direccionTxtbox;
        private CheckBox provisionalCheckbox;
        private Label provisionalLbl;
        private TextBox legajoTextbox;
        private PictureBox pictureBox1;
    }
}