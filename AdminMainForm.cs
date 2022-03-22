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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UsersAdminForm().Show();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addBooks = new AddBooksForm();
            addBooks.Show();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form editorialWiew = new EditorialWiew();
            editorialWiew.Show();
        }
    }
}
