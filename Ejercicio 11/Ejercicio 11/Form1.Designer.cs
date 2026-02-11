namespace Ejercicio_11
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
            btnMostrarFecha = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblFecha = new Label();
            SuspendLayout();
            // 
            // btnMostrarFecha
            // 
            btnMostrarFecha.Location = new Point(177, 192);
            btnMostrarFecha.Name = "btnMostrarFecha";
            btnMostrarFecha.Size = new Size(112, 34);
            btnMostrarFecha.TabIndex = 0;
            btnMostrarFecha.Text = "Mostrar";
            btnMostrarFecha.UseVisualStyleBackColor = true;
            btnMostrarFecha.Click += btnMostrarFecha_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(108, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(211, 94);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(59, 25);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 281);
            Controls.Add(lblFecha);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnMostrarFecha);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrarFecha;
        private DateTimePicker dateTimePicker1;
        private Label lblFecha;
    }
}
