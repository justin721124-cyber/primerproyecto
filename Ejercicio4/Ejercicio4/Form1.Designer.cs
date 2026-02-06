namespace Ejercicio4
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
            btnSumar = new Button();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            lblResultado = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.BackColor = Color.Lime;
            btnSumar.ForeColor = Color.Fuchsia;
            btnSumar.Location = new Point(389, 179);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(112, 68);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = false;
            btnSumar.Click += btnSumar_Click;
            // 
            // txtNumero1
            // 
            txtNumero1.BackColor = Color.Blue;
            txtNumero1.ForeColor = Color.White;
            txtNumero1.Location = new Point(36, 132);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(150, 31);
            txtNumero1.TabIndex = 1;
            // 
            // txtNumero2
            // 
            txtNumero2.BackColor = Color.Blue;
            txtNumero2.ForeColor = Color.White;
            txtNumero2.Location = new Point(36, 216);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(150, 31);
            txtNumero2.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.White;
            lblResultado.ForeColor = Color.Blue;
            lblResultado.Location = new Point(53, 295);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(90, 25);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.ForeColor = Color.White;
            label1.Location = new Point(164, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 25);
            label1.TabIndex = 4;
            label1.Text = "Mini Calculadora de Justin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(611, 342);
            Controls.Add(label1);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(btnSumar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Label lblResultado;
        private Label label1;
    }
}
