namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double numero1) &&
                double.TryParse(txtNumero2.Text, out double numero2))
            {
                double resultado = numero1 + numero2;
                lblResultado.Text = "Resultado :" + (numero1 + numero2);
            }
            else
            {
                MessageBox.Show("por favor ingrese solo numros.");
            }



        }



    }


}

