namespace MdiContainer
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
            menuToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem1 = new ToolStripMenuItem();
            registrosPersonalesToolStripMenuItem = new ToolStripMenuItem();
            conversorDeDivisasToolStripMenuItem = new ToolStripMenuItem();
            serieFibonacciToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Highlight;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.BackColor = SystemColors.Highlight;
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuToolStripMenuItem1, registrosPersonalesToolStripMenuItem, conversorDeDivisasToolStripMenuItem, serieFibonacciToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(94, 29);
            menuToolStripMenuItem.Text = "Menu ☰";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // menuToolStripMenuItem1
            // 
            menuToolStripMenuItem1.BackColor = SystemColors.Highlight;
            menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            menuToolStripMenuItem1.Size = new Size(280, 34);
            menuToolStripMenuItem1.Text = "Menu ☰ ";
            // 
            // registrosPersonalesToolStripMenuItem
            // 
            registrosPersonalesToolStripMenuItem.BackColor = SystemColors.Highlight;
            registrosPersonalesToolStripMenuItem.Name = "registrosPersonalesToolStripMenuItem";
            registrosPersonalesToolStripMenuItem.Size = new Size(280, 34);
            registrosPersonalesToolStripMenuItem.Text = "Registros Personales";
            registrosPersonalesToolStripMenuItem.Click += registrosPersonalesToolStripMenuItem_Click;
            // 
            // conversorDeDivisasToolStripMenuItem
            // 
            conversorDeDivisasToolStripMenuItem.BackColor = SystemColors.Highlight;
            conversorDeDivisasToolStripMenuItem.Name = "conversorDeDivisasToolStripMenuItem";
            conversorDeDivisasToolStripMenuItem.Size = new Size(280, 34);
            conversorDeDivisasToolStripMenuItem.Text = "Conversor de Divisas";
            // 
            // serieFibonacciToolStripMenuItem
            // 
            serieFibonacciToolStripMenuItem.BackColor = SystemColors.Highlight;
            serieFibonacciToolStripMenuItem.Name = "serieFibonacciToolStripMenuItem";
            serieFibonacciToolStripMenuItem.Size = new Size(280, 34);
            serieFibonacciToolStripMenuItem.Text = "Serie Fibonacci";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem1;
        private ToolStripMenuItem registrosPersonalesToolStripMenuItem;
        private ToolStripMenuItem conversorDeDivisasToolStripMenuItem;
        private ToolStripMenuItem serieFibonacciToolStripMenuItem;
    }
}
