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
    public partial class FormJuego : Form
    {
        int turno;
        int[,] tabla;
        bool hayGanador;
        bool hayEmpate;
        FormMenu formMenu;
        Controller con;
        Jugador miJugador;
        Jugador jugadorRival;
        List<PictureBox> fichas = new List<PictureBox>();

        public FormJuego(FormMenu formMenu, Jugador miJugador, Controller con)
        {
            InitializeComponent();
            this.formMenu = formMenu;
            this.miJugador = miJugador;
            this.con = con;
            iniciarJuego();
        }

        public void obtenerJugadores(Jugador miJugador, Jugador jugadorRival)
        {
            this.jugadorRival = jugadorRival;

            this.labelJugador1.Text = miJugador.usuario;
            this.labelPuntos1.Text = miJugador.puntaje.ToString();
            this.labelVictorias1.Text = miJugador.calcularPorcentaje().ToString() + "%";

            this.labelJugador2.Text = jugadorRival.usuario;
            this.labelPuntos2.Text = jugadorRival.puntaje.ToString();
            this.labelVictorias2.Text = jugadorRival.calcularPorcentaje().ToString() + "%";
        }

        private void iniciarJuego()
        {
            turno = 1;
            tabla = new int[3, 3];
            hayGanador = false;

            tableTablero.Controls.Clear();

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var ficha = new PictureBox();
                    ficha.Name = string.Format("{0}", i + "_" + j);
                    ficha.Dock = DockStyle.Fill;
                    ficha.Cursor = Cursors.Hand;
                    ficha.SizeMode = PictureBoxSizeMode.StretchImage;
                    ficha.Click += Jugar;
                    tableTablero.Controls.Add(ficha, j, i);
                    tabla[i, j] = 0;
                    fichas.Add(ficha);
                }
            }
            string turn = con.mensajesPartida("start");
            if (turn.Equals("Esperar"))
            {
                tableTablero.Enabled = false;
                turno = 2;
                string fichita = con.mensajesPartida("wait");
                juegaRival(fichita);
            }
            else
            {
                tableTablero.Enabled = true;
            }
        }

        private PictureBox recorrerLista(string fichita)
        {
            foreach (var fi in fichas)
            {
                if (fi.Name.Equals(fichita))
                {
                    return fi;
                }
            }
            return null;
        }

        private void Jugar(object sender, EventArgs e)
        {
            var fichaSeleccionada = (PictureBox)sender;
            fichaSeleccionada.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("ficha_"+turno);
            fichaSeleccionada.Enabled = false;
            string[] posicion = fichaSeleccionada.Name.Split("_".ToCharArray());
            int fila = Convert.ToInt32(posicion[0]);
            int columna = Convert.ToInt32(posicion[1]);
            tabla[fila,columna] = turno;
            verificarJuego(fila,columna);
            turno = (turno == 1) ? 2 : 1;
            if(!hayGanador || !hayEmpate)
            {
                string fichaRival = con.mensajesPartida(fichaSeleccionada.Name);
                tableTablero.Enabled = false;
                juegaRival(fichaRival);
            }
        }

        
        private void juegaRival(string fichita)
        {
            PictureBox fichaSeleccionada = recorrerLista(fichita);
            fichaSeleccionada.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("ficha_" + turno);
            fichaSeleccionada.Enabled = false;
            string[] posicion = fichaSeleccionada.Name.Split("_".ToCharArray());
            int fila = Convert.ToInt32(posicion[0]);
            int columna = Convert.ToInt32(posicion[1]);
            tabla[fila, columna] = turno;
            verificarJuego(fila, columna);
            turno = (turno == 1) ? 2 : 1;
            tableTablero.Enabled = true;
        }
        

        private void verificarJuego(int fila, int columna)
        {
            int filas = 0;
            int columnas = 0;
            int diagonal1 = 0;
            int diagonal2 = 0;
            int tateti = 3;

            for (var i = 0; i<tateti; i++)
            {
                for (var j = 0; j<tateti; j++)
                {
                    if(i == fila)
                    {
                        if (tabla[i,j] == turno)
                        {
                            filas++;
                        }
                    }
                    if(j == columna)
                    {
                        if (tabla[i,j] == turno)
                        {
                            columnas++;
                        }
                    }
                    if (i == j)
                    {
                        if(tabla[i,j] == turno)
                        {
                            diagonal1++;
                        }
                    }
                    if ((i+j) == (tateti - 1))
                    {
                        if (tabla[i,j] == turno)
                        {
                            diagonal2++;
                        }
                    }

                }
            }

            if ((filas == tateti) || (columnas == tateti) || (diagonal1 == tateti) || (diagonal2 == tateti))
            {
                hayGanador = true;
            }
            else
            {
                hayEmpate = true;
                
                for (var i = 0; i<tateti; i++)
                {
                    for (var j = 0; j<tateti; j++)
                    {
                        if(tabla[i,j] == 0)
                        {
                            hayEmpate = false;
                        }
                    }
                }
                if (hayEmpate)
                {
                    MessageBox.Show("Empate...");
                    btnVolver.Enabled = true;
                }
            }

            if (hayGanador)
            {
                if(turno == 1)
                {
                    MessageBox.Show(miJugador.usuario + " ha ganado!");
                    tableTablero.Enabled = false;
                    btnVolver.Enabled = true;
                }
                else
                {
                    MessageBox.Show(jugadorRival.usuario + " ha ganado!");
                    tableTablero.Enabled = false;
                    btnVolver.Enabled = true;
                }

            }
            
           
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            this.Hide();
            this.Close();
        }

      
    }
}
