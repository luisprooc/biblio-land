using connectionDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            passwordBox.PasswordChar = '*';
            passwordBox.MaxLength = 30;
            passwordConfirmBox.PasswordChar = '*';

            emailBox.MaxLength = 60;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string name = this.nameBox.Text;
            string email = this.emailBox.Text;
            string password = this.passwordBox.Text;
            string confirmPassword = this.passwordConfirmBox.Text;
            connection database = new connection();


            if (name == "" || email == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error al registrar tus datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!this.checkEmail(email))
            {
                MessageBox.Show("Formato de correo incorrecto.", "Error al registrar tus datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!this.checkPassword(password))
            {
                MessageBox.Show("La contraseña debe tener entre 8 y 20 caracteres, al menos un dígito, una minúscula y una mayúscula.", "Error al registrar tus datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(password != confirmPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error al registrar tus datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Boolean isSuccess = database.registerUser(email, password, name.ToUpperInvariant());

            if (isSuccess)
            {
                MessageBox.Show("Usuario registrado satisfactoriamente.");
            }

            else
            {
                MessageBox.Show("Ya existe un usuario con este correo.", "Error al registrar tus datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean checkPassword(string password)
        {
            string strRegex = @"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,20}$";


            Regex re = new Regex(strRegex);

            return re.IsMatch(password);
        }

        private Boolean checkEmail(string email)
        {
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";


            Regex re = new Regex(strRegex);

            return re.IsMatch(email);
        }
    }
}
