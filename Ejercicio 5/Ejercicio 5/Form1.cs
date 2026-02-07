namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a = 0.0;
            double b = 0.0;
            double m = 0.0;

            a = Convert.ToDouble(textA.Text);
            b = Convert.ToDouble(textB.Text);

            if (rbSuma.Checked == true)
                m = a + b;
            if (rbResta.Checked == true)
                m = a - b;
            if (rbMultiplicar.Checked == true)
                m = a * b;
            lblResultado.Text = m.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textA.Text = "0";
            textB.Text = "0";
            lblResultado.Text = "0";

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
