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
    public partial class AuthorAdminForm : Form
    {
        public AuthorAdminForm()
        {
            InitializeComponent();
            deleteBtn.Enabled = false;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AuthorAdminForm_Load(object sender, EventArgs e)
        {
            this.LoadAuthors();
        }

        private void LoadAuthors()
        {
            connection database = new connection();
            dgAuthor.DataSource = database.getAuthorAsDataTable();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new UsersAdminForm().Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.LoadAuthors();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string firstName = this.firstNameBox.Text;
            string lastName = this.lastNameBox.Text;
            string sex = this.sexCb.Text;
            string country = this.contryBox.Text;
            DateTime birthDate = this.dateTimePicker.Value;

            connection database = new connection();
            bool success = database.insertAuthor(firstName, lastName, sex, country, birthDate);

            if (success)
            {
                this.firstNameBox.Clear();
                this.lastNameBox.Clear();
                this.contryBox.Clear();

                MessageBox.Show("Autor agregado satisfactoriamente.");
                this.LoadAuthors();
            }

            else
            {
                MessageBox.Show("No se ha podido agregar el autor.", "Error al agregar autor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteBtn.Enabled = true;
        }

        private void dgAuthor_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int position = dgAuthor.CurrentRow.Index;
            int id = Convert.ToInt32(dgAuthor[0, position].Value.ToString());
            string columnName = dgAuthor.Columns[e.ColumnIndex].Name;
            string value = dgAuthor[e.ColumnIndex, position].Value.ToString();

            if(columnName == "id_autor")
            {
               MessageBox.Show("No puedes actualizar este campo.", "Error al editar autor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection database = new connection();
            bool success = database.updateAuthor(id, columnName, value);


            if (success)
            {

                MessageBox.Show("Autor actualizado satisfactoriamente.");
                this.LoadAuthors();
            }

            else
            {
                MessageBox.Show("No se ha podido agregar el autor.", "Error al editar autor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int position = dgAuthor.CurrentRow.Index;
            string id = dgAuthor[0, position].Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show($"Deseas eliminar el autor con el id {id}?", "Eliminar Autor", buttons);
            if (result == DialogResult.Yes)
            {

                connection database = new connection();
                Boolean isSuccess = database.deleteAuthor(Convert.ToInt32(id));

                if (isSuccess)
                {
                    MessageBox.Show("Autor Eliminado del sistema.");
                    this.LoadAuthors();
                }

                else
                {
                    MessageBox.Show("No se ha podido eliminar.", "Error al eliminar autor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new AdminMainForm();
        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new EditorialWiew().Show();
        }
    }
}
