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
    public partial class Login : Form
    {
        private Iloger listener;
        public interface Iloger
        {
           void Login(Usuario usuario);
        }
        public Login(object sender)
        {
            InitializeComponent();
            if (sender is Iloger)
            {
                listener = (Iloger)sender;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombreUsuario = userTextBox.Text;
            String contrasena = passTextBox.Text;
            Usuario usuario = new Usuario(nombreUsuario, contrasena);
            listener.Login(usuario);
        }
    }
}
