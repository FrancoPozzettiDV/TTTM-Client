using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeMasters
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        
        public bool verificarDatos()
        {
            var user = txtUsuario.Text;
            var pass = txtPassword.Text;
            var error = labelError;

            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(pass) || (String.IsNullOrEmpty(user) && String.IsNullOrEmpty(pass)))
            {
                error.Visible = true;
                return false;
            }
            else if (user == "Ingresar usuario" || pass == "Ingresar contraseña" || (user == "Ingresar usuario" && pass == "Ingresar contraseña"))
            {
                error.Visible = true;
                return false;
            }
            else
            {
                error.Visible = false;
                return true;
            }
        }

        public string getUsuario()
        {
            string user = txtUsuario.Text;
            return user;
        }
        public string getContraseña()
        {
            string pass = txtPassword.Text;
            return pass;
        }
        
        public void btnInicio_Click(object sender, EventArgs e)
        {
            Controller con = new Controller(this);
            con.loguarse();
            
        }

        
        
        private void txtPassword_Click(object sender, EventArgs e)
        {
            var pass = txtPassword;
            
            if(pass.Text == "Ingresar contraseña")
            {
                pass.Text = "";
            }
            pass.PasswordChar = '*';
        }
        
        
        private void txtUsuario_Click(object sender, EventArgs e)
        {
            var user = txtUsuario;
            
            if (user.Text == "Ingresar usuario")
            {
                user.Text = "";
            }
        }
        

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void mostrarError(string mensaje)
        {
            MessageBox.Show(mensaje,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
