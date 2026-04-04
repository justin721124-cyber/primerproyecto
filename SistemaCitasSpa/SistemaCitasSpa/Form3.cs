using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaCitasSpa
{
    public partial class FormAgendar : Form
    {
        public FormAgendar()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                
                foreach (var c in Form1.listaCitas)
                {
                    if (c.Id == txtId.Text)
                    {
                        MessageBox.Show("ID ya existe");
                        return;
                    }
                }

                
                int duracion = 0;

                if (cmbServicio.Text == "Masaje") duracion = 60;
                if (cmbServicio.Text == "Facial") duracion = 45;
                if (cmbServicio.Text == "Manicura") duracion = 30;
                if (cmbServicio.Text == "caries") duracion = 50;
                if (cmbServicio.Text == "limpieza") duracion = 55;
                
                int dias = (dtpFecha.Value - DateTime.Now).Days;

                
                string estado = "";

                if (dias > 0) estado = "Vigente";
                else if (dias == 0) estado = "En proceso";
                else estado = "Finalizado";

                
                Cita nueva = new Cita();

                nueva.Id = txtId.Text;
                nueva.NombrePaciente = txtNombre.Text;
                nueva.Fecha = dtpFecha.Value;
                nueva.Dentista = txtDentista.Text;
                nueva.Servicio = cmbServicio.Text;
                nueva.Terapeuta = txtTerapeuta.Text;

                
                nueva.Duracion = duracion;
                nueva.DiasRestantes = dias;
                nueva.Estado = estado;

                
                Form1.listaCitas.Add(nueva);

                MessageBox.Show("Cita guardada");
            }
            catch
            {
                MessageBox.Show("Error en los datos");
            }
        }

        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
