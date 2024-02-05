namespace Salon_Fiesta
{
    partial class MENU
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
            buttonInsertar = new Button();
            buttonBorrar = new Button();
            buttonConsultar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(22, 63);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 3;
            label1.Text = "QUE DESEA HACER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonInsertar
            // 
            buttonInsertar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonInsertar.Cursor = Cursors.Hand;
            buttonInsertar.Location = new Point(29, 225);
            buttonInsertar.Name = "buttonInsertar";
            buttonInsertar.Size = new Size(159, 71);
            buttonInsertar.TabIndex = 7;
            buttonInsertar.Text = "Insertar";
            buttonInsertar.UseVisualStyleBackColor = true;
            buttonInsertar.Click += buttonInsertar_Click;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonBorrar.Cursor = Cursors.Hand;
            buttonBorrar.Location = new Point(29, 336);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(159, 71);
            buttonBorrar.TabIndex = 6;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // buttonConsultar
            // 
            buttonConsultar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonConsultar.Cursor = Cursors.Hand;
            buttonConsultar.Location = new Point(29, 112);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(159, 71);
            buttonConsultar.TabIndex = 5;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = false;
            buttonConsultar.Click += buttonConsultar_Click;
            // 
            // MENU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 443);
            Controls.Add(buttonInsertar);
            Controls.Add(buttonBorrar);
            Controls.Add(buttonConsultar);
            Controls.Add(label1);
            Name = "MENU";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU";
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button buttonInsertar;
        private Button buttonBorrar;
        private Button buttonConsultar;
    }
}