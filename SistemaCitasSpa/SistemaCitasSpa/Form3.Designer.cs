namespace SistemaCitasSpa
{
    partial class FormAgendar
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
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtDentista = new TextBox();
            txtTerapeuta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpFecha = new DateTimePicker();
            cmbServicio = new ComboBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(255, 224, 192);
            txtId.Location = new Point(39, 99);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(255, 224, 192);
            txtNombre.Location = new Point(258, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += textBox2_TextChanged;
            // 
            // txtDentista
            // 
            txtDentista.BackColor = Color.FromArgb(255, 224, 192);
            txtDentista.Location = new Point(39, 181);
            txtDentista.Name = "txtDentista";
            txtDentista.Size = new Size(150, 31);
            txtDentista.TabIndex = 2;
            // 
            // txtTerapeuta
            // 
            txtTerapeuta.BackColor = Color.FromArgb(255, 224, 192);
            txtTerapeuta.Location = new Point(258, 181);
            txtTerapeuta.Name = "txtTerapeuta";
            txtTerapeuta.Size = new Size(150, 31);
            txtTerapeuta.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 53);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 53);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 144);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 6;
            label3.Text = "Dentista";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 144);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 7;
            label4.Text = "Terapeuta";
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarMonthBackground = Color.FromArgb(255, 192, 128);
            dtpFecha.Location = new Point(39, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(369, 31);
            dtpFecha.TabIndex = 10;
            dtpFecha.Value = new DateTime(2026, 4, 4, 1, 8, 56, 0);
            // 
            // cmbServicio
            // 
            cmbServicio.BackColor = Color.FromArgb(255, 224, 192);
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Items.AddRange(new object[] { "Manicura", "Masaje", "Facial" });
            cmbServicio.Location = new Point(134, 244);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(182, 33);
            cmbServicio.TabIndex = 11;
            cmbServicio.Tag = "";
            cmbServicio.Text = "Servicio";
            cmbServicio.SelectedIndexChanged += cmbServicio_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 255, 128);
            btnGuardar.Location = new Point(500, 338);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 85);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormAgendar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(648, 435);
            Controls.Add(btnGuardar);
            Controls.Add(cmbServicio);
            Controls.Add(dtpFecha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTerapeuta);
            Controls.Add(txtDentista);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Name = "FormAgendar";
            Text = "FormAgendar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtDentista;
        private TextBox txtTerapeuta;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;


        private DateTimePicker dtpFecha;
        private ComboBox cmbServicio;
        private Button btnGuardar;
    }  
}