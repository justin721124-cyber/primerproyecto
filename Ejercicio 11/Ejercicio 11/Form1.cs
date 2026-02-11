using System.Windows.Forms;

namespace Ejercicio_11
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

        private void btnMostrarFecha_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dateTimePicker1.Value;

            lblFecha.Text = "Fecha seleccionada: " + fechaSeleccionada.ToString("dd/MM/yyyy");
        }

    }
}
