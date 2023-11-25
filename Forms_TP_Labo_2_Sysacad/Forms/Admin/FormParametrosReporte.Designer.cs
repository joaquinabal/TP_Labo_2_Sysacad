namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    partial class FormParametrosReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParametrosReporte));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            SysacadLbl = new Label();
            backBtn = new Button();
            generarReporteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(320, 2);
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
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(363, 29);
            label1.TabIndex = 34;
            label1.Text = "PARAMETROS DE REPORTE";
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(82, 30);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 33;
            SysacadLbl.Text = "SYSACAD";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(5, 409);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 36;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // generarReporteBtn
            // 
            generarReporteBtn.AutoSize = true;
            generarReporteBtn.BackColor = Color.Goldenrod;
            generarReporteBtn.FlatStyle = FlatStyle.Flat;
            generarReporteBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            generarReporteBtn.Location = new Point(114, 341);
            generarReporteBtn.Name = "generarReporteBtn";
            generarReporteBtn.Size = new Size(144, 33);
            generarReporteBtn.TabIndex = 37;
            generarReporteBtn.Text = "Generar Reporte";
            generarReporteBtn.UseVisualStyleBackColor = false;
            // 
            // FormParametrosReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 450);
            Controls.Add(generarReporteBtn);
            Controls.Add(backBtn);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(SysacadLbl);
            Name = "FormParametrosReporte";
            Text = "";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label SysacadLbl;
        private Button backBtn;
        private Button generarReporteBtn;
    }
}