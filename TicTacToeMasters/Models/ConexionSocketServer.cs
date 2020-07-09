using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Security.Cryptography;
using Newtonsoft.Json;

namespace TicTacToeMasters.Models
{
    class ConexionSocketServer
    {
        TcpClient socket = new TcpClient();
        NetworkStream stream;
        Jugador rival = null;
        string message = "";

        public bool conectar()
        {
            try
            {
                conectarPrivate();
                return true;
            }
            catch (SocketException )
            {
              Console.WriteLine("No es posible conectarse al servidor\nVuelva a intentar más tarde");
              return false;
            }
        }
        
        private void conectarPrivate()
        {
            Console.WriteLine("Estableciendo conexión con el servidor");

            // 127.0.0.1 : Localhost
            socket.Connect("127.0.0.1", 8000);
            stream = socket.GetStream();
        }

        public void enviarMensaje(Jugador miJugador)
        {
            
            var msgEnv = JsonConvert.SerializeObject(miJugador);
            var sendBytes = System.Text.Encoding.ASCII.GetBytes(msgEnv);
            byte[] intBytes = BitConverter.GetBytes(sendBytes.Length);
            stream.Write(intBytes, 0, intBytes.Length);
            stream.Write(sendBytes, 0, sendBytes.Length);
            stream.Flush();
            recibirMensaje();
        }

        public void enviarMensaje(string message)
        {
            
            var msgEnv = message;
            var sendBytes = System.Text.Encoding.ASCII.GetBytes(msgEnv);
            byte[] intBytes = BitConverter.GetBytes(sendBytes.Length);
            stream.Write(intBytes, 0, intBytes.Length);
            stream.Write(sendBytes, 0, sendBytes.Length);
            stream.Flush();
            recibirMensaje();
        }

        public void recibirMensaje()
        {
            byte[] bytesFrom = new byte[4];
            Jugador jugadorRival = null;
            stream.Read(bytesFrom, 0, bytesFrom.Length);
            int buffersize = BitConverter.ToInt32(bytesFrom, 0);
            bytesFrom = new byte[buffersize];
            stream.Read(bytesFrom, 0, bytesFrom.Length);
            var msgRec = System.Text.Encoding.ASCII.GetString(bytesFrom);
            if (msgRec.Contains("usuario"))
            {
                jugadorRival = JsonConvert.DeserializeObject<Jugador>(msgRec);
                rival = jugadorRival;   
            }
            else
            {
                message = msgRec;
                //System.Console.WriteLine(msgRec);
            } 
        }
        
        public Jugador obtenerRival()
        {
           return rival;
        }
        public void eliminarRival()
        {
            rival = null;
        }

        public string obtenerMensaje()
        {
            return message;
        }

        public void entrarCola(Jugador miJugador)
        {
            miJugador.setMensaje(1);
        }
        public void salirCola(Jugador miJugador)
        {
            miJugador.setMensaje(2);
        }
       
       
    }
}
