namespace SistemaCitasSpa
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
            menuStrip1 = new MenuStrip();
            menuPrincipalToolStripMenuItem = new ToolStripMenuItem();
            mostrarCitasToolStripMenuItem = new ToolStripMenuItem();
            agendarCitaToolStripMenuItem = new ToolStripMenuItem();
            actualizarCitaToolStripMenuItem = new ToolStripMenuItem();
            eliminarCitaToolStripMenuItem = new ToolStripMenuItem();
            exportarCitaCVSToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Silver;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuPrincipalToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1257, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mostrarCitasToolStripMenuItem, agendarCitaToolStripMenuItem, actualizarCitaToolStripMenuItem, eliminarCitaToolStripMenuItem, exportarCitaCVSToolStripMenuItem, salirToolStripMenuItem });
            menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            menuPrincipalToolStripMenuItem.Size = new Size(144, 29);
            menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            // 
            // mostrarCitasToolStripMenuItem
            // 
            mostrarCitasToolStripMenuItem.BackColor = Color.FromArgb(255, 192, 128);
            mostrarCitasToolStripMenuItem.Name = "mostrarCitasToolStripMenuItem";
            mostrarCitasToolStripMenuItem.Size = new Size(270, 34);
            mostrarCitasToolStripMenuItem.Text = "Mostrar Citas";
            mostrarCitasToolStripMenuItem.Click += mostrarCitasToolStripMenuItem_Click;
            // 
            // agendarCitaToolStripMenuItem
            // 
            agendarCitaToolStripMenuItem.BackColor = Color.FromArgb(255, 192, 128);
            agendarCitaToolStripMenuItem.Name = "agendarCitaToolStripMenuItem";
            agendarCitaToolStripMenuItem.Size = new Size(270, 34);
            agendarCitaToolStripMenuItem.Text = "Agendar Cita";
            agendarCitaToolStripMenuItem.Click += agendarCitaToolStripMenuItem_Click;
            // 
            // actualizarCitaToolStripMenuItem
            // 
            actualizarCitaToolStripMenuItem.BackColor = Color.FromArgb(255, 192, 128);
            actualizarCitaToolStripMenuItem.Name = "actualizarCitaToolStripMenuItem";
            actualizarCitaToolStripMenuItem.Size = new Size(270, 34);
            actualizarCitaToolStripMenuItem.Text = "Actualizar Cita";
            actualizarCitaToolStripMenuItem.Click += actualizarCitaToolStripMenuItem_Click;
            // 
            // eliminarCitaToolStripMenuItem
            // 
            eliminarCitaToolStripMenuItem.BackColor = Color.FromArgb(255, 192, 128);
            eliminarCitaToolStripMenuItem.Name = "eliminarCitaToolStripMenuItem";
            eliminarCitaToolStripMenuItem.Size = new Size(270, 34);
            eliminarCitaToolStripMenuItem.Text = "Eliminar Cita";
            eliminarCitaToolStripMenuItem.Click += eliminarCitaToolStripMenuItem_Click;
            // 
            // exportarCitaCVSToolStripMenuItem
            // 
            exportarCitaCVSToolStripMenuItem.BackColor = Color.FromArgb(255, 192, 128);
            exportarCitaCVSToolStripMenuItem.Name = "exportarCitaCVSToolStripMenuItem";
            exportarCitaCVSToolStripMenuItem.Size = new Size(270, 34);
            exportarCitaCVSToolStripMenuItem.Text = "Exportar Cita CSV";
            exportarCitaCVSToolStripMenuItem.Click += exportarCitaCVSToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.BackColor = Color.FromArgb(255, 192, 128);
            salirToolStripMenuItem.ForeColor = Color.Red;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(270, 34);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1257, 638);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1.listaCitas";
            TransparencyKey = Color.FromArgb(255, 192, 128);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private ToolStripMenuItem mostrarCitasToolStripMenuItem;
        private ToolStripMenuItem agendarCitaToolStripMenuItem;
        private ToolStripMenuItem actualizarCitaToolStripMenuItem;
        private ToolStripMenuItem eliminarCitaToolStripMenuItem;
        private ToolStripMenuItem exportarCitaCVSToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}
