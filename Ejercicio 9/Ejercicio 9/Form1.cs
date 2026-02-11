namespace Ejercicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int numero;

                if (int.TryParse(textBox1.Text, out numero))
                {
                    MessageBox.Show(
                        "Número válido ingresado.",
                        "Correcto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Error: Debe ingresar un número válido.",
                        "Entrada incorrecta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    textBox1.Clear();
                    textBox1.Focus();
                }
            }

        }
    }
}

