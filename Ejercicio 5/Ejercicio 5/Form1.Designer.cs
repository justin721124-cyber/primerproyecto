namespace Ejercicio_5
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
            textA = new TextBox();
            textB = new TextBox();
            button1 = new Button();
            gboxOperaciones = new GroupBox();
            rbMultiplicar = new RadioButton();
            rbResta = new RadioButton();
            rbSuma = new RadioButton();
            lblResultado = new Label();
            btnLimpiar = new Button();
            gboxOperaciones.SuspendLayout();
            SuspendLayout();
            // 
            // textA
            // 
            textA.Location = new Point(56, 22);
            textA.Name = "textA";
            textA.Size = new Size(147, 31);
            textA.TabIndex = 0;
            textA.Text = "0\r\n\r\n";
            textA.TextAlign = HorizontalAlignment.Right;
            // 
            // textB
            // 
            textB.Location = new Point(56, 59);
            textB.Name = "textB";
            textB.Size = new Size(147, 31);
            textB.TabIndex = 1;
            textB.Text = "0\r\n";
            textB.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(457, 22);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Calcular\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalcular_Click;
            // 
            // gboxOperaciones
            // 
            gboxOperaciones.Controls.Add(rbMultiplicar);
            gboxOperaciones.Controls.Add(rbResta);
            gboxOperaciones.Controls.Add(rbSuma);
            gboxOperaciones.Location = new Point(56, 170);
            gboxOperaciones.Name = "gboxOperaciones";
            gboxOperaciones.Size = new Size(300, 150);
            gboxOperaciones.TabIndex = 3;
            gboxOperaciones.TabStop = false;
            gboxOperaciones.Text = "Operaciones";
            // 
            // rbMultiplicar
            // 
            rbMultiplicar.AutoSize = true;
            rbMultiplicar.Location = new Point(23, 106);
            rbMultiplicar.Name = "rbMultiplicar";
            rbMultiplicar.Size = new Size(119, 29);
            rbMultiplicar.TabIndex = 2;
            rbMultiplicar.TabStop = true;
            rbMultiplicar.Text = "Multiplicar";
            rbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbResta
            // 
            rbResta.AutoSize = true;
            rbResta.Location = new Point(23, 71);
            rbResta.Name = "rbResta";
            rbResta.Size = new Size(85, 29);
            rbResta.TabIndex = 1;
            rbResta.TabStop = true;
            rbResta.Text = "Restar";
            rbResta.UseVisualStyleBackColor = true;
            // 
            // rbSuma
            // 
            rbSuma.AutoSize = true;
            rbSuma.Location = new Point(23, 36);
            rbSuma.Name = "rbSuma";
            rbSuma.Size = new Size(88, 29);
            rbSuma.TabIndex = 0;
            rbSuma.TabStop = true;
            rbSuma.Text = "Sumar";
            rbSuma.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(79, 104);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(86, 25);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "resultado";
            lblResultado.Click += lblResultado_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(457, 62);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Clean";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 368);
            Controls.Add(btnLimpiar);
            Controls.Add(lblResultado);
            Controls.Add(gboxOperaciones);
            Controls.Add(button1);
            Controls.Add(textB);
            Controls.Add(textA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gboxOperaciones.ResumeLayout(false);
            gboxOperaciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textA;
        private TextBox textB;
        private Button button1;
        private GroupBox gboxOperaciones;
        private RadioButton rbMultiplicar;
        private RadioButton rbResta;
        private RadioButton rbSuma;
        private Label lblResultado;
        private Button btnLimpiar;
    }
}
