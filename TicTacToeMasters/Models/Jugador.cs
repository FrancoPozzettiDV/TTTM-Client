using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace TicTacToeMasters.Models
{
    public class Jugador
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public int puntaje { get; set; }
        public int partidasJugadas { get; set; }
        public int partidasGanadas { get; set; }
        public int mensaje { get; set; }
        public TcpClient conexion { get; set; }

        public Jugador(int id, string usuario, int puntaje, int partidasJugadas, int partidasGanadas)
        {
            this.id = id;
            this.usuario = usuario;
            this.puntaje = puntaje;
            this.partidasJugadas = partidasJugadas;
            this.partidasGanadas = partidasGanadas;
            this.mensaje = 0;
            this.conexion = null;
            

        }

        public float calcularPorcentaje()
        {
            return (partidasGanadas * 100) / partidasJugadas;
        }

        public void setMensaje(int msg)
        {
            this.mensaje = msg;
        }


        public void generarJugada()
        {

        }
    }
}
