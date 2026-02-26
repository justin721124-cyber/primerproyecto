namespace formulario5
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
            mskNumero.BackColor = SystemColors.HighlightText;
            mskNumero.Location = new Point(172, 27);
            mskNumero.Name = "mskNumero";
            mskNumero.Size = new Size(150, 31);
            mskNumero.TabIndex = 0;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(190, 73);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(112, 74);
            btnVerificar.TabIndex = 1;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(524, 258);
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
