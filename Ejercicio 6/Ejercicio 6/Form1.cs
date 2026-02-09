namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbColores.Items.Add("Rojo");
            cmbColores.Items.Add("Azul");
            cmbColores.Items.Add("verde");
        }

        private void cmbColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColores.SelectedItem.ToString() == "Rojo")
            {
                this.BackColor = Color.Red;
            }
            else if (cmbColores.SelectedItem.ToString() == "Verde")
            {
                this.BackColor = Color.Green;
            }
            else if (cmbColores.SelectedItem.ToString() == "Azul")
            {
                this.BackColor = Color.Blue;
            }
        }
    }
}
