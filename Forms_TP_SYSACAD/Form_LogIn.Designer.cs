namespace Forms_TP_SYSACAD
{
    partial class Form_LogIn
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
            lblBienvenida = new Label();
            textBoxEmail = new TextBox();
            textBoxContraseña = new TextBox();
            lblMail = new Label();
            lblContraseña = new Label();
            btnIngresar = new Button();
            btnRegistrarse = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblBienvenida.Location = new Point(12, 21);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(65, 28);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "label1";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 104);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(136, 23);
            textBoxEmail.TabIndex = 1;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(12, 191);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(136, 23);
            textBoxContraseña.TabIndex = 2;
            textBoxContraseña.TextChanged += textBoxContraseña_TextChanged;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(12, 73);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(38, 15);
            lblMail.TabIndex = 3;
            lblMail.Text = "label1";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(12, 158);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(38, 15);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "label2";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(256, 178);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(116, 46);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "button1";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(256, 116);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(116, 46);
            btnRegistrarse.TabIndex = 6;
            btnRegistrarse.Text = "button1";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // Form_LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 288);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnIngresar);
            Controls.Add(lblContraseña);
            Controls.Add(lblMail);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxEmail);
            Controls.Add(lblBienvenida);
            Name = "Form_LogIn";
            Text = "Form1";
            Load += Inicio_Sesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private TextBox textBoxEmail;
        private TextBox textBoxContraseña;
        private Label lblMail;
        private Label lblContraseña;
        private Button btnIngresar;
        private Button btnRegistrarse;
    }
}