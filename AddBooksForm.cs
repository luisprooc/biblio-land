using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using connectionDb;
namespace Biblioteca
{
   
    public partial class AddBooksForm : Form
    {
        public AddBooksForm()
        {
            InitializeComponent();
        }
        Editoriales cat = new Editoriales();
        Autores cat1 = new Autores();
        Tipo cat2 = new Tipo();
        private void AddBooksForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = cat.CargarEditoriales();
            comboBox1.DisplayMember = "editorial";
            comboBox1.ValueMember = "id_editorial";
            comboBox2.DataSource = cat1.CargarAutores();
            comboBox2.DisplayMember = "nombre";
            comboBox2.ValueMember = "id_autor";
            comboBox3.DataSource = cat2.CargarTipo();
            comboBox3.DisplayMember = "tipo_libro";
            comboBox3.ValueMember = "id_tipo_libro";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click_1(object sender, EventArgs e)
        {

        }
       
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string title = this.textBox1.Text;
            string datePost = this.dateTimePicker1.Text;
            string id_editorial = this.comboBox1.SelectedValue.ToString();
            string id_autor = this.comboBox2.SelectedValue.ToString();
            string id_type = this.comboBox3.SelectedValue.ToString();
    
            connection database = new connection();
            bool success = database.insertBooks(title, datePost, id_editorial, id_autor, id_type);
            if (!success)
            {
                MessageBox.Show("Este libro esta registrado ", "Error al registrar sus datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { MessageBox.Show("Libro registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox1.Clear();
               
            }
        }
       
       
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
   
}
