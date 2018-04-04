using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class FilmDAO
    {
        private static FilmDAO filmDAL = null;
        private String connectionString;
        MySqlConnection conn = null;
        private FilmDAO()
        {
            connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "root", "user", "convert zero datetime = True");
            conn = new MySqlConnection(connectionString);
        }
  
        public static FilmDAO getInstance()
        {
            if (filmDAL == null)
            {
                filmDAL = new FilmDAO();
            }
            return filmDAL;
        }
        public void createFilm(string titlu, string regia, string distributia, String premiera, String ora, int nrBilete, String dataFinala)
        {
            String sql = "insert into film(titlu, regia, distributia, data_premiera, ora, nr_bilete, data_finala) values('"
                + titlu + "','" + regia + "','" + distributia + "','" + premiera + "','" + ora + "','" + nrBilete + "','" + dataFinala + "');";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
 
        }

        //update film nr de bilete, premiera, ora de difuzare si data finala de difuzare in functie de titlu
        public void updateFilm(string titlu, int nrBilete, String premiera, String ora, String dataFinala)
        {
            String sql = "update film set nr_bilete ='" + nrBilete + "', data_premiera ='" + premiera + 
                "',data_finala ='" + dataFinala + "',ora ='" + ora +
                "' where titlu ='" + titlu + "';";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }


        //update numar bilete
        public void updateFilmBilete(string titlu, int nrBilete)
        {
            String sql = "update film set nr_bilete ='" + nrBilete + "' where titlu ='" + titlu + "';";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }

        //stergere film dupa titlu
        public void deleteFilm(string titlu)
        {
            String sql = "delete from film where titlu ='" + titlu + "';";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }

        public int getNrBilete(string titlu)
        {
            String sql = "select nr_bilete from film where titlu = '" + titlu + "'";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            int nr_bilete = 0;
            while (reader.Read())
            {
                nr_bilete = int.Parse(reader["nr_bilete"].ToString());
            }
            conn.Close();
            return nr_bilete;
        }

        //view film
        public List<Film> viewFilm()
        {
            List<Film> films = new List<Film>();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM film", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string titlu = reader["titlu"].ToString();
                    string regia = reader["regia"].ToString();
                    string distributia = reader["distributia"].ToString();
                    string dataPremiera = reader["data_premiera"].ToString();
                    string ora = reader["ora"].ToString();
                    string dataFinala = reader["data_finala"].ToString();
                    int nrBilete = int.Parse(reader["nr_bilete"].ToString());
                    Film f = new Film(titlu, regia, distributia, dataPremiera, nrBilete, ora, dataFinala);
                    films.Add(f);
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

            return films;
        }


    }
}
