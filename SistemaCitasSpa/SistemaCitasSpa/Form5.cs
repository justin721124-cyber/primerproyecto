using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace SistemaCitasSpa
{
    public partial class FormEliminar : Form
    {
        public FormEliminar()
        {
            InitializeComponent();
        }

        private void FormEliminar_Load(object sender, EventArgs e)
        {
            var cita = Form1.listaCitas.Find(c => c.Id == txtId.Text);

            if (cita != null)
            {
                Form1.listaCitas.Remove(cita);
                MessageBox.Show("Eliminado");
            }
            else
            {
                MessageBox.Show("No existe");
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
         
        
            try
            {
                StreamWriter sw = new StreamWriter("citas.csv");

                foreach (var c in Form1.listaCitas)
                {
                    sw.WriteLine($"{c.Id},{c.NombrePaciente},{c.Fecha},{c.Servicio},{c.Estado}");
                }

                sw.Close();

                MessageBox.Show("Eliminado");
            }
            catch
            {
                MessageBox.Show("Error al eliminar");
            }
        }
    }
    
}
