namespace SistemaCitasSpa
{
    partial class FormActualizar
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
            btnBuscar = new Button();
            txtNombre = new TextBox();
            txtDentista = new TextBox();
            cmbServicio = new ComboBox();
            txtTerapeuta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 42);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(128, 255, 128);
            btnBuscar.Location = new Point(29, 79);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 94);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Actualizar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(255, 224, 192);
            txtNombre.Location = new Point(180, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtDentista
            // 
            txtDentista.BackColor = Color.FromArgb(255, 224, 192);
            txtDentista.Location = new Point(505, 81);
            txtDentista.Name = "txtDentista";
            txtDentista.Size = new Size(150, 31);
            txtDentista.TabIndex = 4;
            // 
            // cmbServicio
            // 
            cmbServicio.BackColor = Color.FromArgb(255, 224, 192);
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Location = new Point(327, 79);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(182, 33);
            cmbServicio.TabIndex = 5;
            // 
            // txtTerapeuta
            // 
            txtTerapeuta.BackColor = Color.FromArgb(255, 224, 192);
            txtTerapeuta.Location = new Point(652, 81);
            txtTerapeuta.Name = "txtTerapeuta";
            txtTerapeuta.Size = new Size(150, 31);
            txtTerapeuta.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 48);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 7;
            label1.Text = "Nombre P.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 51);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 8;
            label2.Text = "Servicio";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(559, 48);
            label3.Name = "label3";
            label3.Size = new Size(35, 25);
            label3.TabIndex = 9;
            label3.Text = "Dr.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(686, 48);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 10;
            label4.Text = "Terapeuta";
            // 
            // FormActualizar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(810, 302);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTerapeuta);
            Controls.Add(cmbServicio);
            Controls.Add(txtDentista);
            Controls.Add(txtNombre);
            Controls.Add(btnBuscar);
            Controls.Add(txtId);
            Name = "FormActualizar";
            Text = "FormActualizar";
            Load += FormActualizar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Button btnBuscar;
        private TextBox dtpFecha;
        private TextBox txtNombre;
        private TextBox txtDentista;
        private ComboBox cmbServicio;
        private TextBox txtTerapeuta;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}