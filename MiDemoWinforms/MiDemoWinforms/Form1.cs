namespace MiDemoWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            MessageBox.Show("Hola que tal, mi nombre es " + nombre);
        }
    }
}
