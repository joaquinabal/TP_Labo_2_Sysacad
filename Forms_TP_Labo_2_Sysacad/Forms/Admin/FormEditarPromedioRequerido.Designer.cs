namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    partial class FormEditarPromedioRequerido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarPromedioRequerido));
            pictureBox1 = new PictureBox();
            aulaLbl = new Label();
            turnoLbl = new Label();
            aulaTextbox = new TextBox();
            turnoTextbox = new TextBox();
            diaLbl = new Label();
            diaTextbox = new TextBox();
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
            promRequeridoTextBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(269, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 96;
            pictureBox1.TabStop = false;
            // 
            // aulaLbl
            // 
            aulaLbl.AutoSize = true;
            aulaLbl.Location = new Point(217, 157);
            aulaLbl.Name = "aulaLbl";
            aulaLbl.Size = new Size(34, 15);
            aulaLbl.TabIndex = 95;
            aulaLbl.Text = "Aula:";
            // 
            // turnoLbl
            // 
            turnoLbl.AutoSize = true;
            turnoLbl.Location = new Point(217, 103);
            turnoLbl.Name = "turnoLbl";
            turnoLbl.Size = new Size(41, 15);
            turnoLbl.TabIndex = 94;
            turnoLbl.Text = "Turno:";
            // 
            // aulaTextbox
            // 
            aulaTextbox.Enabled = false;
            aulaTextbox.Location = new Point(217, 175);
            aulaTextbox.Name = "aulaTextbox";
            aulaTextbox.Size = new Size(100, 23);
            aulaTextbox.TabIndex = 93;
            aulaTextbox.TextChanged += aulaTextbox_TextChanged;
            // 
            // turnoTextbox
            // 
            turnoTextbox.Enabled = false;
            turnoTextbox.Location = new Point(217, 121);
            turnoTextbox.Name = "turnoTextbox";
            turnoTextbox.Size = new Size(100, 23);
            turnoTextbox.TabIndex = 92;
            turnoTextbox.TextChanged += turnoTextbox_TextChanged;
            // 
            // diaLbl
            // 
            diaLbl.AutoSize = true;
            diaLbl.Location = new Point(217, 205);
            diaLbl.Name = "diaLbl";
            diaLbl.Size = new Size(27, 15);
            diaLbl.TabIndex = 91;
            diaLbl.Text = "Día:";
            // 
            // diaTextbox
            // 
            diaTextbox.Enabled = false;
            diaTextbox.Location = new Point(217, 223);
            diaTextbox.Name = "diaTextbox";
            diaTextbox.Size = new Size(100, 23);
            diaTextbox.TabIndex = 90;
            diaTextbox.TextChanged += diaTextbox_TextChanged;
            // 
            // descripcionTextbox
            // 
            descripcionTextbox.Enabled = false;
            descripcionTextbox.Location = new Point(28, 289);
            descripcionTextbox.Name = "descripcionTextbox";
            descripcionTextbox.Size = new Size(274, 71);
            descripcionTextbox.TabIndex = 89;
            descripcionTextbox.Text = "";
            descripcionTextbox.TextChanged += descripcionTextbox_TextChanged;
            // 
            // codigoLbl
            // 
            codigoLbl.AutoSize = true;
            codigoLbl.Location = new Point(12, 157);
            codigoLbl.Name = "codigoLbl";
            codigoLbl.Size = new Size(49, 15);
            codigoLbl.TabIndex = 88;
            codigoLbl.Text = "Código:";
            // 
            // nombreLbl
            // 
            nombreLbl.AutoSize = true;
            nombreLbl.Location = new Point(12, 103);
            nombreLbl.Name = "nombreLbl";
            nombreLbl.Size = new Size(54, 15);
            nombreLbl.TabIndex = 87;
            nombreLbl.Text = "Nombre:";
            // 
            // codigoTextbox
            // 
            codigoTextbox.Enabled = false;
            codigoTextbox.Location = new Point(12, 175);
            codigoTextbox.Name = "codigoTextbox";
            codigoTextbox.Size = new Size(100, 23);
            codigoTextbox.TabIndex = 86;
            codigoTextbox.TextChanged += codigoTextbox_TextChanged;
            // 
            // nombreTextbox
            // 
            nombreTextbox.Enabled = false;
            nombreTextbox.Location = new Point(12, 121);
            nombreTextbox.Name = "nombreTextbox";
            nombreTextbox.Size = new Size(100, 23);
            nombreTextbox.TabIndex = 85;
            nombreTextbox.TextChanged += nombreTextbox_TextChanged;
            // 
            // editarBtn
            // 
            editarBtn.BackColor = Color.Goldenrod;
            editarBtn.FlatStyle = FlatStyle.Flat;
            editarBtn.Location = new Point(103, 440);
            editarBtn.Name = "editarBtn";
            editarBtn.Size = new Size(103, 23);
            editarBtn.TabIndex = 84;
            editarBtn.Text = "Editar";
            editarBtn.UseVisualStyleBackColor = false;
            editarBtn.Click += editarBtn_Click;
            // 
            // descripcionLbl
            // 
            descripcionLbl.AutoSize = true;
            descripcionLbl.Location = new Point(28, 271);
            descripcionLbl.Name = "descripcionLbl";
            descripcionLbl.Size = new Size(72, 15);
            descripcionLbl.TabIndex = 83;
            descripcionLbl.Text = "Descripción:";
            // 
            // cupoMaxLbl
            // 
            cupoMaxLbl.AutoSize = true;
            cupoMaxLbl.Location = new Point(12, 205);
            cupoMaxLbl.Name = "cupoMaxLbl";
            cupoMaxLbl.Size = new Size(86, 15);
            cupoMaxLbl.TabIndex = 82;
            cupoMaxLbl.Text = "Cupo Máximo:";
            // 
            // cupoMaxTextbox
            // 
            cupoMaxTextbox.Enabled = false;
            cupoMaxTextbox.Location = new Point(12, 223);
            cupoMaxTextbox.Name = "cupoMaxTextbox";
            cupoMaxTextbox.Size = new Size(100, 23);
            cupoMaxTextbox.TabIndex = 81;
            cupoMaxTextbox.TextChanged += cupoMaxTextbox_TextChanged;
            // 
            // editarCursoLbl
            // 
            editarCursoLbl.AutoSize = true;
            editarCursoLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            editarCursoLbl.Location = new Point(57, 59);
            editarCursoLbl.Name = "editarCursoLbl";
            editarCursoLbl.Size = new Size(222, 25);
            editarCursoLbl.TabIndex = 80;
            editarCursoLbl.Text = "EDITAR PROMEDIO";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(5, 460);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 79;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(59, 9);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 78;
            SysacadLbl.Text = "SYSACAD";
            // 
            // promRequeridoTextBox
            // 
            promRequeridoTextBox.Location = new Point(103, 397);
            promRequeridoTextBox.Name = "promRequeridoTextBox";
            promRequeridoTextBox.Size = new Size(100, 23);
            promRequeridoTextBox.TabIndex = 97;
            promRequeridoTextBox.TextChanged += promRequeridoTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 379);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 98;
            label1.Text = "Promedio Requerido:";
            // 
            // FormEditarPromedioRequerido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 498);
            Controls.Add(label1);
            Controls.Add(promRequeridoTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(aulaLbl);
            Controls.Add(turnoLbl);
            Controls.Add(aulaTextbox);
            Controls.Add(turnoTextbox);
            Controls.Add(diaLbl);
            Controls.Add(diaTextbox);
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
            Name = "FormEditarPromedioRequerido";
            Text = "FormEditarPromedioRequerido";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label aulaLbl;
        private Label turnoLbl;
        private TextBox aulaTextbox;
        private TextBox turnoTextbox;
        private Label diaLbl;
        private TextBox diaTextbox;
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
        private TextBox promRequeridoTextBox;
        private Label label1;
    }
}