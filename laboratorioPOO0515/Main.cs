using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorioPOO0515
{
    public partial class Main : Form, Login.Iloger
    {
        BaseDeDatos bdd;
        public Main()
        {
            InitializeComponent();
            bdd = new BaseDeDatos();
        }

        public void Login(Usuario usuario)
        {
            userSession.Text = usuario.NombreUsuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginWindow = new Login(this);
            loginWindow.Show();
        }
    }
}
