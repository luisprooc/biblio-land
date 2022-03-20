using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

public class Login
{
    public string Name { get; set; }
    public string Permission { get; set; }
    public Login(string name = "", string permission = "")
    {
        Name = name;
        Permission = permission;
    }

}


namespace connectionDb
{
    class connection
    {
        string provider = @"Data Source=DESKTOP-J3CIF2E\SQLEXPRESS;" +
                "Initial Catalog=biblio_land;" +
                "Integrated Security=True";

        public SqlConnection connect = new SqlConnection();

        public connection()
        {
            connect.ConnectionString = provider;
        }

   

        public Boolean registerUser(string email, string password, string fullName)
        {
            if (this.userExist(email))
            {
                return false;
            }

            connect.Open();
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_USUARIO", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@correo", email);
            cmd.Parameters.AddWithValue("@contrasena", password);
            cmd.Parameters.AddWithValue("@nombre", fullName);


            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }

        public Login loginUser(string email, string password)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("SP_LOGIN_USER", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@correo", email);
            cmd.Parameters.AddWithValue("@contrasena", password);


            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                Login loginData = new Login();
                if (reader.Read())
                {
                    loginData.Name = reader["nombre"].ToString();
                    loginData.Permission = reader["permiso"].ToString();

                }
                return loginData;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }

        }

        public Boolean userExist(string email)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM USUARIO WHERE correo = '{email}'", connect);

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                return reader.Read();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally 
            {
                connect.Close();
            }
        }

        public DataTable getUsersAsDataTable()
        {
            connect.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT nombre, correo, CONCAT('', '**************') AS contrasena FROM USUARIO WHERE permiso = 'DEFAULT'", connect.ConnectionString);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            return dt;

        }

        public Boolean deleteUser(string email)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_USUARIO", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@correo", email);


            try
            {
                cmd.ExecuteNonQuery();
               
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            finally
            {
                connect.Close();
            }

        }
    }
    public class classReaderWiew
    {
        public DataTable readerWiew()
        {
            connection database = new connection();
            database.connect.Open();
            DataTable table = new DataTable();
            string sqlAdvancedConsultation = "SELECT LIBRO.id_libro ,LIBRO.titulo, LIBRO.fecha_lanzamiento, DETALLES_LIBRO.edicion, DETALLES_LIBRO.idioma, DETALLES_LIBRO.rating, AUTOR.id_autor, AUTOR.nombre, AUTOR.apellido, EDITORIAL.editorial FROM LIBRO INNER JOIN DETALLES_LIBRO ON LIBRO.id_detalles_libro = DETALLES_LIBRO.id_detalles_libro INNER JOIN EDITORIAL ON LIBRO.id_editorial = EDITORIAL.id_editorial LEFT JOIN AUTOR ON LIBRO.id_autor = AUTOR.id_autor; ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlAdvancedConsultation, database.connect);
            sqlDataAdapter.Fill(table);
            try
            {
                return table;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }


}

