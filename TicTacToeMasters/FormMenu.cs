using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeMasters.Models;

namespace TicTacToeMasters
{
    public partial class FormMenu : Form
    {
        FormLogin formLogin;
        Controller con;
        Jugador miJugador;

        public FormMenu(FormLogin formLogin, Jugador miJugador, Controller con)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            this.miJugador = miJugador;
            this.con = con;
            actualizarDatos(miJugador);
        }

        public void actualizarDatos(Jugador miJugador)
        {
            this.labelUsuarioAPI.Text = miJugador.usuario;
            this.labelPuntosAPI.Text = miJugador.puntaje.ToString();
            this.labelVictoriasAPI.Text = miJugador.calcularPorcentaje().ToString() + "%";
        }


        private void buttonSalir_Click(object sender, EventArgs e)
        {
            formLogin.Show();
            this.Hide();
            this.Close();
        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            botones();
            con.jugar();
            
        }

        public void botones()
        {
            this.buttonJugar.Enabled = !this.buttonJugar.Enabled;
            this.buttonSalir.Enabled = !this.buttonSalir.Enabled;
        }
    }
}
