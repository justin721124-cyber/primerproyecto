namespace MdiContainer
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxMonto = new TextBox();
            comboBoxDestino = new ComboBox();
            comboBoxOrigen = new ComboBox();
            buttonConvertir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(413, 23);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Monto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 99);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 1;
            label2.Text = "Moneda origen";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 163);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 2;
            label3.Text = "Moneda destino";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 238);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 3;
            label4.Text = "Resultado";
            label4.Click += label4_Click;
            // 
            // textBoxMonto
            // 
            textBoxMonto.Location = new Point(373, 51);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.Size = new Size(150, 31);
            textBoxMonto.TabIndex = 4;
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(357, 191);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(182, 33);
            comboBoxDestino.TabIndex = 5;
            // 
            // comboBoxOrigen
            // 
            comboBoxOrigen.FormattingEnabled = true;
            comboBoxOrigen.Location = new Point(357, 127);
            comboBoxOrigen.Name = "comboBoxOrigen";
            comboBoxOrigen.Size = new Size(182, 33);
            comboBoxOrigen.TabIndex = 6;
            comboBoxOrigen.SelectedIndexChanged += comboBoxOrigen_SelectedIndexChanged;
            // 
            // buttonConvertir
            // 
            buttonConvertir.BackColor = Color.FromArgb(128, 255, 128);
            buttonConvertir.Location = new Point(690, 359);
            buttonConvertir.Name = "buttonConvertir";
            buttonConvertir.Size = new Size(112, 91);
            buttonConvertir.TabIndex = 7;
            buttonConvertir.Text = "Convertir";
            buttonConvertir.UseVisualStyleBackColor = false;
            buttonConvertir.Click += buttonConvertir_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonConvertir);
            Controls.Add(comboBoxOrigen);
            Controls.Add(comboBoxDestino);
            Controls.Add(textBoxMonto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxMonto;
        private ComboBox comboBoxDestino;
        private ComboBox comboBoxOrigen;
        private Button buttonConvertir;
    }
}