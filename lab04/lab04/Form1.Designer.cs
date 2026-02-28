namespace lab04
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbPromedio = new TextBox();
            tbNombre = new TextBox();
            tbCodigo = new TextBox();
            btnBuscar = new Button();
            btnOrdenar = new Button();
            btnEliminar = new Button();
            btnRegistrar = new Button();
            label4 = new Label();
            tbBuscar = new TextBox();
            dgAlumnos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 38);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 91);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 134);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 2;
            label3.Text = "Promedio";
            label3.Click += label3_Click;
            // 
            // tbPromedio
            // 
            tbPromedio.Location = new Point(256, 134);
            tbPromedio.Name = "tbPromedio";
            tbPromedio.Size = new Size(150, 31);
            tbPromedio.TabIndex = 3;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(254, 85);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(198, 31);
            tbNombre.TabIndex = 4;
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(254, 38);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(150, 31);
            tbCodigo.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(471, 200);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 47);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(316, 206);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(112, 34);
            btnOrdenar.TabIndex = 7;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(160, 206);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(8, 206);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 260);
            label4.Name = "label4";
            label4.Size = new Size(157, 25);
            label4.TabIndex = 10;
            label4.Text = "Buscar por codigo";
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(188, 260);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(150, 31);
            tbBuscar.TabIndex = 11;
            // 
            // dgAlumnos
            // 
            dgAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAlumnos.Location = new Point(12, 297);
            dgAlumnos.Name = "dgAlumnos";
            dgAlumnos.RowHeadersWidth = 62;
            dgAlumnos.Size = new Size(571, 143);
            dgAlumnos.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(800, 450);
            Controls.Add(dgAlumnos);
            Controls.Add(tbBuscar);
            Controls.Add(label4);
            Controls.Add(btnRegistrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnOrdenar);
            Controls.Add(btnBuscar);
            Controls.Add(tbCodigo);
            Controls.Add(tbNombre);
            Controls.Add(tbPromedio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbPromedio;
        private TextBox tbNombre;
        private TextBox tbCodigo;
        private Button btnBuscar;
        private Button btnOrdenar;
        private Button btnEliminar;
        private Button btnRegistrar;
        private Label label4;
        private TextBox tbBuscar;
        private DataGridView dgAlumnos;
    }
}
