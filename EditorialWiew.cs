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
            btnUpdate.Enabled = false;
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new AdminMainForm().Show();
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
                dgvEditorial.DataSource = data.editorialTable();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "Error al intentar agregar una Editorial", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dgvEditorial.DataSource = data.editorialTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int position = dgvEditorial.CurrentRow.Index;  
            string editorial = txtUpdateEditorial.Text;
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

        private void dgvEditorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnUpdate.Enabled = true;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new UsersAdminForm().Show();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new AuthorAdminForm().Show();
        }
    }
}
