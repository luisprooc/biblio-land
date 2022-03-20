using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using connectionDb;

namespace Biblioteca
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Registrate");
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = this.emailBox.Text;
            string password = this.passwordBox.Text;

            connection database = new connection();
            Login login = database.loginUser(email, password);
            Console.WriteLine(login);

            if (login.Name == "")
            {
                MessageBox.Show("Correo o contrasena incorrectos", "Error al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("WELCOME " + login.Name);

        }
    }
}
