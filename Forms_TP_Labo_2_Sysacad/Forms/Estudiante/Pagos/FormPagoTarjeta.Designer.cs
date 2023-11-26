namespace Forms_TP_Labo_2_Sysacad
{
    partial class FormPagoTarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagoTarjeta));
            nroTarjetaTxtbox = new TextBox();
            FVTxtbox = new TextBox();
            pagarBtn = new Button();
            SysacadLbl = new Label();
            backBtn = new Button();
            CSTxtbox = new TextBox();
            nombreTxtbox = new TextBox();
            cantCuotasCB = new ComboBox();
            TCRadioBtn = new RadioButton();
            TDRadioBtn = new RadioButton();
            nroTarjetaLbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            estLbl = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nroTarjetaTxtbox
            // 
            nroTarjetaTxtbox.Location = new Point(48, 191);
            nroTarjetaTxtbox.Name = "nroTarjetaTxtbox";
            nroTarjetaTxtbox.Size = new Size(288, 23);
            nroTarjetaTxtbox.TabIndex = 0;
            nroTarjetaTxtbox.TextChanged += nroTarjetaTxtbox_TextChanged;
            // 
            // FVTxtbox
            // 
            FVTxtbox.Location = new Point(48, 313);
            FVTxtbox.Name = "FVTxtbox";
            FVTxtbox.Size = new Size(50, 23);
            FVTxtbox.TabIndex = 1;
            FVTxtbox.TextChanged += FVTxtbox_TextChanged;
            // 
            // pagarBtn
            // 
            pagarBtn.BackColor = Color.Goldenrod;
            pagarBtn.FlatStyle = FlatStyle.Flat;
            pagarBtn.Location = new Point(156, 425);
            pagarBtn.Name = "pagarBtn";
            pagarBtn.Size = new Size(75, 23);
            pagarBtn.TabIndex = 3;
            pagarBtn.Text = "Pagar";
            pagarBtn.UseVisualStyleBackColor = false;
            pagarBtn.Click += pagarBtn_Click;
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(99, 9);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 4;
            SysacadLbl.Text = "SYSACAD";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(7, 447);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 23;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // CSTxtbox
            // 
            CSTxtbox.Location = new Point(286, 313);
            CSTxtbox.Name = "CSTxtbox";
            CSTxtbox.Size = new Size(50, 23);
            CSTxtbox.TabIndex = 25;
            CSTxtbox.TextChanged += CSTxtbox_TextChanged;
            // 
            // nombreTxtbox
            // 
            nombreTxtbox.Location = new Point(48, 251);
            nombreTxtbox.Name = "nombreTxtbox";
            nombreTxtbox.Size = new Size(183, 23);
            nombreTxtbox.TabIndex = 26;
            nombreTxtbox.TextChanged += nombreTxtbox_TextChanged;
            // 
            // cantCuotasCB
            // 
            cantCuotasCB.FormattingEnabled = true;
            cantCuotasCB.Items.AddRange(new object[] { "1 Cuota", "3 Cuotas", "6 Cuotas", "12 Cuotas" });
            cantCuotasCB.Location = new Point(48, 373);
            cantCuotasCB.Name = "cantCuotasCB";
            cantCuotasCB.Size = new Size(121, 23);
            cantCuotasCB.TabIndex = 27;
            cantCuotasCB.SelectedIndexChanged += cantCuotasCB_SelectedIndexChanged;
            // 
            // TCRadioBtn
            // 
            TCRadioBtn.AutoSize = true;
            TCRadioBtn.Location = new Point(53, 132);
            TCRadioBtn.Name = "TCRadioBtn";
            TCRadioBtn.Size = new Size(117, 19);
            TCRadioBtn.TabIndex = 28;
            TCRadioBtn.TabStop = true;
            TCRadioBtn.Text = "Tarjeta de Crédito";
            TCRadioBtn.UseVisualStyleBackColor = true;
            TCRadioBtn.CheckedChanged += TCRadioBtn_CheckedChanged;
            // 
            // TDRadioBtn
            // 
            TDRadioBtn.AutoSize = true;
            TDRadioBtn.Location = new Point(242, 132);
            TDRadioBtn.Name = "TDRadioBtn";
            TDRadioBtn.Size = new Size(113, 19);
            TDRadioBtn.TabIndex = 29;
            TDRadioBtn.TabStop = true;
            TDRadioBtn.Text = "Tarjeta de Débito";
            TDRadioBtn.UseVisualStyleBackColor = true;
            TDRadioBtn.CheckedChanged += TDRadioBtn_CheckedChanged;
            // 
            // nroTarjetaLbl
            // 
            nroTarjetaLbl.AutoSize = true;
            nroTarjetaLbl.Location = new Point(48, 173);
            nroTarjetaLbl.Name = "nroTarjetaLbl";
            nroTarjetaLbl.Size = new Size(107, 15);
            nroTarjetaLbl.TabIndex = 30;
            nroTarjetaLbl.Text = "Número de Tarjeta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 233);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 31;
            label1.Text = "Nombre Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 295);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 32;
            label2.Text = "Fecha de Vencimiento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 295);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 33;
            label3.Text = "Cód. Seguridad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 355);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 34;
            label4.Text = "Cant. de Cuotas:";
            // 
            // estLbl
            // 
            estLbl.AutoSize = true;
            estLbl.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            estLbl.Location = new Point(89, 76);
            estLbl.Name = "estLbl";
            estLbl.Size = new Size(207, 22);
            estLbl.TabIndex = 35;
            estLbl.Text = "PAGO CON TARJETA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(332, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // FormPagoTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 485);
            Controls.Add(pictureBox1);
            Controls.Add(estLbl);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nroTarjetaLbl);
            Controls.Add(TDRadioBtn);
            Controls.Add(TCRadioBtn);
            Controls.Add(cantCuotasCB);
            Controls.Add(nombreTxtbox);
            Controls.Add(CSTxtbox);
            Controls.Add(backBtn);
            Controls.Add(SysacadLbl);
            Controls.Add(pagarBtn);
            Controls.Add(FVTxtbox);
            Controls.Add(nroTarjetaTxtbox);
            Name = "FormPagoTarjeta";
            Text = "";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nroTarjetaTxtbox;
        private TextBox FVTxtbox;
        private Button pagarBtn;
        private Label SysacadLbl;
        private Button backBtn;
        private TextBox CSTxtbox;
        private TextBox nombreTxtbox;
        private ComboBox cantCuotasCB;
        private RadioButton TCRadioBtn;
        private RadioButton TDRadioBtn;
        private Label nroTarjetaLbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label estLbl;
        private PictureBox pictureBox1;
    }
}