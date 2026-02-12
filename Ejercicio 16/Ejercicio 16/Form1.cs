namespace Ejercicio_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double numero1 = 0;
        double numero2 = 0;
        string operador = "";
        bool nuevoNumero = true;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (nuevoNumero)
            {
                txtDisplay.Text = "";
                nuevoNumero = false;
            }

            txtDisplay.Text += boton.Text;
        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (nuevoNumero)
            {
                txtDisplay.Text = "";
                nuevoNumero = false;
            }

            txtDisplay.Text += boton.Text;
        }

        private void btnNumero4_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (nuevoNumero)
            {
                txtDisplay.Text = "";
                nuevoNumero = false;
            }

            txtDisplay.Text += boton.Text;
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (nuevoNumero)
            {
                txtDisplay.Text = "";
                nuevoNumero = false;
            }

            txtDisplay.Text += boton.Text;
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (nuevoNumero)
            {
                txtDisplay.Text = "";
                nuevoNumero = false;
            }

            txtDisplay.Text += boton.Text;
        }

        private void btnNumero7_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (nuevoNumero)
            {
                txtDisplay.Text = "";
                nuevoNumero = false;
            }

            txtDisplay.Text += boton.Text;
        }

        private void btnNumero8_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (nuevoNumero)
            {
                txtDisplay.Text = "";
                nuevoNumero = false;
            }

            txtDisplay.Text += boton.Text;
        }

        private void btnNumero9_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (nuevoNumero)
            {
                txtDisplay.Text = "";
                nuevoNumero = false;
            }

            txtDisplay.Text += boton.Text;
        }

        private void btnNumero0_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (nuevoNumero)
            {
                txtDisplay.Text = "";
                nuevoNumero = false;
            }

            txtDisplay.Text += boton.Text;
        }

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (nuevoNumero)
            {
                txtDisplay.Text = "";
                nuevoNumero = false;
            }

            txtDisplay.Text += boton.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            numero1 = Convert.ToDouble(txtDisplay.Text);
            operador = boton.Text;
            nuevoNumero = true;
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            numero1 = Convert.ToDouble(txtDisplay.Text);
            operador = boton.Text;
            nuevoNumero = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            numero1 = Convert.ToDouble(txtDisplay.Text);
            operador = boton.Text;
            nuevoNumero = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            numero1 = Convert.ToDouble(txtDisplay.Text);
            operador = boton.Text;
            nuevoNumero = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            else
                txtDisplay.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtDisplay.Text);

            switch (operador)
            {
                case "+":
                    txtDisplay.Text = (numero1 + numero2).ToString();
                    break;

                case "-":
                    txtDisplay.Text = (numero1 - numero2).ToString();
                    break;

                case "*":
                    txtDisplay.Text = (numero1 * numero2).ToString();
                    break;

                case "/":
                    if (numero2 != 0)
                        txtDisplay.Text = (numero1 / numero2).ToString();
                    else
                        MessageBox.Show("No se puede dividir entre cero");
                    break;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            numero1 = 0;
            numero2 = 0;
            operador = "";
            nuevoNumero = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (nuevoNumero)
            {
                txtDisplay.Text = "";
                nuevoNumero = false;
            }

            txtDisplay.Text += boton.Text;
        }
    }
}
