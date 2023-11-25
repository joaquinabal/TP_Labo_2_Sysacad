namespace Forms_TP_Labo_2_Sysacad
{
    partial class FormConsultarHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarHorario));
            SysacadLbl = new Label();
            horariosDGV = new DataGridView();
            dias = new DataGridViewTextBoxColumn();
            Mañana = new DataGridViewTextBoxColumn();
            Tarde = new DataGridViewTextBoxColumn();
            Noche = new DataGridViewTextBoxColumn();
            cursosInscriptosBindingSource = new BindingSource(components);
            estudianteBindingSource = new BindingSource(components);
            backBtn = new Button();
            estudiantesInscriptosBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            estLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)horariosDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosInscriptosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estudianteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estudiantesInscriptosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(234, 9);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 28;
            SysacadLbl.Text = "SYSACAD";
            // 
            // horariosDGV
            // 
            horariosDGV.AllowUserToAddRows = false;
            horariosDGV.AllowUserToDeleteRows = false;
            horariosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            horariosDGV.Columns.AddRange(new DataGridViewColumn[] { dias, Mañana, Tarde, Noche });
            horariosDGV.Location = new Point(121, 120);
            horariosDGV.Name = "horariosDGV";
            horariosDGV.ReadOnly = true;
            horariosDGV.RowTemplate.Height = 25;
            horariosDGV.Size = new Size(443, 249);
            horariosDGV.TabIndex = 29;
            // 
            // dias
            // 
            dias.HeaderText = "Días";
            dias.Name = "dias";
            dias.ReadOnly = true;
            // 
            // Mañana
            // 
            Mañana.HeaderText = "Turno Mañana";
            Mañana.Name = "Mañana";
            Mañana.ReadOnly = true;
            // 
            // Tarde
            // 
            Tarde.HeaderText = "Turno Tarde";
            Tarde.Name = "Tarde";
            Tarde.ReadOnly = true;
            // 
            // Noche
            // 
            Noche.HeaderText = "Turno Noche";
            Noche.Name = "Noche";
            Noche.ReadOnly = true;
            // 
            // cursosInscriptosBindingSource
            // 
            cursosInscriptosBindingSource.DataMember = "CursosInscriptos";
            cursosInscriptosBindingSource.DataSource = estudianteBindingSource;
            // 
            // estudianteBindingSource
            // 
            estudianteBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesPrimarias.Estudiante);
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(5, 411);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 30;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // estudiantesInscriptosBindingSource
            // 
            estudiantesInscriptosBindingSource.DataMember = "EstudiantesInscriptos";
            estudiantesInscriptosBindingSource.DataSource = cursosInscriptosBindingSource;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(616, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 78;
            pictureBox1.TabStop = false;
            // 
            // estLbl
            // 
            estLbl.AutoSize = true;
            estLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            estLbl.Location = new Point(197, 75);
            estLbl.Name = "estLbl";
            estLbl.Size = new Size(255, 25);
            estLbl.TabIndex = 79;
            estLbl.Text = "GRILLA DE HORARIOS";
            // 
            // FormConsultarHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 450);
            Controls.Add(estLbl);
            Controls.Add(pictureBox1);
            Controls.Add(backBtn);
            Controls.Add(horariosDGV);
            Controls.Add(SysacadLbl);
            Name = "FormConsultarHorario";
            Text = "";
            ((System.ComponentModel.ISupportInitialize)horariosDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosInscriptosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)estudianteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SysacadLbl;
        private DataGridView horariosDGV;
        private BindingSource estudianteBindingSource;
        private Button backBtn;
        private DataGridViewTextBoxColumn dias;
        private DataGridViewTextBoxColumn Mañana;
        private DataGridViewTextBoxColumn Tarde;
        private DataGridViewTextBoxColumn Noche;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cupoMaximoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cupoDisponibleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private BindingSource cursosInscriptosBindingSource;
        private BindingSource estudiantesInscriptosBindingSource;
        private PictureBox pictureBox1;
        private Label estLbl;
    }
}