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
    public partial class FormEnCola : Form
    {
        FormMenu formMenu;
        Controller con;


        public FormEnCola(Controller con,FormMenu fm)
        {
            InitializeComponent();
            this.con = con;
            this.formMenu = fm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.salirCola();
            formMenu.botones();
            this.Close();
        }

        public void jugadorObtenido()
        {
            this.labelNombre.Text = con.obtenerRival().usuario;
            this.labelPuntos.Text = con.obtenerRival().puntaje.ToString();
            this.labelVictorias.Text = con.obtenerRival().calcularPorcentaje().ToString()+"%";
            //Cambia los textos por el jugador obtenido
        }
    }
}
