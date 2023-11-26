namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    partial class FormEditarProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarProf));
            direccionTextbox = new TextBox();
            pictureBox1 = new PictureBox();
            especializacionCombobox = new ComboBox();
            direccionLbl = new Label();
            correoLbl = new Label();
            correoTextbox = new TextBox();
            especializacionLbl = new Label();
            telefonoLbl = new Label();
            nombreLbl = new Label();
            telefonoTextbox = new TextBox();
            nombreTextbox = new TextBox();
            editarBtn = new Button();
            agregarProfLbl = new Label();
            backBtn = new Button();
            SysacadLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // direccionTextbox
            // 
            direccionTextbox.Location = new Point(224, 125);
            direccionTextbox.Name = "direccionTextbox";
            direccionTextbox.Size = new Size(100, 23);
            direccionTextbox.TabIndex = 109;
            direccionTextbox.TextChanged += direccionTextbox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(278, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 108;
            pictureBox1.TabStop = false;
            // 
            // especializacionCombobox
            // 
            especializacionCombobox.FormattingEnabled = true;
            especializacionCombobox.Items.AddRange(new object[] { "Esp 1", "Esp 2", "Esp 3", "Esp 4" });
            especializacionCombobox.Location = new Point(122, 239);
            especializacionCombobox.Name = "especializacionCombobox";
            especializacionCombobox.Size = new Size(98, 23);
            especializacionCombobox.TabIndex = 107;
            especializacionCombobox.SelectedIndexChanged += especializacionCombobox_SelectedIndexChanged;
            // 
            // direccionLbl
            // 
            direccionLbl.AutoSize = true;
            direccionLbl.Location = new Point(220, 107);
            direccionLbl.Name = "direccionLbl";
            direccionLbl.Size = new Size(60, 15);
            direccionLbl.TabIndex = 106;
            direccionLbl.Text = "Dirección:";
            // 
            // correoLbl
            // 
            correoLbl.AutoSize = true;
            correoLbl.Location = new Point(220, 161);
            correoLbl.Name = "correoLbl";
            correoLbl.Size = new Size(46, 15);
            correoLbl.TabIndex = 105;
            correoLbl.Text = "Correo:";
            // 
            // correoTextbox
            // 
            correoTextbox.Location = new Point(220, 179);
            correoTextbox.Name = "correoTextbox";
            correoTextbox.Size = new Size(100, 23);
            correoTextbox.TabIndex = 104;
            correoTextbox.TextChanged += correoTextbox_TextChanged;
            // 
            // especializacionLbl
            // 
            especializacionLbl.AutoSize = true;
            especializacionLbl.Location = new Point(122, 221);
            especializacionLbl.Name = "especializacionLbl";
            especializacionLbl.Size = new Size(27, 15);
            especializacionLbl.TabIndex = 103;
            especializacionLbl.Text = "Día:";
            // 
            // telefonoLbl
            // 
            telefonoLbl.AutoSize = true;
            telefonoLbl.Location = new Point(11, 161);
            telefonoLbl.Name = "telefonoLbl";
            telefonoLbl.Size = new Size(55, 15);
            telefonoLbl.TabIndex = 102;
            telefonoLbl.Text = "Télefono:";
            // 
            // nombreLbl
            // 
            nombreLbl.AutoSize = true;
            nombreLbl.Location = new Point(11, 107);
            nombreLbl.Name = "nombreLbl";
            nombreLbl.Size = new Size(54, 15);
            nombreLbl.TabIndex = 101;
            nombreLbl.Text = "Nombre:";
            // 
            // telefonoTextbox
            // 
            telefonoTextbox.Location = new Point(11, 179);
            telefonoTextbox.Name = "telefonoTextbox";
            telefonoTextbox.Size = new Size(100, 23);
            telefonoTextbox.TabIndex = 100;
            telefonoTextbox.TextChanged += telefonoTextbox_TextChanged;
            // 
            // nombreTextbox
            // 
            nombreTextbox.Location = new Point(11, 125);
            nombreTextbox.Name = "nombreTextbox";
            nombreTextbox.Size = new Size(100, 23);
            nombreTextbox.TabIndex = 99;
            nombreTextbox.TextChanged += nombreTextbox_TextChanged_1;
            // 
            // editarBtn
            // 
            editarBtn.BackColor = Color.Goldenrod;
            editarBtn.FlatStyle = FlatStyle.Flat;
            editarBtn.Location = new Point(117, 284);
            editarBtn.Name = "editarBtn";
            editarBtn.Size = new Size(103, 23);
            editarBtn.TabIndex = 98;
            editarBtn.Text = "Editar";
            editarBtn.UseVisualStyleBackColor = false;
            editarBtn.Click += editarBtn_Click;
            // 
            // agregarProfLbl
            // 
            agregarProfLbl.AutoSize = true;
            agregarProfLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            agregarProfLbl.Location = new Point(57, 69);
            agregarProfLbl.Name = "agregarProfLbl";
            agregarProfLbl.Size = new Size(226, 25);
            agregarProfLbl.TabIndex = 97;
            agregarProfLbl.Text = "EDITAR PROFESOR";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(5, 343);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 96;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(64, 9);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 95;
            SysacadLbl.Text = "SYSACAD";
            // 
            // FormEditarProf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 384);
            Controls.Add(direccionTextbox);
            Controls.Add(pictureBox1);
            Controls.Add(especializacionCombobox);
            Controls.Add(direccionLbl);
            Controls.Add(correoLbl);
            Controls.Add(correoTextbox);
            Controls.Add(especializacionLbl);
            Controls.Add(telefonoLbl);
            Controls.Add(nombreLbl);
            Controls.Add(telefonoTextbox);
            Controls.Add(nombreTextbox);
            Controls.Add(editarBtn);
            Controls.Add(agregarProfLbl);
            Controls.Add(backBtn);
            Controls.Add(SysacadLbl);
            Name = "FormEditarProf";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox direccionTextbox;
        private PictureBox pictureBox1;
        private ComboBox especializacionCombobox;
        private Label direccionLbl;
        private Label correoLbl;
        private TextBox correoTextbox;
        private Label especializacionLbl;
        private Label telefonoLbl;
        private Label nombreLbl;
        private TextBox telefonoTextbox;
        private TextBox nombreTextbox;
        private Button editarBtn;
        private Label agregarProfLbl;
        private Button backBtn;
        private Label SysacadLbl;
    }
}