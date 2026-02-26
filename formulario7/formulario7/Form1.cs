namespace formulario7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Primos.Items.Clear();

            if (int.TryParse(txtInicio.Text, out int inicio) &&
                int.TryParse(txtFin.Text, out int fin))
            {
                if (inicio > fin)
                {
                    MessageBox.Show("El número inicial debe ser menor que el final.");
                    return;
                }

                for (int numero = inicio; numero <= fin; numero++)
                {
                    if (EsPrimo(numero))
                    {
                        Primos.Items.Add(numero);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos.");
            }
        }



        private bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }

}   }
