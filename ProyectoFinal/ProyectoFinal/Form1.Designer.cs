namespace ProyectoFinal
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
            mostrarToolStripMenuItem = new ToolStripMenuItem();
            crearToolStripMenuItem = new ToolStripMenuItem();
            actualizarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            exportarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuPrincipalToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mostrarToolStripMenuItem, crearToolStripMenuItem, actualizarToolStripMenuItem, eliminarToolStripMenuItem, exportarToolStripMenuItem, salirToolStripMenuItem });
            menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            menuPrincipalToolStripMenuItem.Size = new Size(144, 29);
            menuPrincipalToolStripMenuItem.Text = "Menu Principal";
        
            // 
            // mostrarToolStripMenuItem
            // 
            mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            mostrarToolStripMenuItem.Size = new Size(270, 34);
            mostrarToolStripMenuItem.Text = "Mostrar Citas";
            // 
            // crearToolStripMenuItem
            // 
            crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            crearToolStripMenuItem.Size = new Size(270, 34);
            crearToolStripMenuItem.Text = "Agendar Citas";
            // 
            // actualizarToolStripMenuItem
            // 
            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Size = new Size(270, 34);
            actualizarToolStripMenuItem.Text = "Actualizar";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(270, 34);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // exportarToolStripMenuItem
            // 
            exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            exportarToolStripMenuItem.Size = new Size(270, 34);
            exportarToolStripMenuItem.Text = "Exportar";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(270, 34);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
  
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private ToolStripMenuItem mostrarToolStripMenuItem;
        private ToolStripMenuItem crearToolStripMenuItem;
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem exportarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}
