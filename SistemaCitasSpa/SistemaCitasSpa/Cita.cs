using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SistemaCitasSpa
{
    
    public class Cita
    {
        public string Id { get; set; }
        public string NombrePaciente { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Dentista { get; set; }
        public string Servicio { get; set; }
        public int Duracion { get; set; }
        public string Terapeuta { get; set; }
        public int DiasRestantes { get; set; }
        public string Estado { get; set; }
    }
}
