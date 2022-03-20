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
        public ReaderWiew()
        {
            InitializeComponent();
        }

        private void ReaderWiew1_Load(object sender, EventArgs e)
        {
            classReaderWiew data = new classReaderWiew();
  

            dgvBooks.DataSource = data;


        }
    }
}
