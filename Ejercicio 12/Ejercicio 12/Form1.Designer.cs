namespace Ejercicio_12
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
            lblCelsius = new Label();
            btnConvertir = new Button();
            txtCelsius = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblCelsius
            // 
            lblCelsius.AutoSize = true;
            lblCelsius.Location = new Point(177, 9);
            lblCelsius.Name = "lblCelsius";
            lblCelsius.Size = new Size(157, 25);
            lblCelsius.TabIndex = 0;
            lblCelsius.Text = "Temperatura en °C";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(177, 174);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(150, 63);
            btnConvertir.TabIndex = 1;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(177, 37);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(150, 31);
            txtCelsius.TabIndex = 2;
            txtCelsius.TextChanged += txtCelsius_TextChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(206, 107);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(90, 25);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 368);
            Controls.Add(lblResultado);
            Controls.Add(txtCelsius);
            Controls.Add(btnConvertir);
            Controls.Add(lblCelsius);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCelsius;
        private Button btnConvertir;
        private TextBox txtCelsius;
        private Label lblResultado;
    }
}
