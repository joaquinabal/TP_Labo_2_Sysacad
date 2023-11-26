namespace Forms_TP_Labo_2_Sysacad
{
    partial class FormGestionarPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionarPagos));
            SysacadLbl = new Label();
            label1 = new Label();
            label2 = new Label();
            estudianteBindingSource = new BindingSource(components);
            conceptosDePagoBindingSource = new BindingSource(components);
            conceptosPagosDGV = new DataGridView();
            conceptoAPagar = new DataGridViewTextBoxColumn();
            montoPendiente = new DataGridViewTextBoxColumn();
            montoAPagar = new DataGridViewTextBoxColumn();
            totalAPagarLbl = new Label();
            backBtn = new Button();
            continuarBtn = new Button();
            metodoPagoCombobox = new ComboBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)estudianteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conceptosDePagoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conceptosPagosDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SysacadLbl
            // 
            SysacadLbl.AutoSize = true;
            SysacadLbl.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SysacadLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SysacadLbl.Location = new Point(106, 9);
            SysacadLbl.Name = "SysacadLbl";
            SysacadLbl.Size = new Size(197, 48);
            SysacadLbl.TabIndex = 2;
            SysacadLbl.Text = "SYSACAD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 72);
            label1.Name = "label1";
            label1.Size = new Size(321, 33);
            label1.TabIndex = 4;
            label1.Text = "GESTIÓN DE PAGOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 111);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 5;
            label2.Text = "Pendientes:";
            // 
            // estudianteBindingSource
            // 
            estudianteBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.EntidadesPrimarias.Estudiante);
            // 
            // conceptosDePagoBindingSource
            // 
            conceptosDePagoBindingSource.DataMember = "ConceptosDePago";
            conceptosDePagoBindingSource.DataSource = estudianteBindingSource;
            // 
            // conceptosPagosDGV
            // 
            conceptosPagosDGV.AllowUserToAddRows = false;
            conceptosPagosDGV.AllowUserToDeleteRows = false;
            conceptosPagosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            conceptosPagosDGV.Columns.AddRange(new DataGridViewColumn[] { conceptoAPagar, montoPendiente, montoAPagar });
            conceptosPagosDGV.EditMode = DataGridViewEditMode.EditOnEnter;
            conceptosPagosDGV.Location = new Point(27, 139);
            conceptosPagosDGV.Name = "conceptosPagosDGV";
            conceptosPagosDGV.RowTemplate.Height = 25;
            conceptosPagosDGV.Size = new Size(346, 150);
            conceptosPagosDGV.TabIndex = 6;
            conceptosPagosDGV.CellValueChanged += conceptosPagosDGV_CellValueChanged;
            // 
            // conceptoAPagar
            // 
            conceptoAPagar.HeaderText = "Concepto a Pagar";
            conceptoAPagar.Name = "conceptoAPagar";
            conceptoAPagar.ReadOnly = true;
            // 
            // montoPendiente
            // 
            montoPendiente.HeaderText = "Monto Pendiente";
            montoPendiente.Name = "montoPendiente";
            montoPendiente.ReadOnly = true;
            // 
            // montoAPagar
            // 
            montoAPagar.HeaderText = "Monto a Pagar";
            montoAPagar.Name = "montoAPagar";
            // 
            // totalAPagarLbl
            // 
            totalAPagarLbl.AutoSize = true;
            totalAPagarLbl.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            totalAPagarLbl.Location = new Point(161, 351);
            totalAPagarLbl.Name = "totalAPagarLbl";
            totalAPagarLbl.Size = new Size(161, 25);
            totalAPagarLbl.TabIndex = 7;
            totalAPagarLbl.Text = "Total a Pagar: $0";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Goldenrod;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(5, 411);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(56, 36);
            backBtn.TabIndex = 22;
            backBtn.Text = "atrás";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // continuarBtn
            // 
            continuarBtn.BackColor = Color.Goldenrod;
            continuarBtn.FlatStyle = FlatStyle.Flat;
            continuarBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            continuarBtn.Location = new Point(246, 392);
            continuarBtn.Name = "continuarBtn";
            continuarBtn.Size = new Size(114, 36);
            continuarBtn.TabIndex = 23;
            continuarBtn.Text = "Continuar";
            continuarBtn.UseVisualStyleBackColor = false;
            continuarBtn.Click += continuarBtn_Click;
            // 
            // metodoPagoCombobox
            // 
            metodoPagoCombobox.FormattingEnabled = true;
            metodoPagoCombobox.Items.AddRange(new object[] { "Tarjeta de Credito", "Tarjeta de Debito", "Transferencia" });
            metodoPagoCombobox.Location = new Point(27, 330);
            metodoPagoCombobox.Name = "metodoPagoCombobox";
            metodoPagoCombobox.Size = new Size(121, 23);
            metodoPagoCombobox.TabIndex = 24;
            metodoPagoCombobox.SelectedIndexChanged += metodoPagoCombobox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 310);
            label3.Name = "label3";
            label3.Size = new Size(113, 17);
            label3.TabIndex = 25;
            label3.Text = "Método de Pago:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(335, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 77;
            pictureBox1.TabStop = false;
            // 
            // FormGestionarPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(metodoPagoCombobox);
            Controls.Add(continuarBtn);
            Controls.Add(backBtn);
            Controls.Add(totalAPagarLbl);
            Controls.Add(conceptosPagosDGV);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SysacadLbl);
            Name = "FormGestionarPagos";
            Load += FormGestionarPagos_Load;
            ((System.ComponentModel.ISupportInitialize)estudianteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)conceptosDePagoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)conceptosPagosDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SysacadLbl;
        private Label label1;
        private Label label2;
        private BindingSource estudianteBindingSource;
        private BindingSource conceptosDePagoBindingSource;
        private DataGridView conceptosPagosDGV;
        private Label totalAPagarLbl;
        private Button backBtn;
        private Button continuarBtn;
        private DataGridViewTextBoxColumn conceptoAPagar;
        private DataGridViewTextBoxColumn montoPendiente;
        private DataGridViewTextBoxColumn montoAPagar;
        private ComboBox metodoPagoCombobox;
        private Label label3;
        private PictureBox pictureBox1;
    }
}