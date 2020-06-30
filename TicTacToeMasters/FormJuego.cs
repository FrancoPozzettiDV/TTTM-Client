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
        FormMenu formMenu;
        Controller con;
        Jugador miJugador;

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

                }
            }

        }

        private void Jugar(object sender, EventArgs e)
        {
            var fichaSeleccionada = (PictureBox)sender;
            Console.WriteLine(fichaSeleccionada.Name); //Imprime el espacio ;D
            fichaSeleccionada.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("ficha_"+turno);
            fichaSeleccionada.Enabled = false;
            string[] posicion = fichaSeleccionada.Name.Split("_".ToCharArray());
            int fila = Convert.ToInt32(posicion[0]);
            int columna = Convert.ToInt32(posicion[1]);
            tabla[fila,columna] = turno;
            verificarJuego(fila,columna);
            turno = (turno == 1) ? 2 : 1;
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
                bool hayEmpate = true;
                
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
                    MessageBox.Show("Jugador 1 ha ganado!");
                    tableTablero.Enabled = false;
                    btnVolver.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Jugador 2 ha ganado!");
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
