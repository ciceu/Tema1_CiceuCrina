using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class TicketDAO
    {
        private static TicketDAO ticketDAL = null;
        private String connectionString;
        MySqlConnection conn = null;
        private TicketDAO()
        {
            connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "root", "user");
            conn = new MySqlConnection(connectionString);
        }


        public static TicketDAO getInstance()
        {
            if (ticketDAL == null)
            {
                ticketDAL = new TicketDAO();
            }
            return ticketDAL;
        }

        public void insertTicket(int id_film,  int rand, int loc, string data)
        {
            String sql = "insert into bilet(id_film, rand, loc, dataFilm) values('"
                + id_film + "','" + rand + "','" + loc + "','" + data + "');";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            conn.Close();

        }

        public List<Ticket> viewTickets()
        {

            List<Ticket> tickets = new List<Ticket>();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM bilet", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id_film = int.Parse(reader["id_film"].ToString());
                    int rand = int.Parse(reader["rand"].ToString());
                    int loc = int.Parse(reader["loc"].ToString());
                    string data = reader["dataFilm"].ToString();
                    Ticket t = new Ticket(id_film, rand, loc, data);
                    tickets.Add(t);
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

            return tickets;
        }
        
        public int findIDFilm(string titlu)
        {
            
            String sql = "select id_film from film where titlu = '" + titlu + "'";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            int id = 0;
            while (reader.Read())
            {
                id = int.Parse(reader["id_film"].ToString());
            }
            conn.Close();
            return id;
        }
    }
}
