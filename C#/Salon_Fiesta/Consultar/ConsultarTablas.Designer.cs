namespace Salon_Fiesta
{
    partial class ConsultarTablas
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
            label1 = new Label();
            buttonCons = new Button();
            cmbTabla = new ComboBox();
            dgvConsulta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(49, 52);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 0;
            label1.Text = "que tabla desea consultar?";
            // 
            // buttonCons
            // 
            buttonCons.Anchor = AnchorStyles.None;
            buttonCons.Cursor = Cursors.Hand;
            buttonCons.Location = new Point(255, 83);
            buttonCons.Name = "buttonCons";
            buttonCons.Size = new Size(132, 24);
            buttonCons.TabIndex = 3;
            buttonCons.Text = "CONSULTAR";
            buttonCons.UseVisualStyleBackColor = true;
            buttonCons.Click += buttonCons_Click;
            // 
            // cmbTabla
            // 
            cmbTabla.FormattingEnabled = true;
            cmbTabla.Items.AddRange(new object[] { "calle", "ciudad", "cliente", "colonia", "contrato", "contrato_servicio", "evento", "paquetes", "paquetes_servicios", "registro_pagos", "salon", "servicios" });
            cmbTabla.Location = new Point(49, 84);
            cmbTabla.Name = "cmbTabla";
            cmbTabla.Size = new Size(168, 23);
            cmbTabla.TabIndex = 4;
            cmbTabla.Text = "Tablas";
            cmbTabla.SelectedIndexChanged += cmbTabla_SelectedIndexChanged;
            // 
            // dgvConsulta
            // 
            dgvConsulta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(49, 150);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.Size = new Size(691, 271);
            dgvConsulta.TabIndex = 5;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(785, 450);
            Controls.Add(dgvConsulta);
            Controls.Add(cmbTabla);
            Controls.Add(buttonCons);
            Controls.Add(label1);
            Name = "Consulta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultarTablas";
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button buttonCons;
        private ComboBox cmbTabla;
        private DataGridView dgvConsulta;
    }
}