using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeMasters.Models
{
    class ConexionAPI
    {

        public static ConexionAPI instancia;
        RestClient client = new RestClient("https://localhost:44367/");

        public static ConexionAPI getInstancia()
        {
            if (instancia == null)
            {
                ConexionAPI.instancia = new ConexionAPI();
            }

            return instancia;

        }

        public Jugador obtenerUsuario(string nombre, string contraseña)
        {
            Console.WriteLine("Contactando Web API");
            var request = new RestRequest("api/" + nombre);
            var response = client.Get(request).Content;
            if (response == "null")
            {
                Console.WriteLine("N");
                return null;
            }
            else
            {
                var usuario = JsonConvert.DeserializeObject<UsuarioAPI>(response);
                if (usuario.contraseña == contraseña)
                {
                    Console.WriteLine("Y");
                    Jugador miJugador = new Jugador(usuario.id, usuario.nombre, usuario.puntaje, usuario.partidasJugadas, usuario.partidasGanadas);
                    return miJugador;
                }
                else
                {
                    Console.WriteLine("N");
                    return null;
                }
            }

        }


        public void modificarUsuario(Jugador juga) 
        {
            // Modifico una persona
            Console.Out.WriteLine("Contactando Web API");
            var request = new RestRequest("api/"+juga.usuario);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new { id = juga.id, nombre = juga.usuario, puntaje = juga.puntaje, partidasJugadas = juga.partidasJugadas, partidasGanadas = juga.partidasGanadas });
            var response = client.Put(request).Content;
        }


    }
}
