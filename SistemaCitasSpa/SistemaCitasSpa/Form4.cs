using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaCitasSpa
{
    public partial class FormActualizar : Form
    {
        public FormActualizar()
        {
            InitializeComponent();
        }

        private void FormActualizar_Load(object sender, EventArgs e)
        {
            var cita = Form1.listaCitas.Find(c => c.Id == txtId.Text);

            if (cita == null)
            {
                MessageBox.Show("No existe");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            var cita = Form1.listaCitas.Find(c => c.Id == txtId.Text);

            if (cita == null)
            {
                MessageBox.Show("No existe la cita");
            }
            else
            {
                txtNombre.Text = cita.NombrePaciente;
                txtDentista.Text = cita.Dentista;
                cmbServicio.Text = cita.Servicio;
                txtTerapeuta.Text = cita.Terapeuta;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
