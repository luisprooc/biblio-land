using connectionDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class UsersAdminForm : Form
    {
        public UsersAdminForm()
        {
            InitializeComponent();
            deleteUserBtn.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            deleteUserBtn.Enabled = true;
        }

        private void UsersAdminForm_Load(object sender, EventArgs e)
        {
            this.LoadUsers();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.LoadUsers();
        }

        private void LoadUsers()
        {
            connection database = new connection();
            dgUsers.DataSource = database.getUsersAsDataTable();
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Deseas eliminar este usuario?", "Bannear usuario", buttons);
            if (result == DialogResult.Yes)
            {
                int position = dgUsers.CurrentRow.Index;
                string email = dgUsers[1, position].Value.ToString();

                connection database = new connection();
                Boolean isSuccess = database.deleteUser(email);

                if (isSuccess)
                {
                    MessageBox.Show("Usuario banneado del sistema.");
                    this.LoadUsers();
                }

                else
                {
                    MessageBox.Show("No se ha podido bannear el usuario.", "Error al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addBooks = new AddBooksForm();
            addBooks.Show();
        }
    }
}
