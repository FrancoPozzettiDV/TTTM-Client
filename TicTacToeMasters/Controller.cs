using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeMasters
{
    public class Controller
    {
        private FormLogin login;
        public FormMenu fm;
        private Models.ConexionSocketServer conexion = new Models.ConexionSocketServer();
        private Models.ConexionAPI api = Models.ConexionAPI.getInstancia();
        public Models.Jugador miJugador;
        public Models.Jugador jugadorRival;
        

        public Controller(FormLogin login)
        {
            this.login = login;
        }
      

        public void iniciar()
        {
            Application.Run(login);
            
        }
        public void loguarse()
        {
            if (login.verificarDatos())
            {
                Console.WriteLine("Datos correctos");
                string usuario = login.getUsuario();
                string contraseña = login.getContraseña();
                miJugador = api.obtenerUsuario(usuario,contraseña);
                if (miJugador == null)
                {
                    login.mostrarError("El usuario ingresado no existe o posee datos incorrectos");
                }
                else
                {

                    if (!conexion.conectar())
                    {
                        login.mostrarError("No es posible conectarse al servidor\nVuelva a intentar más tarde");
                    }
                    else
                    {
                        conexion.enviarMensaje(miJugador);
                        fm = new FormMenu(login,miJugador,this);
                        fm.Show();
                        login.Hide();
                    }
                }
            }
        }
        
        
        
        public void jugar()
        {
           
            conexion.entrarCola(miJugador);
            FormEnCola fec = new FormEnCola(this,fm);
            fec.Show();
            conexion.enviarMensaje(miJugador);
            
            obtenerRival();

            if (obtenerRival() != null)
            {
                fec.jugadorObtenido();
                MessageBox.Show("Presione aceptar para empezar");
                salirCola();
                fec.Close();
                fm.botonJugar();
                FormJuego fj = new FormJuego(fm, miJugador, this);
                fj.Show();
                fj.obtenerJugadores(miJugador, jugadorRival);
                fm.Hide();
            }
     
            
        }

        public string mensajesPartida(string msj)
        {
            conexion.enviarMensaje(msj);
            return conexion.obtenerMensaje();
        }

        public Models.Jugador obtenerRival()
        {
            jugadorRival = conexion.obtenerRival();
            return jugadorRival;
        }

        public void salirCola()
        {
            conexion.salirCola(miJugador);
            conexion.enviarMensaje(miJugador);
        }

        
        
    }
}
