namespace Ejercicio_8
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
            btnContar = new Button();
            txtMostrar = new TextBox();
            SuspendLayout();
            // 
            // btnContar
            // 
            btnContar.Location = new Point(85, 113);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(112, 34);
            btnContar.TabIndex = 0;
            btnContar.Text = "button1";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // txtMostrar
            // 
            txtMostrar.Location = new Point(72, 12);
            txtMostrar.Name = "txtMostrar";
            txtMostrar.Size = new Size(150, 31);
            txtMostrar.TabIndex = 1;
            txtMostrar.Text = "0";
            txtMostrar.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 284);
            Controls.Add(txtMostrar);
            Controls.Add(btnContar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnContar;
        private TextBox txtMostrar;
    }
}
