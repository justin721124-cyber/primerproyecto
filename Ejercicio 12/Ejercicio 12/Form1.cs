namespace Ejercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double celsius;

            // Validar que sea número
            if (double.TryParse(txtCelsius.Text, out celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;

                lblResultado.Text = "Resultado: " + fahrenheit.ToString("F2") + " °F";
            }
            else
            {
                MessageBox.Show(
                    "Por favor ingrese un valor numérico válido.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtCelsius.Clear();
                txtCelsius.Focus();
            }
        }

        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {

        }
    }

}


