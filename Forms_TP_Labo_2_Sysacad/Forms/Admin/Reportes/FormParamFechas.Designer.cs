namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    partial class FormParamFechas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParamFechas));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            SysacadLbl = new Label();
            desdeDTP = new DateTimePicker();
            hastaDTP = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            generarReporteBtn = new Button();
            conceptoPagoComboBox = new ComboBox();
            conceptoDePagoBindingSource = new BindingSource(components);
            conceptoPagoLbl = new Label();
            carreraComboBox = new ComboBox();
            carreraLbl = new Label();
            backBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conceptoDePagoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(301, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 75);
            label1.Name = "label1";
            label1.Size = new Size(324, 29);
            label1.TabIndex = 34;
            label1.Text = "PARAMETRO DE FECHAS";
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(78, 9);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 33;
            SysacadLbl.Text = "SYSACAD";
            // 
            // desdeDTP
            // 
            desdeDTP.Location = new Point(27, 162);
            desdeDTP.Name = "desdeDTP";
            desdeDTP.Size = new Size(200, 23);
            desdeDTP.TabIndex = 36;
            desdeDTP.ValueChanged += desdeDTP_ValueChanged;
            // 
            // hastaDTP
            // 
            hastaDTP.Location = new Point(27, 240);
            hastaDTP.Name = "hastaDTP";
            hastaDTP.Size = new Size(200, 23);
            hastaDTP.TabIndex = 37;
            hastaDTP.ValueChanged += hastaDTP_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 144);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 38;
            label2.Text = "Desde:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 222);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 39;
            label3.Text = "Hasta:";
            // 
            // generarReporteBtn
            // 
            generarReporteBtn.AutoSize = true;
            generarReporteBtn.BackColor = Color.Goldenrod;
            generarReporteBtn.FlatStyle = FlatStyle.Flat;
            generarReporteBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            generarReporteBtn.Location = new Point(131, 372);
            generarReporteBtn.Name = "generarReporteBtn";
            generarReporteBtn.Size = new Size(144, 33);
            generarReporteBtn.TabIndex = 41;
            generarReporteBtn.Text = "Generar Reporte";
            generarReporteBtn.UseVisualStyleBackColor = false;
            generarReporteBtn.Click += generarReporteBtn_Click;
            // 
            // conceptoPagoComboBox
            // 
            conceptoPagoComboBox.Enabled = false;
            conceptoPagoComboBox.FormattingEnabled = true;
            conceptoPagoComboBox.Items.AddRange(new object[] { "Bibliografia Primer Cuatrimestre", "Cargos Administrativos primer cuatrimestre", "Matricula de Ingreso", "Matricula del Primer Cuatrimestre" });
            conceptoPagoComboBox.Location = new Point(27, 302);
            conceptoPagoComboBox.Name = "conceptoPagoComboBox";
            conceptoPagoComboBox.Size = new Size(121, 23);
            conceptoPagoComboBox.TabIndex = 42;
            conceptoPagoComboBox.Visible = false;
            conceptoPagoComboBox.SelectedIndexChanged += conceptoPagoComboBox_SelectedIndexChanged;
            // 
            // conceptoDePagoBindingSource
            // 
            conceptoDePagoBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesSecundarias.ConceptoDePago);
            // 
            // conceptoPagoLbl
            // 
            conceptoPagoLbl.AutoSize = true;
            conceptoPagoLbl.Enabled = false;
            conceptoPagoLbl.Location = new Point(29, 284);
            conceptoPagoLbl.Name = "conceptoPagoLbl";
            conceptoPagoLbl.Size = new Size(108, 15);
            conceptoPagoLbl.TabIndex = 43;
            conceptoPagoLbl.Text = "Concepto de Pago:";
            conceptoPagoLbl.Visible = false;
            // 
            // carreraComboBox
            // 
            carreraComboBox.Enabled = false;
            carreraComboBox.FormattingEnabled = true;
            carreraComboBox.Items.AddRange(new object[] { "TUP", "TUSI" });
            carreraComboBox.Location = new Point(144, 302);
            carreraComboBox.Name = "carreraComboBox";
            carreraComboBox.Size = new Size(121, 23);
            carreraComboBox.TabIndex = 44;
            carreraComboBox.Visible = false;
            carreraComboBox.SelectedIndexChanged += carreraComboBox_SelectedIndexChanged;
            // 
            // carreraLbl
            // 
            carreraLbl.AutoSize = true;
            carreraLbl.Enabled = false;
            carreraLbl.Location = new Point(144, 284);
            carreraLbl.Name = "carreraLbl";
            carreraLbl.Size = new Size(48, 15);
            carreraLbl.TabIndex = 45;
            carreraLbl.Text = "Carrera:";
            carreraLbl.Visible = false;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(5, 404);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 46;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // FormParamFechas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 443);
            Controls.Add(backBtn);
            Controls.Add(carreraLbl);
            Controls.Add(carreraComboBox);
            Controls.Add(conceptoPagoLbl);
            Controls.Add(conceptoPagoComboBox);
            Controls.Add(generarReporteBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(hastaDTP);
            Controls.Add(desdeDTP);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(SysacadLbl);
            Name = "FormParamFechas";
            Text = "FormParamFechas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)conceptoDePagoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label SysacadLbl;
        private DateTimePicker desdeDTP;
        private DateTimePicker hastaDTP;
        private Label label2;
        private Label label3;
        private Button generarReporteBtn;
        private ComboBox conceptoPagoComboBox;
        private BindingSource conceptoDePagoBindingSource;
        private Label conceptoPagoLbl;
        private ComboBox carreraComboBox;
        private Label carreraLbl;
        private Button backBtn;
    }
}