namespace formulario4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVerificar = new Button();
            txtPalabra = new TextBox();
            SuspendLayout();
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(29, 83);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(112, 34);
            btnVerificar.TabIndex = 0;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(12, 12);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(150, 31);
            txtPalabra.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 293);
            Controls.Add(txtPalabra);
            Controls.Add(btnVerificar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerificar;
        private TextBox txtPalabra;
    }
}
