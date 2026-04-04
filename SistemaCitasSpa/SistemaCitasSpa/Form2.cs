using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaCitasSpa
{
    public partial class FormMostrar : Form
    {
        public FormMostrar()
        {
            InitializeComponent();
        }

        private void FormMostrar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Form1.listaCitas;
        }
    }
}
