using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Login
{
    class UsersDAO
    {

        private static UsersDAO usersDAL = null;
        private String connectionString;
        MySqlConnection conn = null;

        private UsersDAO()
        {
            connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "root", "user");
            conn = new MySqlConnection(connectionString);
        }

        
        public static UsersDAO getInstance()
        {
            if (usersDAL == null)
            {
                usersDAL = new UsersDAO();
            }
            return usersDAL;
        }
        

        public Users getUser(String username, String password)
        {
            Users u = null;

            String sql = "SELECT * FROM users WHERE username='" + username + "' AND password='" + password + "'";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    u = new Users(reader["username"].ToString(), reader["password"].ToString(), reader["name"].ToString(), reader["prenume"].ToString(), reader["role"].ToString());

                }
                else
                {
                    u = null;
                }
                conn.Close();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
                return null;
            }
            return u;
        }

        public void createUser(String username, String password, String name, String prenume, String role)
        {
            String sql = "insert into users(username, password, name, prenume, role) values('"
                + username + "','" + password + "','" + name + "','" + prenume + "','" + role + "');";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            conn.Close();

        }
        public List<Users> ListUsers()
        {
            List<Users> users = new List<Users>();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string username = reader["username"].ToString();
                    string password = reader["password"].ToString();
                    string name = reader["name"].ToString();
                    string prenume = reader["prenume"].ToString();
                    string role = reader["role"].ToString();
                    Users u = new Users(username, password, name, prenume, role);
                    users.Add(u);
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                conn.Close();
            }

            return users;
        }


    }
}
