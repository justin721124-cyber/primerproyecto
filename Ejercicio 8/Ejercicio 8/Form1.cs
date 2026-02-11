namespace Ejercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtMostrar.Text);
            count++;
            txtMostrar.Text = count.ToString();

        }
    }
}
