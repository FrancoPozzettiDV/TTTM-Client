using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeMasters.Models
{
    class UsuarioAPI
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public int puntaje { get; set; }
        public int partidasGanadas { get; set; }
        public int partidasJugadas { get; set; }

        public UsuarioAPI(int id, string nombre, string contraseña, int puntaje, int partidasGanadas, int partidasJugadas)
        {
            this.id = id;
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.puntaje = puntaje;
            this.partidasGanadas = partidasGanadas;
            this.partidasJugadas = partidasJugadas;
        }

        
    }
}
