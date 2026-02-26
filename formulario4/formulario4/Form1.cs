namespace formulario4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(palabra))
            {
                MessageBox.Show("Por favor, ingrese una palabra.");
                return;
            }

            string palabraInvertida = "";

            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                palabraInvertida += palabra[i];
            }

            if (palabra == palabraInvertida)
            {
                MessageBox.Show("Es una palabra Palíndroma.");
            }
            else
            {
                MessageBox.Show("No es una palabra Palíndroma.");
            }

        }
    }
}
