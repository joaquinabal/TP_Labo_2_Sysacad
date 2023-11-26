namespace Forms_TP_Labo_2_Sysacad
{
    partial class FormAgregarCurso
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarCurso));
            codigoLbl = new Label();
            nombreLbl = new Label();
            codigoTextbox = new TextBox();
            nombreTextbox = new TextBox();
            agregarBtn = new Button();
            agregarCursoLbl = new Label();
            backBtn = new Button();
            SysacadLbl = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            aulaLbl = new Label();
            aulaTextbox = new TextBox();
            diaLbl = new Label();
            turnoLbl = new Label();
            turnoCombobox = new ComboBox();
            diaCombobox = new ComboBox();
            pictureBox1 = new PictureBox();
            descripcionLbl = new Label();
            descripcionTextbox = new RichTextBox();
            cupoMaxTextbox = new TextBox();
            cupoMaxLbl = new Label();
            carreraComboBox = new ComboBox();
            Carrera = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // codigoLbl
            // 
            codigoLbl.AutoSize = true;
            codigoLbl.Location = new Point(12, 161);
            codigoLbl.Name = "codigoLbl";
            codigoLbl.Size = new Size(49, 15);
            codigoLbl.TabIndex = 38;
            codigoLbl.Text = "Código:";
            // 
            // nombreLbl
            // 
            nombreLbl.AutoSize = true;
            nombreLbl.Location = new Point(12, 107);
            nombreLbl.Name = "nombreLbl";
            nombreLbl.Size = new Size(54, 15);
            nombreLbl.TabIndex = 37;
            nombreLbl.Text = "Nombre:";
            // 
            // codigoTextbox
            // 
            codigoTextbox.Location = new Point(12, 179);
            codigoTextbox.Name = "codigoTextbox";
            codigoTextbox.Size = new Size(100, 23);
            codigoTextbox.TabIndex = 36;
            codigoTextbox.TextChanged += codigoTextbox_TextChanged_1;
            // 
            // nombreTextbox
            // 
            nombreTextbox.Location = new Point(12, 125);
            nombreTextbox.Name = "nombreTextbox";
            nombreTextbox.Size = new Size(100, 23);
            nombreTextbox.TabIndex = 35;
            nombreTextbox.TextChanged += nombreTextbox_TextChanged_1;
            // 
            // agregarBtn
            // 
            agregarBtn.BackColor = Color.Goldenrod;
            agregarBtn.FlatStyle = FlatStyle.Flat;
            agregarBtn.Location = new Point(123, 417);
            agregarBtn.Name = "agregarBtn";
            agregarBtn.Size = new Size(103, 23);
            agregarBtn.TabIndex = 34;
            agregarBtn.Text = "Agregar";
            agregarBtn.UseVisualStyleBackColor = false;
            agregarBtn.Click += agregarBtn_Click;
            // 
            // agregarCursoLbl
            // 
            agregarCursoLbl.AutoSize = true;
            agregarCursoLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            agregarCursoLbl.Location = new Point(74, 69);
            agregarCursoLbl.Name = "agregarCursoLbl";
            agregarCursoLbl.Size = new Size(210, 25);
            agregarCursoLbl.TabIndex = 29;
            agregarCursoLbl.Text = "AGREGAR CURSO";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(7, 416);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 28;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(65, 9);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 27;
            SysacadLbl.Text = "SYSACAD";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // aulaLbl
            // 
            aulaLbl.AutoSize = true;
            aulaLbl.Location = new Point(221, 161);
            aulaLbl.Name = "aulaLbl";
            aulaLbl.Size = new Size(34, 15);
            aulaLbl.TabIndex = 69;
            aulaLbl.Text = "Aula:";
            // 
            // aulaTextbox
            // 
            aulaTextbox.Location = new Point(221, 179);
            aulaTextbox.Name = "aulaTextbox";
            aulaTextbox.Size = new Size(100, 23);
            aulaTextbox.TabIndex = 68;
            aulaTextbox.TextChanged += aulaTextbox_TextChanged;
            // 
            // diaLbl
            // 
            diaLbl.AutoSize = true;
            diaLbl.Location = new Point(221, 209);
            diaLbl.Name = "diaLbl";
            diaLbl.Size = new Size(27, 15);
            diaLbl.TabIndex = 66;
            diaLbl.Text = "Día:";
            // 
            // turnoLbl
            // 
            turnoLbl.AutoSize = true;
            turnoLbl.Location = new Point(221, 107);
            turnoLbl.Name = "turnoLbl";
            turnoLbl.Size = new Size(41, 15);
            turnoLbl.TabIndex = 70;
            turnoLbl.Text = "Turno:";
            // 
            // turnoCombobox
            // 
            turnoCombobox.FormattingEnabled = true;
            turnoCombobox.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            turnoCombobox.Location = new Point(221, 125);
            turnoCombobox.Name = "turnoCombobox";
            turnoCombobox.Size = new Size(100, 23);
            turnoCombobox.TabIndex = 71;
            turnoCombobox.SelectedIndexChanged += turnoCombobox_SelectedIndexChanged;
            // 
            // diaCombobox
            // 
            diaCombobox.FormattingEnabled = true;
            diaCombobox.Items.AddRange(new object[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" });
            diaCombobox.Location = new Point(221, 227);
            diaCombobox.Name = "diaCombobox";
            diaCombobox.Size = new Size(98, 23);
            diaCombobox.TabIndex = 73;
            diaCombobox.SelectedIndexChanged += diaCombobox_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(279, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 74;
            pictureBox1.TabStop = false;
            // 
            // descripcionLbl
            // 
            descripcionLbl.AutoSize = true;
            descripcionLbl.Location = new Point(31, 312);
            descripcionLbl.Name = "descripcionLbl";
            descripcionLbl.Size = new Size(72, 15);
            descripcionLbl.TabIndex = 33;
            descripcionLbl.Text = "Descripción:";
            // 
            // descripcionTextbox
            // 
            descripcionTextbox.Location = new Point(31, 330);
            descripcionTextbox.Name = "descripcionTextbox";
            descripcionTextbox.Size = new Size(274, 71);
            descripcionTextbox.TabIndex = 46;
            descripcionTextbox.Text = "";
            descripcionTextbox.TextChanged += descripcionTextbox_TextChanged_1;
            // 
            // cupoMaxTextbox
            // 
            cupoMaxTextbox.Location = new Point(12, 227);
            cupoMaxTextbox.Name = "cupoMaxTextbox";
            cupoMaxTextbox.Size = new Size(100, 23);
            cupoMaxTextbox.TabIndex = 30;
            cupoMaxTextbox.TextChanged += cupoMaxTextbox_TextChanged_1;
            // 
            // cupoMaxLbl
            // 
            cupoMaxLbl.AutoSize = true;
            cupoMaxLbl.Location = new Point(12, 209);
            cupoMaxLbl.Name = "cupoMaxLbl";
            cupoMaxLbl.Size = new Size(86, 15);
            cupoMaxLbl.TabIndex = 32;
            cupoMaxLbl.Text = "Cupo Máximo:";
            // 
            // carreraComboBox
            // 
            carreraComboBox.FormattingEnabled = true;
            carreraComboBox.Items.AddRange(new object[] { "TUP", "TUSI" });
            carreraComboBox.Location = new Point(110, 286);
            carreraComboBox.Name = "carreraComboBox";
            carreraComboBox.Size = new Size(106, 23);
            carreraComboBox.TabIndex = 75;
            carreraComboBox.SelectedIndexChanged += carreraComboBox_SelectedIndexChanged;
            // 
            // Carrera
            // 
            Carrera.AutoSize = true;
            Carrera.Location = new Point(110, 268);
            Carrera.Name = "Carrera";
            Carrera.Size = new Size(48, 15);
            Carrera.TabIndex = 76;
            Carrera.Text = "Carrera:";
            // 
            // FormAgregarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 457);
            Controls.Add(Carrera);
            Controls.Add(carreraComboBox);
            Controls.Add(pictureBox1);
            Controls.Add(diaCombobox);
            Controls.Add(turnoCombobox);
            Controls.Add(turnoLbl);
            Controls.Add(aulaLbl);
            Controls.Add(aulaTextbox);
            Controls.Add(diaLbl);
            Controls.Add(descripcionTextbox);
            Controls.Add(codigoLbl);
            Controls.Add(nombreLbl);
            Controls.Add(codigoTextbox);
            Controls.Add(nombreTextbox);
            Controls.Add(agregarBtn);
            Controls.Add(descripcionLbl);
            Controls.Add(cupoMaxLbl);
            Controls.Add(cupoMaxTextbox);
            Controls.Add(agregarCursoLbl);
            Controls.Add(backBtn);
            Controls.Add(SysacadLbl);
            Name = "FormAgregarCurso";
            Load += FormAgregarCurso_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label codigoLbl;
        private Label nombreLbl;
        private TextBox codigoTextbox;
        private TextBox nombreTextbox;
        private Button agregarBtn;
        private Label agregarCursoLbl;
        private Button backBtn;
        private Label SysacadLbl;
        private ContextMenuStrip contextMenuStrip1;
        private Label aulaLbl;
        private TextBox aulaTextbox;
        private Label diaLbl;
        private Label turnoLbl;
        private ComboBox turnoCombobox;
        private ComboBox diaCombobox;
        private PictureBox pictureBox1;
        private Label descripcionLbl;
        private RichTextBox descripcionTextbox;
        private TextBox cupoMaxTextbox;
        private Label cupoMaxLbl;
        private ComboBox carreraComboBox;
        private Label Carrera;
    }
}