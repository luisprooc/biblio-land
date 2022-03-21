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
        // Change data source for your local server
        string provider = @"Data Source=LAPTOP-ERTLID2K;" +
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
        public Boolean insertBooks(string title, string datePost, string id_editorial, string id_autor, string id_type)
        {
            
           
            connect.Open();
            SqlCommand cmd1 = new SqlCommand($"SELECT * FROM LIBRO WHERE titulo = '{title}'", connect);
            SqlCommand cmd = new SqlCommand("insertBooks", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@titulo", title);
            cmd.Parameters.AddWithValue("@fecha_lanzamiento", Convert.ToDateTime(datePost));
            cmd.Parameters.AddWithValue("@id_editorial", Convert.ToInt32(id_editorial));
            cmd.Parameters.AddWithValue("@id_autor", Convert.ToInt32(id_autor));
            cmd.Parameters.AddWithValue("@id_tipoLibro", Convert.ToInt32(id_type));
            try
            {
               
                SqlDataReader reader = cmd1.ExecuteReader();
                if(reader.Read())
                {
                    return false;
                }
                reader.Close();
                cmd.ExecuteNonQuery();
                return true;
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
    }
    public class classReaderWiew
    {
        public DataTable readerWiew(string slqConsultation)
        {
            connection database = new connection();
            database.connect.Open();
            DataTable table = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(slqConsultation, database.connect);
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
    public class Editoriales
    {
        connection cn =new connection();
        public DataTable CargarEditoriales()
        {

            SqlDataAdapter da = new SqlDataAdapter("SP_CARGAR_EDITORIAL", cn.connect);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
    public class Autores
    {
        connection cn1 = new connection();
        public DataTable CargarAutores()
        {

            SqlDataAdapter da1 = new SqlDataAdapter("SP_CARGAR_AUTORES", cn1.connect);
            da1.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            return dt1;
        }
    }
    public class Tipo
    {
        connection cn2 = new connection();
        public DataTable CargarTipo()
        {

            SqlDataAdapter da2 = new SqlDataAdapter("SP_CARGAR_TIPO", cn2.connect);
            da2.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            return dt2;
        }
    }
   
}

