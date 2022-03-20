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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            passwordBox.PasswordChar = '*';
            passwordBox.MaxLength = 30;
            emailBox.MaxLength = 60;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = this.emailBox.Text;
            string password = this.passwordBox.Text;

            connection database = new connection();
            Login login = database.loginUser(email, password);

            if (login.Name == "")
            {
                MessageBox.Show("Correo o contrasena incorrectos", "Error al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("WELCOME " + login.Name);

            if(login.Permission == "DEFAULT")
            {
                new ReaderWiew().Show();
                this.Close();
            }

            else
            {
                // Abrir formulario para los admin y cerrar el del login
                new AdminMainForm().Show();
                this.Hide();
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
