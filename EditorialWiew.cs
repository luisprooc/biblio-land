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
    public partial class EditorialWiew : Form
    {
        classEditorial data = new classEditorial();

        public EditorialWiew()
        {
            InitializeComponent();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addBooks = new AddBooksForm();
            addBooks.Show();
        }

        private void EditorialWiew_Load(object sender, EventArgs e)
        {
            dgvEditorial.DataSource = data.editorialTable();


        }

        private void btnAddEditorial_Click(object sender, EventArgs e)
        {

            string editorial = txtAddEditorial.Text;

            if ( editorial != "")
            {
               data.insertEditorial(editorial);
                MessageBox.Show("Su editorial se ha regitrado con el nombre de: " + editorial, "Operacion exitosa ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Introduzca un nombre", "Error al intentar agregar una Editorial", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dgvEditorial.DataSource = data.editorialTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string editorial = txtUpdateEditorial.Text;
            int position = dgvEditorial.CurrentRow.Index;  
            string id_editorial = dgvEditorial[0, position].Value.ToString();

            if(id_editorial != "" & editorial !="")
            {
                Boolean isSuccess = data.updateEditorial(id_editorial, editorial);
                if (isSuccess)
                {
                    MessageBox.Show("Su Actualizancion ha sido exitosa");


                }
            }
            else
            {
                MessageBox.Show("Asegurate de haber agregado el nuevo nombre y selcionado fila.", "Error al intentar actulizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



        }
    }
}
