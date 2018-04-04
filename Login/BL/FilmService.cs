using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class FilmService
    {
        public void addFilm(string titlu, string regia, string distributia, String premiera, int nrBilete, String dataFinala, string ora)
        {
            FilmDAO f = FilmDAO.getInstance();
            f.createFilm(titlu, regia, distributia, premiera, ora, nrBilete, dataFinala);

        }

        //gasesc nr de bilete pt a verifica daca mai exista bilete disponibile
        public int getNrBilete(string titlu)
        {
            FilmDAO f = FilmDAO.getInstance();
            return f.getNrBilete(titlu);
        }

        public List<Film> viewFilm()
        {
            FilmDAO f = FilmDAO.getInstance();
            List<Film> films = f.viewFilm();

            return films;
        }
        public void updateFilm(string titlu, String premiera, int nrBilete, String dataFinala, string ora)
        {
            FilmDAO f = FilmDAO.getInstance();
            f.updateFilm(titlu, nrBilete, premiera, ora, dataFinala);

        }
        public void updateBilete(string titlu, int nrBilete)
        {
            FilmDAO f = FilmDAO.getInstance();
            f.updateFilmBilete(titlu, nrBilete);
        }
        public void deleteFilm(string titlu)
        {
            FilmDAO f = FilmDAO.getInstance();
            f.deleteFilm(titlu);

        }
    }
}
