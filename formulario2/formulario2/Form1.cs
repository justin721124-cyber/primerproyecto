namespace formulario2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int tiempoTotalSegundos = 0;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMinutos.Text, out int minutos) &&
                int.TryParse(txtSegundos.Text, out int segundos))
            {
                tiempoTotalSegundos = (minutos * 60) + segundos;

                if (tiempoTotalSegundos > 0)
                {
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("Ingrese un tiempo mayor que cero.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempoTotalSegundos > 0)
            {
                tiempoTotalSegundos--;

                int minutos = tiempoTotalSegundos / 60;
                int segundos = tiempoTotalSegundos % 60;

                lblTiempo.Text = minutos.ToString("00") + ":" + segundos.ToString("00");
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("¡Tiempo terminado!");
            }
        }

        private void lblTiempo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
