namespace Forms_TP_SYSACAD
{
    partial class Form_Registro_Estudiantes
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
            lblInfoRegistro = new Label();
            lblNombre = new Label();
            lblLegajo = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblCorreo = new Label();
            lblContraseñaProv = new Label();
            textBoxNombre = new TextBox();
            textBoxLegajo = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxCorreo = new TextBox();
            textBoxContraseñaProv = new TextBox();
            lblCambioContraseña = new Label();
            checkBoxCambioContraseña = new CheckBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // lblInfoRegistro
            // 
            lblInfoRegistro.AutoSize = true;
            lblInfoRegistro.Location = new Point(26, 37);
            lblInfoRegistro.Name = "lblInfoRegistro";
            lblInfoRegistro.Size = new Size(38, 15);
            lblInfoRegistro.TabIndex = 0;
            lblInfoRegistro.Text = "label1";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(26, 91);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(38, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "label2";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(257, 91);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(38, 15);
            lblLegajo.TabIndex = 2;
            lblLegajo.Text = "label3";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(26, 157);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(38, 15);
            lblDireccion.TabIndex = 3;
            lblDireccion.Text = "label4";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(257, 157);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(38, 15);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "label5";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(26, 224);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(38, 15);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "label6";
            // 
            // lblContraseñaProv
            // 
            lblContraseñaProv.AutoSize = true;
            lblContraseñaProv.Location = new Point(257, 224);
            lblContraseñaProv.Name = "lblContraseñaProv";
            lblContraseñaProv.Size = new Size(38, 15);
            lblContraseñaProv.TabIndex = 6;
            lblContraseñaProv.Text = "label7";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(26, 109);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(166, 23);
            textBoxNombre.TabIndex = 7;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // textBoxLegajo
            // 
            textBoxLegajo.Location = new Point(257, 109);
            textBoxLegajo.Name = "textBoxLegajo";
            textBoxLegajo.Size = new Size(166, 23);
            textBoxLegajo.TabIndex = 8;
            textBoxLegajo.TextChanged += textBoxLegajo_TextChanged;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(26, 175);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(166, 23);
            textBoxDireccion.TabIndex = 9;
            textBoxDireccion.TextChanged += textBoxDireccion_TextChanged;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(257, 175);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(166, 23);
            textBoxTelefono.TabIndex = 10;
            textBoxTelefono.TextChanged += textBoxTelefono_TextChanged;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(26, 242);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(166, 23);
            textBoxCorreo.TabIndex = 11;
            textBoxCorreo.TextChanged += textBoxCorreo_TextChanged;
            // 
            // textBoxContraseñaProv
            // 
            textBoxContraseñaProv.Location = new Point(257, 242);
            textBoxContraseñaProv.Name = "textBoxContraseñaProv";
            textBoxContraseñaProv.Size = new Size(166, 23);
            textBoxContraseñaProv.TabIndex = 12;
            textBoxContraseñaProv.TextChanged += textBoxContraseñaProv_TextChanged;
            // 
            // lblCambioContraseña
            // 
            lblCambioContraseña.AutoSize = true;
            lblCambioContraseña.Location = new Point(26, 303);
            lblCambioContraseña.Name = "lblCambioContraseña";
            lblCambioContraseña.Size = new Size(38, 15);
            lblCambioContraseña.TabIndex = 13;
            lblCambioContraseña.Text = "label8";
            // 
            // checkBoxCambioContraseña
            // 
            checkBoxCambioContraseña.AutoSize = true;
            checkBoxCambioContraseña.Location = new Point(26, 324);
            checkBoxCambioContraseña.Name = "checkBoxCambioContraseña";
            checkBoxCambioContraseña.Size = new Size(83, 19);
            checkBoxCambioContraseña.TabIndex = 14;
            checkBoxCambioContraseña.Text = "checkBox1";
            checkBoxCambioContraseña.UseVisualStyleBackColor = true;
            checkBoxCambioContraseña.CheckedChanged += checkBoxCambioContraseña_CheckedChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(305, 303);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(118, 59);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "button1";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // Form_Registro_Estudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 378);
            Controls.Add(btnRegistrar);
            Controls.Add(checkBoxCambioContraseña);
            Controls.Add(lblCambioContraseña);
            Controls.Add(textBoxContraseñaProv);
            Controls.Add(textBoxCorreo);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxDireccion);
            Controls.Add(textBoxLegajo);
            Controls.Add(textBoxNombre);
            Controls.Add(lblContraseñaProv);
            Controls.Add(lblCorreo);
            Controls.Add(lblTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(lblLegajo);
            Controls.Add(lblNombre);
            Controls.Add(lblInfoRegistro);
            Name = "Form_Registro_Estudiantes";
            Text = "Form_Registro_Estudiantes";
            Load += Form_Registro_Estudiantes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfoRegistro;
        private Label lblNombre;
        private Label lblLegajo;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblCorreo;
        private Label lblContraseñaProv;
        private TextBox textBoxNombre;
        private TextBox textBoxLegajo;
        private TextBox textBoxDireccion;
        private TextBox textBoxTelefono;
        private TextBox textBoxCorreo;
        private TextBox textBoxContraseñaProv;
        private Label lblCambioContraseña;
        private CheckBox checkBoxCambioContraseña;
        private Button btnRegistrar;
    }
}