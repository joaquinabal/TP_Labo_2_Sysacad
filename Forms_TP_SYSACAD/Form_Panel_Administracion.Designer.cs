namespace Forms_TP_SYSACAD
{
    partial class Form_Panel_Administracion
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
            lblInformacionPanel = new Label();
            btnRegistroEstudiante = new Button();
            lblOpcionEstudiante = new Label();
            lblSeccionCursos = new Label();
            SuspendLayout();
            // 
            // lblInformacionPanel
            // 
            lblInformacionPanel.AutoSize = true;
            lblInformacionPanel.Location = new Point(41, 56);
            lblInformacionPanel.Name = "lblInformacionPanel";
            lblInformacionPanel.Size = new Size(38, 15);
            lblInformacionPanel.TabIndex = 0;
            lblInformacionPanel.Text = "label1";
            // 
            // btnRegistroEstudiante
            // 
            btnRegistroEstudiante.Location = new Point(41, 140);
            btnRegistroEstudiante.Name = "btnRegistroEstudiante";
            btnRegistroEstudiante.Size = new Size(75, 23);
            btnRegistroEstudiante.TabIndex = 1;
            btnRegistroEstudiante.Text = "button1";
            btnRegistroEstudiante.UseVisualStyleBackColor = true;
            btnRegistroEstudiante.Click += btnRegistroEstudiante_Click;
            // 
            // lblOpcionEstudiante
            // 
            lblOpcionEstudiante.AutoSize = true;
            lblOpcionEstudiante.Location = new Point(41, 103);
            lblOpcionEstudiante.Name = "lblOpcionEstudiante";
            lblOpcionEstudiante.Size = new Size(38, 15);
            lblOpcionEstudiante.TabIndex = 2;
            lblOpcionEstudiante.Text = "label1";
            // 
            // lblSeccionCursos
            // 
            lblSeccionCursos.AutoSize = true;
            lblSeccionCursos.Location = new Point(41, 189);
            lblSeccionCursos.Name = "lblSeccionCursos";
            lblSeccionCursos.Size = new Size(38, 15);
            lblSeccionCursos.TabIndex = 3;
            lblSeccionCursos.Text = "label1";
            // 
            // Form_Panel_Administracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSeccionCursos);
            Controls.Add(lblOpcionEstudiante);
            Controls.Add(btnRegistroEstudiante);
            Controls.Add(lblInformacionPanel);
            Name = "Form_Panel_Administracion";
            Text = "Form_Panel_Administracion";
            Load += Form_Panel_Administracion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInformacionPanel;
        private Button btnRegistroEstudiante;
        private Label lblOpcionEstudiante;
        private Label lblSeccionCursos;
    }
}