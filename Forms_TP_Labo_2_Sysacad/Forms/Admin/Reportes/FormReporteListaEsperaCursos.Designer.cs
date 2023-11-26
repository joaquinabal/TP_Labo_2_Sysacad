namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    partial class FormReporteListaEsperaCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteListaEsperaCursos));
            cursoBindingSource1 = new BindingSource(components);
            registroDeInscripcionBindingSource = new BindingSource(components);
            cursoBindingSource = new BindingSource(components);
            ExportarPDFBtn = new Button();
            backBtn = new Button();
            pictureBox1 = new PictureBox();
            lbl = new Label();
            SysacadLbl = new Label();
            cursosLV = new ListView();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registroDeInscripcionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cursoBindingSource1
            // 
            cursoBindingSource1.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesPrimarias.Curso);
            // 
            // registroDeInscripcionBindingSource
            // 
            registroDeInscripcionBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesSecundarias.RegistroDeInscripcion);
            // 
            // cursoBindingSource
            // 
            cursoBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesPrimarias.Curso);
            // 
            // ExportarPDFBtn
            // 
            ExportarPDFBtn.AutoSize = true;
            ExportarPDFBtn.BackColor = Color.Goldenrod;
            ExportarPDFBtn.FlatStyle = FlatStyle.Flat;
            ExportarPDFBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExportarPDFBtn.Location = new Point(183, 276);
            ExportarPDFBtn.Name = "ExportarPDFBtn";
            ExportarPDFBtn.Size = new Size(144, 33);
            ExportarPDFBtn.TabIndex = 51;
            ExportarPDFBtn.Text = "Exportar PDF";
            ExportarPDFBtn.UseVisualStyleBackColor = false;
            ExportarPDFBtn.Click += ExportarPDFBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(1, 314);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 50;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(460, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(172, 94);
            lbl.Name = "lbl";
            lbl.Size = new Size(137, 29);
            lbl.TabIndex = 48;
            lbl.Text = "REPORTE";
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(151, 34);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 47;
            SysacadLbl.Text = "SYSACAD";
            // 
            // cursosLV
            // 
            cursosLV.Location = new Point(67, 141);
            cursosLV.Name = "cursosLV";
            cursosLV.Size = new Size(385, 97);
            cursosLV.TabIndex = 58;
            cursosLV.UseCompatibleStateImageBehavior = false;
            cursosLV.View = View.Details;
            // 
            // FormReporteListaEsperaCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 351);
            Controls.Add(cursosLV);
            Controls.Add(ExportarPDFBtn);
            Controls.Add(backBtn);
            Controls.Add(pictureBox1);
            Controls.Add(lbl);
            Controls.Add(SysacadLbl);
            Name = "FormReporteListaEsperaCursos";
            Text = "FormReporteListaEsperaCursos";
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)registroDeInscripcionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ExportarPDFBtn;
        private Button backBtn;
        private PictureBox pictureBox1;
        private Label lbl;
        private Label SysacadLbl;
        private BindingSource cursoBindingSource;
        private BindingSource registroDeInscripcionBindingSource;
        private BindingSource cursoBindingSource1;
        private ListView cursosLV;
    }
}