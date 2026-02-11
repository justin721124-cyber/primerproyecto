namespace Ejercicio_7
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
            lstColores = new ListBox();
            txtColores = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // lstColores
            // 
            lstColores.BackColor = Color.Bisque;
            lstColores.FormattingEnabled = true;
            lstColores.Items.AddRange(new object[] { "azul", "verde ", "rosado" });
            lstColores.Location = new Point(12, 157);
            lstColores.Name = "lstColores";
            lstColores.Size = new Size(180, 129);
            lstColores.TabIndex = 0;
            lstColores.SelectedIndexChanged += lstColores_SelectedIndexChanged;
            // 
            // txtColores
            // 
            txtColores.BackColor = Color.Crimson;
            txtColores.ForeColor = Color.White;
            txtColores.Location = new Point(12, 36);
            txtColores.Name = "txtColores";
            txtColores.Size = new Size(180, 31);
            txtColores.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Crimson;
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(342, 204);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(159, 82);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(513, 322);
            Controls.Add(btnAgregar);
            Controls.Add(txtColores);
            Controls.Add(lstColores);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstColores;
        private TextBox txtColores;
        private Button btnAgregar;
    }
}
