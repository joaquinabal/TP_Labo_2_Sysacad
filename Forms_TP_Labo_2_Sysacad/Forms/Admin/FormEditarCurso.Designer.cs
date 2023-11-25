namespace Forms_TP_Labo_2_Sysacad
{
    partial class FormEditarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarCurso));
            descripcionTextbox = new RichTextBox();
            codigoLbl = new Label();
            nombreLbl = new Label();
            codigoTextbox = new TextBox();
            nombreTextbox = new TextBox();
            editarBtn = new Button();
            descripcionLbl = new Label();
            cupoMaxLbl = new Label();
            cupoMaxTextbox = new TextBox();
            editarCursoLbl = new Label();
            backBtn = new Button();
            SysacadLbl = new Label();
            aulaLbl = new Label();
            turnoLbl = new Label();
            aulaTextbox = new TextBox();
            diaLbl = new Label();
            diaCombobox = new ComboBox();
            turnoCombobox = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // descripcionTextbox
            // 
            descripcionTextbox.Location = new Point(30, 293);
            descripcionTextbox.Name = "descripcionTextbox";
            descripcionTextbox.Size = new Size(274, 71);
            descripcionTextbox.TabIndex = 58;
            descripcionTextbox.Text = "";
            descripcionTextbox.TextChanged += descripcionTextbox_TextChanged;
            // 
            // codigoLbl
            // 
            codigoLbl.AutoSize = true;
            codigoLbl.Location = new Point(12, 155);
            codigoLbl.Name = "codigoLbl";
            codigoLbl.Size = new Size(49, 15);
            codigoLbl.TabIndex = 57;
            codigoLbl.Text = "Código:";
            // 
            // nombreLbl
            // 
            nombreLbl.AutoSize = true;
            nombreLbl.Location = new Point(12, 101);
            nombreLbl.Name = "nombreLbl";
            nombreLbl.Size = new Size(54, 15);
            nombreLbl.TabIndex = 56;
            nombreLbl.Text = "Nombre:";
            // 
            // codigoTextbox
            // 
            codigoTextbox.Location = new Point(12, 173);
            codigoTextbox.Name = "codigoTextbox";
            codigoTextbox.Size = new Size(100, 23);
            codigoTextbox.TabIndex = 55;
            codigoTextbox.TextChanged += codigoTextbox_TextChanged;
            // 
            // nombreTextbox
            // 
            nombreTextbox.Location = new Point(12, 119);
            nombreTextbox.Name = "nombreTextbox";
            nombreTextbox.Size = new Size(100, 23);
            nombreTextbox.TabIndex = 54;
            nombreTextbox.TextChanged += nombreTextbox_TextChanged;
            // 
            // editarBtn
            // 
            editarBtn.BackColor = Color.Goldenrod;
            editarBtn.FlatStyle = FlatStyle.Flat;
            editarBtn.Location = new Point(122, 380);
            editarBtn.Name = "editarBtn";
            editarBtn.Size = new Size(103, 23);
            editarBtn.TabIndex = 53;
            editarBtn.Text = "Editar";
            editarBtn.UseVisualStyleBackColor = false;
            editarBtn.Click += editarBtn_Click;
            // 
            // descripcionLbl
            // 
            descripcionLbl.AutoSize = true;
            descripcionLbl.Location = new Point(30, 275);
            descripcionLbl.Name = "descripcionLbl";
            descripcionLbl.Size = new Size(72, 15);
            descripcionLbl.TabIndex = 52;
            descripcionLbl.Text = "Descripción:";
            // 
            // cupoMaxLbl
            // 
            cupoMaxLbl.AutoSize = true;
            cupoMaxLbl.Location = new Point(12, 203);
            cupoMaxLbl.Name = "cupoMaxLbl";
            cupoMaxLbl.Size = new Size(86, 15);
            cupoMaxLbl.TabIndex = 51;
            cupoMaxLbl.Text = "Cupo Máximo:";
            // 
            // cupoMaxTextbox
            // 
            cupoMaxTextbox.Location = new Point(12, 221);
            cupoMaxTextbox.Name = "cupoMaxTextbox";
            cupoMaxTextbox.Size = new Size(100, 23);
            cupoMaxTextbox.TabIndex = 50;
            cupoMaxTextbox.TextChanged += cupoMaxTextbox_TextChanged;
            // 
            // editarCursoLbl
            // 
            editarCursoLbl.AutoSize = true;
            editarCursoLbl.Font = new Font("Lucida Sans", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            editarCursoLbl.Location = new Point(77, 68);
            editarCursoLbl.Name = "editarCursoLbl";
            editarCursoLbl.Size = new Size(174, 23);
            editarCursoLbl.TabIndex = 49;
            editarCursoLbl.Text = "EDITAR CURSO";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(6, 414);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 48;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(72, 10);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 47;
            SysacadLbl.Text = "SYSACAD";
            // 
            // aulaLbl
            // 
            aulaLbl.AutoSize = true;
            aulaLbl.Location = new Point(217, 155);
            aulaLbl.Name = "aulaLbl";
            aulaLbl.Size = new Size(34, 15);
            aulaLbl.TabIndex = 64;
            aulaLbl.Text = "Aula:";
            // 
            // turnoLbl
            // 
            turnoLbl.AutoSize = true;
            turnoLbl.Location = new Point(217, 101);
            turnoLbl.Name = "turnoLbl";
            turnoLbl.Size = new Size(41, 15);
            turnoLbl.TabIndex = 63;
            turnoLbl.Text = "Turno:";
            // 
            // aulaTextbox
            // 
            aulaTextbox.Location = new Point(217, 173);
            aulaTextbox.Name = "aulaTextbox";
            aulaTextbox.Size = new Size(100, 23);
            aulaTextbox.TabIndex = 62;
            aulaTextbox.TextChanged += aulaTextbox_TextChanged;
            // 
            // diaLbl
            // 
            diaLbl.AutoSize = true;
            diaLbl.Location = new Point(217, 203);
            diaLbl.Name = "diaLbl";
            diaLbl.Size = new Size(27, 15);
            diaLbl.TabIndex = 60;
            diaLbl.Text = "Día:";
            // 
            // diaCombobox
            // 
            diaCombobox.FormattingEnabled = true;
            diaCombobox.Items.AddRange(new object[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" });
            diaCombobox.Location = new Point(217, 221);
            diaCombobox.Name = "diaCombobox";
            diaCombobox.Size = new Size(98, 23);
            diaCombobox.TabIndex = 75;
            diaCombobox.SelectedIndexChanged += diaCombobox_SelectedIndexChanged;
            // 
            // turnoCombobox
            // 
            turnoCombobox.FormattingEnabled = true;
            turnoCombobox.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            turnoCombobox.Location = new Point(217, 119);
            turnoCombobox.Name = "turnoCombobox";
            turnoCombobox.Size = new Size(100, 23);
            turnoCombobox.TabIndex = 74;
            turnoCombobox.SelectedIndexChanged += turnoCombobox_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(280, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            // 
            // FormEditarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 457);
            Controls.Add(pictureBox1);
            Controls.Add(diaCombobox);
            Controls.Add(turnoCombobox);
            Controls.Add(aulaLbl);
            Controls.Add(turnoLbl);
            Controls.Add(aulaTextbox);
            Controls.Add(diaLbl);
            Controls.Add(descripcionTextbox);
            Controls.Add(codigoLbl);
            Controls.Add(nombreLbl);
            Controls.Add(codigoTextbox);
            Controls.Add(nombreTextbox);
            Controls.Add(editarBtn);
            Controls.Add(descripcionLbl);
            Controls.Add(cupoMaxLbl);
            Controls.Add(cupoMaxTextbox);
            Controls.Add(editarCursoLbl);
            Controls.Add(backBtn);
            Controls.Add(SysacadLbl);
            Name = "FormEditarCurso";
            Text = "FormEditarCurso";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox descripcionTextbox;
        private Label codigoLbl;
        private Label nombreLbl;
        private TextBox codigoTextbox;
        private TextBox nombreTextbox;
        private Button editarBtn;
        private Label descripcionLbl;
        private Label cupoMaxLbl;
        private TextBox cupoMaxTextbox;
        private Label editarCursoLbl;
        private Button backBtn;
        private Label SysacadLbl;
        private Label aulaLbl;
        private Label turnoLbl;
        private TextBox aulaTextbox;
        private Label diaLbl;
        private ComboBox diaCombobox;
        private ComboBox turnoCombobox;
        private PictureBox pictureBox1;
    }
}