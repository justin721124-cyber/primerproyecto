using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MdiContainer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBoxOrigen.Items.Add("DOP");
            comboBoxOrigen.Items.Add("USD");
         

            comboBoxDestino.Items.Add("DOP");
            comboBoxDestino.Items.Add("USD");
          
        }

        private void buttonConvertir_Click(object sender, EventArgs e)
        {
            double monto = Convert.ToDouble(textBoxMonto.Text);
            double resultado = 0;

            if (comboBoxOrigen.Text == "USD" && comboBoxDestino.Text == "DOP")
                resultado = monto * 63;

            else if (comboBoxOrigen.Text == "DOP" && comboBoxDestino.Text == "USD")
                resultado = monto / 63;

            else
                resultado = monto;

            label4.Text = "Resultado: " + resultado.ToString();
        }

        private void comboBoxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
