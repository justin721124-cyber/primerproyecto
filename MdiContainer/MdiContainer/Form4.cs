using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MdiContainer
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int limite = Convert.ToInt32(textBoxLimite.Text);

            int a = 0;
            int b = 1;

            textBoxResultado.Clear();

            while (a <= limite)
            {
                textBoxResultado.AppendText(a + " ");

                int siguiente = a + b;
                a = b;
                b = siguiente;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
