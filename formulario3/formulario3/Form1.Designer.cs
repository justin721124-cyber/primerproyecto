namespace formulario3
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
            btnConvertir = new Button();
            cmbEntrada = new ComboBox();
            txtValor = new TextBox();
            cmbSalida = new ComboBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(389, 208);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(93, 71);
            btnConvertir.TabIndex = 0;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // cmbEntrada
            // 
            cmbEntrada.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEntrada.FormattingEnabled = true;
            cmbEntrada.Location = new Point(59, 213);
            cmbEntrada.Name = "cmbEntrada";
            cmbEntrada.Size = new Size(182, 33);
            cmbEntrada.TabIndex = 1;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(80, 165);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(150, 31);
            txtValor.TabIndex = 3;
            txtValor.TextChanged += txtValor_TextChanged;
            // 
            // cmbSalida
            // 
            cmbSalida.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSalida.FormattingEnabled = true;
            cmbSalida.Location = new Point(59, 246);
            cmbSalida.Name = "cmbSalida";
            cmbSalida.Size = new Size(182, 33);
            cmbSalida.TabIndex = 4;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(102, 292);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(90, 25);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 367);
            Controls.Add(lblResultado);
            Controls.Add(cmbSalida);
            Controls.Add(txtValor);
            Controls.Add(cmbEntrada);
            Controls.Add(btnConvertir);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvertir;
        private ComboBox cmbEntrada;
        private TextBox txtValor;
        private ComboBox cmbSalida;
        private Label lblResultado;
    }
}
