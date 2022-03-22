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
    public partial class AdminMainForm : Form
    {
        classReaderWiew data = new classReaderWiew();
        string sqlAdvancedConsultation = "SELECT LIBRO.id_libro, LIBRO.titulo, LIBRO.fecha_lanzamiento, DETALLES_LIBRO.edicion, DETALLES_LIBRO.idioma, DETALLES_LIBRO.rating, AUTOR.id_autor, AUTOR.nombre, AUTOR.apellido, EDITORIAL.editorial FROM LIBRO INNER JOIN DETALLES_LIBRO ON LIBRO.id_detalles_libro = DETALLES_LIBRO.id_detalles_libro INNER JOIN EDITORIAL ON LIBRO.id_editorial = EDITORIAL.id_editorial LEFT JOIN AUTOR ON LIBRO.id_autor = AUTOR.id_autor";
        public AdminMainForm()
        {
            InitializeComponent();
            this.deleteBtn.Enabled = false;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new UsersAdminForm().Show();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddBooksForm().Show();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            dgBooks.DataSource = data.readerWiew(sqlAdvancedConsultation);
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new AuthorAdminForm().Show();

        }
        
        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new EditorialWiew().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgBooks.DataSource = data.readerWiew(sqlAdvancedConsultation);
        }

        private void dgBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.deleteBtn.Enabled = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int position = dgBooks.CurrentRow.Index;
            string id = dgBooks[0, position].Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show($"Deseas eliminar el libro con el id {id}?", "Eliminar Libro", buttons);
            if (result == DialogResult.Yes)
            {

                connection database = new connection();
                Boolean isSuccess = database.deleteBook(Convert.ToInt32(id));

                if (isSuccess)
                {
                    MessageBox.Show("Libro Eliminado del sistema.");
                    dgBooks.DataSource = data.readerWiew(sqlAdvancedConsultation);
                }

                else
                {
                    MessageBox.Show("No se ha podido eliminar.", "Error al eliminar libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgBooks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int position = dgBooks.CurrentRow.Index;
            int id = Convert.ToInt32(dgBooks[0, position].Value.ToString());
            string columnName = dgBooks.Columns[e.ColumnIndex].Name;
            string value = dgBooks[e.ColumnIndex, position].Value.ToString();

            connection database = new connection();
            bool success = database.updateBook(id, columnName, value);

            if (success)
            {

                MessageBox.Show("Libro actualizado satisfactoriamente.");
                dgBooks.DataSource = data.readerWiew(sqlAdvancedConsultation);
            }

            else
            {
                MessageBox.Show("No se ha podido actualizar el libro.", "Error al actualizar el libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search(string value)
        {
            string sqlSearch = $"SELECT LIBRO.id_libro, LIBRO.titulo, LIBRO.fecha_lanzamiento, DETALLES_LIBRO.edicion, DETALLES_LIBRO.idioma, DETALLES_LIBRO.rating, AUTOR.id_autor, AUTOR.nombre, AUTOR.apellido, EDITORIAL.editorial FROM LIBRO INNER JOIN DETALLES_LIBRO ON LIBRO.id_detalles_libro = DETALLES_LIBRO.id_detalles_libro INNER JOIN EDITORIAL ON LIBRO.id_editorial = EDITORIAL.id_editorial LEFT JOIN AUTOR ON LIBRO.id_autor = AUTOR.id_autor WHERE titulo LIKE '%{value}%' OR nombre LIKE '%{value}%';";

            dgBooks.DataSource = data.readerWiew(sqlSearch);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Search(this.txtSearch.Text);
        }

        private void orderCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string order = this.orderCb.SelectedItem.ToString();
            dgBooks.DataSource = data.readerWiew(sqlAdvancedConsultation + $" ORDER BY LIBRO.titulo {order}");
        }
    }
}
