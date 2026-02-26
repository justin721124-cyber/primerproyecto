namespace formulario3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbEntrada.Items.Add("Metros");
            cmbEntrada.Items.Add("Centímetros");
            cmbEntrada.Items.Add("Pulgadas");

            cmbSalida.Items.Add("Metros");
            cmbSalida.Items.Add("Centímetros");
            cmbSalida.Items.Add("Pulgadas");

            cmbEntrada.SelectedIndex = 0;
            cmbSalida.SelectedIndex = 1;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtValor.Text, out double valor))
            {
                double valorEnMetros = 0;
                double resultado = 0;


                switch (cmbEntrada.SelectedItem.ToString())
                {
                    case "Metros":
                        valorEnMetros = valor;
                        break;

                    case "Centímetros":
                        valorEnMetros = valor / 100;
                        break;

                    case "Pulgadas":
                        valorEnMetros = valor * 0.0254;
                        break;
                }


                switch (cmbSalida.SelectedItem.ToString())
                {
                    case "Metros":
                        resultado = valorEnMetros;
                        break;

                    case "Centímetros":
                        resultado = valorEnMetros * 100;
                        break;

                    case "Pulgadas":
                        resultado = valorEnMetros / 0.0254;
                        break;
                }

                lblResultado.Text = "Resultado: " + resultado.ToString("F4");
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
