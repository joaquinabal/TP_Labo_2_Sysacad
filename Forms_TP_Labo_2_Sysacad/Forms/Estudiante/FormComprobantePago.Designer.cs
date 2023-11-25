namespace Forms_TP_Labo_2_Sysacad
{
    partial class FormComprobantePago
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
            button1 = new Button();
            comprobanteLbl = new Label();
            fechaLbl = new Label();
            conceptosTitleLbl = new Label();
            montoLbl = new Label();
            cuotasLbl = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(128, 216);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comprobanteLbl
            // 
            comprobanteLbl.AutoSize = true;
            comprobanteLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comprobanteLbl.Location = new Point(87, 9);
            comprobanteLbl.Name = "comprobanteLbl";
            comprobanteLbl.Size = new Size(181, 21);
            comprobanteLbl.TabIndex = 1;
            comprobanteLbl.Text = "Comprobante de Pago";
            // 
            // fechaLbl
            // 
            fechaLbl.AutoSize = true;
            fechaLbl.Location = new Point(12, 37);
            fechaLbl.Name = "fechaLbl";
            fechaLbl.Size = new Size(44, 15);
            fechaLbl.TabIndex = 2;
            fechaLbl.Text = "Fecha: ";
            // 
            // conceptosTitleLbl
            // 
            conceptosTitleLbl.AutoSize = true;
            conceptosTitleLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            conceptosTitleLbl.Location = new Point(12, 65);
            conceptosTitleLbl.Name = "conceptosTitleLbl";
            conceptosTitleLbl.Size = new Size(116, 15);
            conceptosTitleLbl.TabIndex = 3;
            conceptosTitleLbl.Text = "Conceptos Pagados:";
            // 
            // montoLbl
            // 
            montoLbl.AutoSize = true;
            montoLbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            montoLbl.Location = new Point(14, 188);
            montoLbl.Name = "montoLbl";
            montoLbl.Size = new Size(125, 19);
            montoLbl.TabIndex = 5;
            montoLbl.Text = "Monto Pagado: $";
            // 
            // cuotasLbl
            // 
            cuotasLbl.AutoSize = true;
            cuotasLbl.Location = new Point(236, 190);
            cuotasLbl.Name = "cuotasLbl";
            cuotasLbl.Size = new Size(47, 15);
            cuotasLbl.TabIndex = 6;
            cuotasLbl.Text = "Cuotas:";
            // 
            // FormComprobantePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 251);
            Controls.Add(cuotasLbl);
            Controls.Add(montoLbl);
            Controls.Add(conceptosTitleLbl);
            Controls.Add(fechaLbl);
            Controls.Add(comprobanteLbl);
            Controls.Add(button1);
            Name = "FormComprobantePago";
            Text = "";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label comprobanteLbl;
        private Label fechaLbl;
        private Label conceptosTitleLbl;
        private Label montoLbl;
        private Label cuotasLbl;
    }
}