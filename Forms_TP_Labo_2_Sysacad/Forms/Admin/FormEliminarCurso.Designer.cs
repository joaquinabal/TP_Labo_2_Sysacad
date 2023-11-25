namespace Forms_TP_Labo_2_Sysacad
{
    partial class FormEliminarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminarCurso));
            descripcionTextbox = new RichTextBox();
            codigoLbl = new Label();
            nombreLbl = new Label();
            codigoTextbox = new TextBox();
            nombreTextbox = new TextBox();
            elliminarBtn = new Button();
            descripcionLbl = new Label();
            cupoMaxLbl = new Label();
            cupoMaxTextbox = new TextBox();
            editarCursoLbl = new Label();
            backBtn = new Button();
            SysacadLbl = new Label();
            baseDatosCursosBindingSource = new BindingSource(components);
            baseDatosCursosBindingSource1 = new BindingSource(components);
            cursosBindingSource = new BindingSource(components);
            cursosBindingSource1 = new BindingSource(components);
            aulaLbl = new Label();
            turnoLbl = new Label();
            aulaTextbox = new TextBox();
            turnoTextbox = new TextBox();
            diaLbl = new Label();
            diaTextbox = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)baseDatosCursosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baseDatosCursosBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // descripcionTextbox
            // 
            descripcionTextbox.Enabled = false;
            descripcionTextbox.Location = new Point(28, 288);
            descripcionTextbox.Name = "descripcionTextbox";
            descripcionTextbox.Size = new Size(274, 71);
            descripcionTextbox.TabIndex = 70;
            descripcionTextbox.Text = "";
            descripcionTextbox.TextChanged += descripcionTextbox_TextChanged;
            // 
            // codigoLbl
            // 
            codigoLbl.AutoSize = true;
            codigoLbl.Location = new Point(12, 156);
            codigoLbl.Name = "codigoLbl";
            codigoLbl.Size = new Size(49, 15);
            codigoLbl.TabIndex = 69;
            codigoLbl.Text = "Código:";
            // 
            // nombreLbl
            // 
            nombreLbl.AutoSize = true;
            nombreLbl.Location = new Point(12, 102);
            nombreLbl.Name = "nombreLbl";
            nombreLbl.Size = new Size(54, 15);
            nombreLbl.TabIndex = 68;
            nombreLbl.Text = "Nombre:";
            // 
            // codigoTextbox
            // 
            codigoTextbox.Enabled = false;
            codigoTextbox.Location = new Point(12, 174);
            codigoTextbox.Name = "codigoTextbox";
            codigoTextbox.Size = new Size(100, 23);
            codigoTextbox.TabIndex = 67;
            codigoTextbox.TextChanged += codigoTextbox_TextChanged;
            // 
            // nombreTextbox
            // 
            nombreTextbox.Enabled = false;
            nombreTextbox.Location = new Point(12, 120);
            nombreTextbox.Name = "nombreTextbox";
            nombreTextbox.Size = new Size(100, 23);
            nombreTextbox.TabIndex = 66;
            nombreTextbox.TextChanged += nombreTextbox_TextChanged;
            // 
            // elliminarBtn
            // 
            elliminarBtn.BackColor = Color.Goldenrod;
            elliminarBtn.FlatStyle = FlatStyle.Flat;
            elliminarBtn.Location = new Point(110, 381);
            elliminarBtn.Name = "elliminarBtn";
            elliminarBtn.Size = new Size(103, 23);
            elliminarBtn.TabIndex = 65;
            elliminarBtn.Text = "Eliminar";
            elliminarBtn.UseVisualStyleBackColor = false;
            elliminarBtn.Click += eliminarBtn_Click;
            // 
            // descripcionLbl
            // 
            descripcionLbl.AutoSize = true;
            descripcionLbl.Location = new Point(28, 270);
            descripcionLbl.Name = "descripcionLbl";
            descripcionLbl.Size = new Size(72, 15);
            descripcionLbl.TabIndex = 64;
            descripcionLbl.Text = "Descripción:";
            // 
            // cupoMaxLbl
            // 
            cupoMaxLbl.AutoSize = true;
            cupoMaxLbl.Location = new Point(12, 204);
            cupoMaxLbl.Name = "cupoMaxLbl";
            cupoMaxLbl.Size = new Size(86, 15);
            cupoMaxLbl.TabIndex = 63;
            cupoMaxLbl.Text = "Cupo Máximo:";
            // 
            // cupoMaxTextbox
            // 
            cupoMaxTextbox.Enabled = false;
            cupoMaxTextbox.Location = new Point(12, 222);
            cupoMaxTextbox.Name = "cupoMaxTextbox";
            cupoMaxTextbox.Size = new Size(100, 23);
            cupoMaxTextbox.TabIndex = 62;
            cupoMaxTextbox.TextChanged += cupoMaxTextbox_TextChanged;
            // 
            // editarCursoLbl
            // 
            editarCursoLbl.AutoSize = true;
            editarCursoLbl.Font = new Font("Lucida Sans", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            editarCursoLbl.Location = new Point(67, 60);
            editarCursoLbl.Name = "editarCursoLbl";
            editarCursoLbl.Size = new Size(198, 23);
            editarCursoLbl.TabIndex = 61;
            editarCursoLbl.Text = "ELIMINAR CURSO";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(5, 420);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 60;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(69, 10);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 59;
            SysacadLbl.Text = "SYSACAD";
            // 
            // baseDatosCursosBindingSource
            // 
            baseDatosCursosBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesPrimarias.Curso);
            // 
            // baseDatosCursosBindingSource1
            // 
            baseDatosCursosBindingSource1.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesPrimarias.Curso);
            // 
            // cursosBindingSource
            // 
            cursosBindingSource.DataMember = "Cursos";
            cursosBindingSource.DataSource = baseDatosCursosBindingSource;
            // 
            // cursosBindingSource1
            // 
            cursosBindingSource1.DataMember = "Cursos";
            cursosBindingSource1.DataSource = baseDatosCursosBindingSource;
            // 
            // aulaLbl
            // 
            aulaLbl.AutoSize = true;
            aulaLbl.Location = new Point(217, 156);
            aulaLbl.Name = "aulaLbl";
            aulaLbl.Size = new Size(34, 15);
            aulaLbl.TabIndex = 76;
            aulaLbl.Text = "Aula:";
            // 
            // turnoLbl
            // 
            turnoLbl.AutoSize = true;
            turnoLbl.Location = new Point(217, 102);
            turnoLbl.Name = "turnoLbl";
            turnoLbl.Size = new Size(41, 15);
            turnoLbl.TabIndex = 75;
            turnoLbl.Text = "Turno:";
            // 
            // aulaTextbox
            // 
            aulaTextbox.Enabled = false;
            aulaTextbox.Location = new Point(217, 174);
            aulaTextbox.Name = "aulaTextbox";
            aulaTextbox.Size = new Size(100, 23);
            aulaTextbox.TabIndex = 74;
            aulaTextbox.TextChanged += aulaTextbox_TextChanged;
            // 
            // turnoTextbox
            // 
            turnoTextbox.Enabled = false;
            turnoTextbox.Location = new Point(217, 120);
            turnoTextbox.Name = "turnoTextbox";
            turnoTextbox.Size = new Size(100, 23);
            turnoTextbox.TabIndex = 73;
            turnoTextbox.TextChanged += turnoTextbox_TextChanged;
            // 
            // diaLbl
            // 
            diaLbl.AutoSize = true;
            diaLbl.Location = new Point(217, 204);
            diaLbl.Name = "diaLbl";
            diaLbl.Size = new Size(27, 15);
            diaLbl.TabIndex = 72;
            diaLbl.Text = "Día:";
            // 
            // diaTextbox
            // 
            diaTextbox.Enabled = false;
            diaTextbox.Location = new Point(217, 222);
            diaTextbox.Name = "diaTextbox";
            diaTextbox.Size = new Size(100, 23);
            diaTextbox.TabIndex = 71;
            diaTextbox.TextChanged += diaTextbox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(279, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 77;
            pictureBox1.TabStop = false;
            // 
            // FormEliminarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 459);
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
            Controls.Add(elliminarBtn);
            Controls.Add(descripcionLbl);
            Controls.Add(cupoMaxLbl);
            Controls.Add(cupoMaxTextbox);
            Controls.Add(editarCursoLbl);
            Controls.Add(backBtn);
            Controls.Add(SysacadLbl);
            Name = "FormEliminarCurso";
            Text = "";
            ((System.ComponentModel.ISupportInitialize)baseDatosCursosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)baseDatosCursosBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource1).EndInit();
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
        private Button elliminarBtn;
        private Label descripcionLbl;
        private Label cupoMaxLbl;
        private TextBox cupoMaxTextbox;
        private Label editarCursoLbl;
        private Button backBtn;
        private Label SysacadLbl;
        private BindingSource baseDatosCursosBindingSource;
        private BindingSource cursosBindingSource;
        private BindingSource baseDatosCursosBindingSource1;
        private BindingSource cursosBindingSource1;
        private Label aulaLbl;
        private Label turnoLbl;
        private TextBox aulaTextbox;
        private TextBox turnoTextbox;
        private Label diaLbl;
        private TextBox diaTextbox;
        private PictureBox pictureBox1;
    }
}