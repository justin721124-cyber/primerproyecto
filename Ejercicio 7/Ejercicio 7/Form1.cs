namespace Ejercicio_7
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lstColores.Items.Add(txtColores.Text);

        }

        private void lstColores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
