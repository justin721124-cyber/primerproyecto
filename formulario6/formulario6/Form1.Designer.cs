namespace formulario6
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
            mskNumero = new MaskedTextBox();
            btnVerificar = new Button();
            SuspendLayout();
            // 
            // mskNumero
            // 
            mskNumero.Location = new Point(158, 12);
            mskNumero.Name = "mskNumero";
            mskNumero.Size = new Size(150, 31);
            mskNumero.TabIndex = 0;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(175, 100);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(112, 82);
            btnVerificar.TabIndex = 1;
            btnVerificar.Text = "verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 273);
            Controls.Add(btnVerificar);
            Controls.Add(mskNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mskNumero;
        private Button btnVerificar;
    }
}
