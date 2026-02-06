namespace Ejercicio3
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
            btnMostrar = new Button();
            lblResultado = new Label();
            txtMensaje = new TextBox();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(487, 123);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(112, 34);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(516, 22);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(124, 25);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "tercer ejercicio";
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(519, 72);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(150, 31);
            txtMensaje.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 186);
            Controls.Add(txtMensaje);
            Controls.Add(lblResultado);
            Controls.Add(btnMostrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrar;
        private Label lblResultado;
        private TextBox txtMensaje;
    }
}
