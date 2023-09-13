namespace Forms_TP_SYSACAD
{
    partial class Form_Registro
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
            lblInformacionRegistro = new Label();
            lblEmailRegistro = new Label();
            textBoxEmail = new TextBox();
            lblContraseñaRegistro = new Label();
            textBoxContraseña = new TextBox();
            btnRegistroUsuario = new Button();
            SuspendLayout();
            // 
            // lblInformacionRegistro
            // 
            lblInformacionRegistro.AutoSize = true;
            lblInformacionRegistro.Location = new Point(24, 32);
            lblInformacionRegistro.Name = "lblInformacionRegistro";
            lblInformacionRegistro.Size = new Size(38, 15);
            lblInformacionRegistro.TabIndex = 0;
            lblInformacionRegistro.Text = "label1";
            // 
            // lblEmailRegistro
            // 
            lblEmailRegistro.AutoSize = true;
            lblEmailRegistro.Location = new Point(24, 76);
            lblEmailRegistro.Name = "lblEmailRegistro";
            lblEmailRegistro.Size = new Size(38, 15);
            lblEmailRegistro.TabIndex = 1;
            lblEmailRegistro.Text = "label2";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(24, 104);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(100, 23);
            textBoxEmail.TabIndex = 2;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // lblContraseñaRegistro
            // 
            lblContraseñaRegistro.AutoSize = true;
            lblContraseñaRegistro.Location = new Point(24, 151);
            lblContraseñaRegistro.Name = "lblContraseñaRegistro";
            lblContraseñaRegistro.Size = new Size(38, 15);
            lblContraseñaRegistro.TabIndex = 3;
            lblContraseñaRegistro.Text = "label3";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(24, 178);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(100, 23);
            textBoxContraseña.TabIndex = 4;
            textBoxContraseña.TextChanged += textBoxContraseña_TextChanged;
            // 
            // btnRegistroUsuario
            // 
            btnRegistroUsuario.Location = new Point(192, 151);
            btnRegistroUsuario.Name = "btnRegistroUsuario";
            btnRegistroUsuario.Size = new Size(109, 50);
            btnRegistroUsuario.TabIndex = 5;
            btnRegistroUsuario.Text = "button1";
            btnRegistroUsuario.UseVisualStyleBackColor = true;
            btnRegistroUsuario.Click += btnRegistroUsuario_Click;
            // 
            // Form_Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 284);
            Controls.Add(btnRegistroUsuario);
            Controls.Add(textBoxContraseña);
            Controls.Add(lblContraseñaRegistro);
            Controls.Add(textBoxEmail);
            Controls.Add(lblEmailRegistro);
            Controls.Add(lblInformacionRegistro);
            Name = "Form_Registro";
            Text = "Form_Registro";
            Load += Form_Registro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInformacionRegistro;
        private Label lblEmailRegistro;
        private TextBox textBoxEmail;
        private Label lblContraseñaRegistro;
        private TextBox textBoxContraseña;
        private Button btnRegistroUsuario;
    }
}