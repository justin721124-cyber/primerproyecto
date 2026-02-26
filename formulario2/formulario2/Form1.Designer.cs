namespace formulario2
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
            components = new System.ComponentModel.Container();
            btnIniciar = new Button();
            lblTiempo = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMinutos = new TextBox();
            txtSegundos = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(54, 104);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(112, 34);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTiempo.Location = new Point(227, 192);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(104, 48);
            lblTiempo.TabIndex = 1;
            lblTiempo.Text = "00:00";
            lblTiempo.Click += lblTiempo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 164);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 2;
            label2.Text = "segundos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 9);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 3;
            label3.Text = "minutos";
            label3.Click += label3_Click;
            // 
            // txtMinutos
            // 
            txtMinutos.Location = new Point(33, 45);
            txtMinutos.Name = "txtMinutos";
            txtMinutos.Size = new Size(150, 31);
            txtMinutos.TabIndex = 4;
            txtMinutos.TextChanged += textBox1_TextChanged;
            // 
            // txtSegundos
            // 
            txtSegundos.Location = new Point(33, 192);
            txtSegundos.Name = "txtSegundos";
            txtSegundos.Size = new Size(150, 31);
            txtSegundos.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 308);
            Controls.Add(txtSegundos);
            Controls.Add(txtMinutos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTiempo);
            Controls.Add(btnIniciar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Label lblTiempo;
        private Label label2;
        private Label label3;
        private TextBox txtMinutos;
        private TextBox txtSegundos;
        private System.Windows.Forms.Timer timer1;
    }
}
