namespace formulario6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(mskNumero.Text, out int numero))
            {
                if (numero <= 0)
                {
                    MessageBox.Show("Ingrese un número positivo.");
                    return;
                }

                int suma = 0;

                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        suma += i;
                    }
                }

                if (suma == numero)
                {
                    MessageBox.Show("Es un número perfecto.");
                }
                else
                {
                    MessageBox.Show("No es un número perfecto.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }
    }
}
