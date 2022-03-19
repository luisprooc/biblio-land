using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace connectionDb
{
    class connectionDb
    {
        string provider = "Data Source=DESKTOP-DENRRTR;" +
                "Initial Catalog=biblio_land;" +
                "Integrated Security=True";

        public SqlConnection connect = new SqlConnection();

        public connectionDb()
        {
            connect.ConnectionString = provider;
        }


      /*  public DataTable read()
        {

            SqlDataAdapter da = new SqlDataAdapter("SP_MOSTRARTABLAESTUDIANTES", connect.ConnectionString);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public void insert(string enrollment, string firstName, string lastName, int career, string celphone)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_ESTUDIANTE", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Matricula", enrollment);
            cmd.Parameters.AddWithValue("@Nombre", firstName);
            cmd.Parameters.AddWithValue("@Apellido", lastName);
            cmd.Parameters.AddWithValue("@Cod_carrera", career);
            cmd.Parameters.AddWithValue("@Celular", celphone);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }*/
    }
}
