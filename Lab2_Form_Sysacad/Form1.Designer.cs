namespace Lab2_Form_Sysacad
{
    partial class Form1
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
            textUsuario = new TextBox();
            textPassword = new TextBox();
            buttonAccept = new Button();
            SuspendLayout();
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(140, 103);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(100, 23);
            textUsuario.TabIndex = 0;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(140, 132);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(100, 23);
            textPassword.TabIndex = 1;
            // 
            // buttonAccept
            // 
            buttonAccept.Location = new Point(324, 120);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(75, 23);
            buttonAccept.TabIndex = 2;
            buttonAccept.Text = "aceptar";
            buttonAccept.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 217);
            Controls.Add(buttonAccept);
            Controls.Add(textPassword);
            Controls.Add(textUsuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsuario;
        private TextBox textPassword;
        private Button buttonAccept;
    }
}