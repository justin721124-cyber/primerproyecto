namespace SistemaCitasSpa
{


    public partial class Form1 : Form
    {
        public static List<Cita> listaCitas = new List<Cita>();
        public Form1()
        {
            InitializeComponent();
        }

        private void mostrarCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMostrar f = new FormMostrar();
            f.MdiParent = this;
            f.Show();
        }

        private void agendarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgendar f = new FormAgendar();
            f.MdiParent = this;
            f.Show();


        }

        private void actualizarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActualizar f = new FormActualizar();
            f.MdiParent = this;
            f.Show();
        }

        private void eliminarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminar f = new FormEliminar();
            f.MdiParent = this;
            f.Show();
        }

        private void exportarCitaCVSToolStripMenuItem_Click(object sender, EventArgs e)
        {


            StreamWriter sw = new StreamWriter("citas.csv");

            foreach (var c in Form1.listaCitas)
            {
                sw.WriteLine($"{c.Id},{c.NombrePaciente},{c.Fecha},{c.Servicio},{c.Estado}");
            }

            sw.Close();
            MessageBox.Show("Exportado");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

} 
