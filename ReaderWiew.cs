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
using System.Data.SqlClient;



namespace Biblioteca
{
    public partial class ReaderWiew : Form
    {
        classReaderWiew data = new classReaderWiew();
        string sqlAdvancedConsultation = "SELECT LIBRO.titulo, LIBRO.fecha_lanzamiento, DETALLES_LIBRO.edicion, DETALLES_LIBRO.idioma, DETALLES_LIBRO.rating, AUTOR.id_autor, AUTOR.nombre, AUTOR.apellido, EDITORIAL.editorial FROM LIBRO INNER JOIN DETALLES_LIBRO ON LIBRO.id_detalles_libro = DETALLES_LIBRO.id_detalles_libro INNER JOIN EDITORIAL ON LIBRO.id_editorial = EDITORIAL.id_editorial LEFT JOIN AUTOR ON LIBRO.id_autor = AUTOR.id_autor;";

        public ReaderWiew()
        {
            InitializeComponent();

        }

        private void ReaderWiew1_Load(object sender, EventArgs e)
        {


            dgvBooks.DataSource = data.readerWiew(sqlAdvancedConsultation); 


        }
        private void Search(string value)
        {
            string sqlSearch = $"SELECT LIBRO.titulo, LIBRO.fecha_lanzamiento, DETALLES_LIBRO.edicion, DETALLES_LIBRO.idioma, DETALLES_LIBRO.rating, AUTOR.id_autor, AUTOR.nombre, AUTOR.apellido, EDITORIAL.editorial FROM LIBRO INNER JOIN DETALLES_LIBRO ON LIBRO.id_detalles_libro = DETALLES_LIBRO.id_detalles_libro INNER JOIN EDITORIAL ON LIBRO.id_editorial = EDITORIAL.id_editorial LEFT JOIN AUTOR ON LIBRO.id_autor = AUTOR.id_autor WHERE titulo LIKE '%{value}%' OR nombre LIKE '%{value}%';";

            dgvBooks.DataSource = data.readerWiew(sqlSearch);

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search(txtSearch.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvBooks.DataSource = data.readerWiew(sqlAdvancedConsultation);

        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
