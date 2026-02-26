namespace formulario7
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
            btnGenerar = new Button();
            txtInicio = new TextBox();
            txtFin = new TextBox();
            Primos = new ListBox();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(0, 0);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(112, 34);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "mostrar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(137, 12);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(150, 31);
            txtInicio.TabIndex = 1;
            // 
            // txtFin
            // 
            txtFin.Location = new Point(137, 58);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(150, 31);
            txtFin.TabIndex = 2;
            txtFin.TextChanged += textBox2_TextChanged;
            // 
            // Primos
            // 
            Primos.FormattingEnabled = true;
            Primos.Location = new Point(122, 161);
            Primos.Name = "Primos";
            Primos.Size = new Size(180, 129);
            Primos.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 302);
            Controls.Add(Primos);
            Controls.Add(txtFin);
            Controls.Add(txtInicio);
            Controls.Add(btnGenerar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerar;
        private TextBox txtInicio;
        private TextBox txtFin;
        private ListBox Primos;
    }
}
