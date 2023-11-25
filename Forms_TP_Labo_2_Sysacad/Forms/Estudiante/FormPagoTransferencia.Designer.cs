namespace Forms_TP_Labo_2_Sysacad
{
    partial class FormPagoTransferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagoTransferencia));
            label1 = new Label();
            nroTarjetaLbl = new Label();
            nombreTxtbox = new TextBox();
            backBtn = new Button();
            SysacadLbl = new Label();
            pagarBtn = new Button();
            CBUTxtbox = new TextBox();
            pictureBox1 = new PictureBox();
            panelEstLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 116);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 46;
            label1.Text = "Nombre Completo:";
            // 
            // nroTarjetaLbl
            // 
            nroTarjetaLbl.AutoSize = true;
            nroTarjetaLbl.Location = new Point(52, 175);
            nroTarjetaLbl.Name = "nroTarjetaLbl";
            nroTarjetaLbl.Size = new Size(33, 15);
            nroTarjetaLbl.TabIndex = 45;
            nroTarjetaLbl.Text = "CBU:";
            // 
            // nombreTxtbox
            // 
            nombreTxtbox.Location = new Point(51, 134);
            nombreTxtbox.Name = "nombreTxtbox";
            nombreTxtbox.Size = new Size(183, 23);
            nombreTxtbox.TabIndex = 41;
            nombreTxtbox.TextChanged += nombreTxtbox_TextChanged;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(4, 277);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 39;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(91, 9);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 38;
            SysacadLbl.Text = "SYSACAD";
            // 
            // pagarBtn
            // 
            pagarBtn.BackColor = Color.Goldenrod;
            pagarBtn.FlatStyle = FlatStyle.Flat;
            pagarBtn.Location = new Point(159, 238);
            pagarBtn.Name = "pagarBtn";
            pagarBtn.Size = new Size(75, 23);
            pagarBtn.TabIndex = 37;
            pagarBtn.Text = "Pagar";
            pagarBtn.UseVisualStyleBackColor = false;
            pagarBtn.Click += pagarBtn_Click;
            // 
            // CBUTxtbox
            // 
            CBUTxtbox.Location = new Point(52, 192);
            CBUTxtbox.Name = "CBUTxtbox";
            CBUTxtbox.Size = new Size(288, 23);
            CBUTxtbox.TabIndex = 35;
            CBUTxtbox.TextChanged += CBUTxtbox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(317, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 77;
            pictureBox1.TabStop = false;
            // 
            // panelEstLbl
            // 
            panelEstLbl.AutoSize = true;
            panelEstLbl.Font = new Font("Lucida Sans", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            panelEstLbl.Location = new Point(37, 73);
            panelEstLbl.Name = "panelEstLbl";
            panelEstLbl.Size = new Size(315, 23);
            panelEstLbl.TabIndex = 78;
            panelEstLbl.Text = "PAGO CON TRANSFERENCIA";
            // 
            // FormPagoTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 315);
            Controls.Add(panelEstLbl);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(nroTarjetaLbl);
            Controls.Add(nombreTxtbox);
            Controls.Add(backBtn);
            Controls.Add(SysacadLbl);
            Controls.Add(pagarBtn);
            Controls.Add(CBUTxtbox);
            Name = "FormPagoTransferencia";
            Text = "";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label nroTarjetaLbl;
        private ComboBox cantCuotasCB;
        private TextBox nombreTxtbox;
        private TextBox CSTxtbox;
        private Button backBtn;
        private Label SysacadLbl;
        private Button pagarBtn;
        private TextBox FVTxtbox;
        private TextBox CBUTxtbox;
        private PictureBox pictureBox1;
        private Label panelEstLbl;
    }
}