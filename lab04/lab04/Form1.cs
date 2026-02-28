using lab04.controladores;
using lab04.entidades;

namespace lab04
{
    public partial class Form1 : Form
    {
        private Alumnocontroladores alumnocontroladores = new Alumnocontroladores();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAlumno(Alumnos[] alumnos)
        {

            dgAlumnos.DataSource = null;
            dgAlumnos.DataSource = alumnos;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbPromedio.Text == "")
            {
                MessageBox.Show("complete todos los campos");
                return;
            }
            Alumnos alumnos = new Alumnos()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Promedio = double.Parse(tbPromedio.Text)
            };

            alumnocontroladores.Registrar(alumnos);

            MostrarAlumno(alumnocontroladores.Listartodo());

            LimpiarCampos();




        }

        public void LimpiarCampos()
        {
            tbCodigo.Clear();
            tbNombre.Clear();
            tbPromedio.Clear();
            tbBuscar.Clear();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("seleccione un registro para eliminar");
                return;
            }


            String codigo = dgAlumnos.SelectedRows[0].Cells[0].Value.ToString();

            alumnocontroladores.Eliminar(codigo);

            MostrarAlumno(alumnocontroladores.Listartodo());
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MostrarAlumno(alumnocontroladores.Ordenar());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(tbBuscar.Text == "")
            {
                MessageBox.Show("ingrese el codigo a buscar");
                return;
            }
            String codigo = tbBuscar.Text;

            MostrarAlumno(alumnocontroladores.BuscarPorCodigo(codigo));
        
        }
    }
}
