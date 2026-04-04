namespace SistemaCitasSpa
{
    partial class FormEliminar
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
            txtId = new TextBox();
            btnExportar = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(255, 224, 192);
            txtId.Location = new Point(122, 98);
            txtId.Name = "txtId";
            txtId.Size = new Size(140, 31);
            txtId.TabIndex = 0;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(128, 255, 128);
            btnExportar.Location = new Point(122, 159);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(140, 93);
            btnExportar.TabIndex = 1;
            btnExportar.Text = "Eliminar";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // FormEliminar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(430, 409);
            Controls.Add(btnExportar);
            Controls.Add(txtId);
            Name = "FormEliminar";
            Text = "FormEliminar";
            Load += FormEliminar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Button btnExportar;
    }
}