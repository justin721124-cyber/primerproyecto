namespace Dios2
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
            btnCambiar = new Button();
            lblTextoACambiar = new Label();
            SuspendLayout();
            // 
            // btnCambiar
            // 
            btnCambiar.BackColor = Color.Red;
            btnCambiar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiar.ForeColor = Color.Yellow;
            btnCambiar.Location = new Point(98, 84);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(112, 90);
            btnCambiar.TabIndex = 0;
            btnCambiar.Text = "Enviar\r\n";
            btnCambiar.UseVisualStyleBackColor = false;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // lblTextoACambiar
            // 
            lblTextoACambiar.AutoSize = true;
            lblTextoACambiar.BackColor = Color.Red;
            lblTextoACambiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextoACambiar.ForeColor = Color.Yellow;
            lblTextoACambiar.Location = new Point(432, 75);
            lblTextoACambiar.Name = "lblTextoACambiar";
            lblTextoACambiar.Size = new Size(76, 32);
            lblTextoACambiar.TabIndex = 1;
            lblTextoACambiar.Text = "Texto\r\n";
            lblTextoACambiar.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(685, 278);
            Controls.Add(lblTextoACambiar);
            Controls.Add(btnCambiar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCambiar;
        private Label lblTextoACambiar;
    }
}
