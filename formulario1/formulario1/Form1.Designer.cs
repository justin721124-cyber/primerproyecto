namespace formulario1
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
            txtNumero = new TextBox();
            btnGenerar = new Button();
            Tabla = new ListBox();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(129, 36);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(150, 31);
            txtNumero.TabIndex = 0;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(128, 126);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(151, 34);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Mostrar tabla";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // Tabla
            // 
            Tabla.FormattingEnabled = true;
            Tabla.Location = new Point(374, 17);
            Tabla.Name = "Tabla";
            Tabla.Size = new Size(180, 279);
            Tabla.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 313);
            Controls.Add(Tabla);
            Controls.Add(btnGenerar);
            Controls.Add(txtNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Button btnGenerar;
        private ListBox Tabla;
    }
}
