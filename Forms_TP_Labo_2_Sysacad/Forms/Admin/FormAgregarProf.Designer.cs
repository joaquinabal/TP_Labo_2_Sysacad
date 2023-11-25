namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    partial class FormAgregarProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarProf));
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
            agregarBtn = new Button();
            agregarProfLbl = new Label();
            backBtn = new Button();
            SysacadLbl = new Label();
            direccionTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(275, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 93;
            pictureBox1.TabStop = false;
            // 
            // especializacionCombobox
            // 
            especializacionCombobox.FormattingEnabled = true;
            especializacionCombobox.Items.AddRange(new object[] { "Esp 1", "Esp 2", "Esp 3", "Esp 4" });
            especializacionCombobox.Location = new Point(119, 239);
            especializacionCombobox.Name = "especializacionCombobox";
            especializacionCombobox.Size = new Size(98, 23);
            especializacionCombobox.TabIndex = 92;
            especializacionCombobox.SelectedIndexChanged += especializacionCombobox_SelectedIndexChanged_1;
            // 
            // direccionLbl
            // 
            direccionLbl.AutoSize = true;
            direccionLbl.Location = new Point(217, 107);
            direccionLbl.Name = "direccionLbl";
            direccionLbl.Size = new Size(60, 15);
            direccionLbl.TabIndex = 90;
            direccionLbl.Text = "Dirección:";
            // 
            // correoLbl
            // 
            correoLbl.AutoSize = true;
            correoLbl.Location = new Point(217, 161);
            correoLbl.Name = "correoLbl";
            correoLbl.Size = new Size(46, 15);
            correoLbl.TabIndex = 89;
            correoLbl.Text = "Correo:";
            // 
            // correoTextbox
            // 
            correoTextbox.Location = new Point(217, 179);
            correoTextbox.Name = "correoTextbox";
            correoTextbox.Size = new Size(100, 23);
            correoTextbox.TabIndex = 88;
            correoTextbox.TextChanged += correoTextbox_TextChanged_1;
            // 
            // especializacionLbl
            // 
            especializacionLbl.AutoSize = true;
            especializacionLbl.Location = new Point(119, 221);
            especializacionLbl.Name = "especializacionLbl";
            especializacionLbl.Size = new Size(27, 15);
            especializacionLbl.TabIndex = 87;
            especializacionLbl.Text = "Día:";
            // 
            // telefonoLbl
            // 
            telefonoLbl.AutoSize = true;
            telefonoLbl.Location = new Point(8, 161);
            telefonoLbl.Name = "telefonoLbl";
            telefonoLbl.Size = new Size(55, 15);
            telefonoLbl.TabIndex = 85;
            telefonoLbl.Text = "Télefono:";
            // 
            // nombreLbl
            // 
            nombreLbl.AutoSize = true;
            nombreLbl.Location = new Point(8, 107);
            nombreLbl.Name = "nombreLbl";
            nombreLbl.Size = new Size(54, 15);
            nombreLbl.TabIndex = 84;
            nombreLbl.Text = "Nombre:";
            // 
            // telefonoTextbox
            // 
            telefonoTextbox.Location = new Point(8, 179);
            telefonoTextbox.Name = "telefonoTextbox";
            telefonoTextbox.Size = new Size(100, 23);
            telefonoTextbox.TabIndex = 83;
            telefonoTextbox.TextChanged += telefonoTextbox_TextChanged_1;
            // 
            // nombreTextbox
            // 
            nombreTextbox.Location = new Point(8, 125);
            nombreTextbox.Name = "nombreTextbox";
            nombreTextbox.Size = new Size(100, 23);
            nombreTextbox.TabIndex = 82;
            nombreTextbox.TextChanged += nombreTextbox_TextChanged;
            // 
            // agregarBtn
            // 
            agregarBtn.BackColor = Color.Goldenrod;
            agregarBtn.FlatStyle = FlatStyle.Flat;
            agregarBtn.Location = new Point(114, 284);
            agregarBtn.Name = "agregarBtn";
            agregarBtn.Size = new Size(103, 23);
            agregarBtn.TabIndex = 81;
            agregarBtn.Text = "Agregar";
            agregarBtn.UseVisualStyleBackColor = false;
            agregarBtn.Click += agregarBtn_Click;
            // 
            // agregarProfLbl
            // 
            agregarProfLbl.AutoSize = true;
            agregarProfLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            agregarProfLbl.Location = new Point(54, 69);
            agregarProfLbl.Name = "agregarProfLbl";
            agregarProfLbl.Size = new Size(255, 25);
            agregarProfLbl.TabIndex = 77;
            agregarProfLbl.Text = "AGREGAR PROFESOR";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(2, 343);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 76;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(61, 9);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 75;
            SysacadLbl.Text = "SYSACAD";
            // 
            // direccionTextbox
            // 
            direccionTextbox.Location = new Point(221, 125);
            direccionTextbox.Name = "direccionTextbox";
            direccionTextbox.Size = new Size(100, 23);
            direccionTextbox.TabIndex = 94;
            direccionTextbox.TextChanged += direccionTextbox_TextChanged_1;
            // 
            // FormAgregarProf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 380);
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
            Controls.Add(agregarBtn);
            Controls.Add(agregarProfLbl);
            Controls.Add(backBtn);
            Controls.Add(SysacadLbl);
            Name = "FormAgregarProf";
            Text = "FormAgregarProf";
            Load += FormAgregarProf_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox especializacionCombobox;
        private ComboBox turnoCombobox;
        private Label direccionLbl;
        private Label correoLbl;
        private TextBox correoTextbox;
        private Label especializacionLbl;
        private RichTextBox descripcionTextbox;
        private Label telefonoLbl;
        private Label nombreLbl;
        private TextBox telefonoTextbox;
        private TextBox nombreTextbox;
        private Button agregarBtn;
        private Label descripcionLbl;
        private Label cupoMaxLbl;
        private TextBox cupoMaxTextbox;
        private Label agregarProfLbl;
        private Button backBtn;
        private Label SysacadLbl;
        private TextBox direccionTextbox;
    }
}