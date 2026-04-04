namespace SistemaCitasSpa
{
    partial class FormMostrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombrePacienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dentistaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            servicioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            duracionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            terapeutaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diasRestantesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            citaBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)citaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombrePacienteDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn, horaDataGridViewTextBoxColumn, dentistaDataGridViewTextBoxColumn, servicioDataGridViewTextBoxColumn, duracionDataGridViewTextBoxColumn, terapeutaDataGridViewTextBoxColumn, diasRestantesDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = citaBindingSource;
            dataGridView1.GridColor = Color.FromArgb(255, 192, 128);
            dataGridView1.Location = new Point(0, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(665, 194);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombrePacienteDataGridViewTextBoxColumn
            // 
            nombrePacienteDataGridViewTextBoxColumn.DataPropertyName = "NombrePaciente";
            nombrePacienteDataGridViewTextBoxColumn.HeaderText = "NombrePaciente";
            nombrePacienteDataGridViewTextBoxColumn.MinimumWidth = 8;
            nombrePacienteDataGridViewTextBoxColumn.Name = "nombrePacienteDataGridViewTextBoxColumn";
            nombrePacienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.MinimumWidth = 8;
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.Width = 150;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            horaDataGridViewTextBoxColumn.MinimumWidth = 8;
            horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            horaDataGridViewTextBoxColumn.Width = 150;
            // 
            // dentistaDataGridViewTextBoxColumn
            // 
            dentistaDataGridViewTextBoxColumn.DataPropertyName = "Dentista";
            dentistaDataGridViewTextBoxColumn.HeaderText = "Dentista";
            dentistaDataGridViewTextBoxColumn.MinimumWidth = 8;
            dentistaDataGridViewTextBoxColumn.Name = "dentistaDataGridViewTextBoxColumn";
            dentistaDataGridViewTextBoxColumn.Width = 150;
            // 
            // servicioDataGridViewTextBoxColumn
            // 
            servicioDataGridViewTextBoxColumn.DataPropertyName = "Servicio";
            servicioDataGridViewTextBoxColumn.HeaderText = "Servicio";
            servicioDataGridViewTextBoxColumn.MinimumWidth = 8;
            servicioDataGridViewTextBoxColumn.Name = "servicioDataGridViewTextBoxColumn";
            servicioDataGridViewTextBoxColumn.Width = 150;
            // 
            // duracionDataGridViewTextBoxColumn
            // 
            duracionDataGridViewTextBoxColumn.DataPropertyName = "Duracion";
            duracionDataGridViewTextBoxColumn.HeaderText = "Duracion";
            duracionDataGridViewTextBoxColumn.MinimumWidth = 8;
            duracionDataGridViewTextBoxColumn.Name = "duracionDataGridViewTextBoxColumn";
            duracionDataGridViewTextBoxColumn.Width = 150;
            // 
            // terapeutaDataGridViewTextBoxColumn
            // 
            terapeutaDataGridViewTextBoxColumn.DataPropertyName = "Terapeuta";
            terapeutaDataGridViewTextBoxColumn.HeaderText = "Terapeuta";
            terapeutaDataGridViewTextBoxColumn.MinimumWidth = 8;
            terapeutaDataGridViewTextBoxColumn.Name = "terapeutaDataGridViewTextBoxColumn";
            terapeutaDataGridViewTextBoxColumn.Width = 150;
            // 
            // diasRestantesDataGridViewTextBoxColumn
            // 
            diasRestantesDataGridViewTextBoxColumn.DataPropertyName = "DiasRestantes";
            diasRestantesDataGridViewTextBoxColumn.HeaderText = "DiasRestantes";
            diasRestantesDataGridViewTextBoxColumn.MinimumWidth = 8;
            diasRestantesDataGridViewTextBoxColumn.Name = "diasRestantesDataGridViewTextBoxColumn";
            diasRestantesDataGridViewTextBoxColumn.Width = 150;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.MinimumWidth = 8;
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.Width = 150;
            // 
            // citaBindingSource
            // 
            citaBindingSource.DataSource = typeof(Cita);
            // 
            // FormMostrar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(707, 342);
            Controls.Add(dataGridView1);
            Name = "FormMostrar";
            Text = "FormMostrar";
            Load += FormMostrar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)citaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource citaBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombrePacienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dentistaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn servicioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn terapeutaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diasRestantesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}