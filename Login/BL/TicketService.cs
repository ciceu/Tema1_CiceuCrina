using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class TicketService
    {
        public TicketDAO ticketDAO = TicketDAO.getInstance();
        public Boolean addTicket(string titlu, int rand, int loc, string data)
        {
            FilmService f = new FilmService();
            int id = ticketDAO.findIDFilm(titlu);
            if (validateTicket(titlu, rand, loc))
            {
                ticketDAO.insertTicket(id, rand, loc, data);
                f.updateBilete(titlu, f.getNrBilete(titlu) - 1);
                return true;
            }
            return false;
            
        }

        public Boolean validateTicket(string titlu, int rand, int loc)
        {
            List<Ticket> tickets = ticketDAO.viewTickets();
            FilmService f = new FilmService();
            int nrBilete = f.getNrBilete(titlu);
            foreach(Ticket t in tickets)
            {
                if ((rand == t.getRand()) && (loc == t.getLoc()) && (nrBilete != 0))
                    return false;
            }

            return true;
        }

        public List<Ticket> viewTicket()
        {
            TicketDAO t = TicketDAO.getInstance();
            List<Ticket> tickets = t.viewTickets();

            return tickets;
        }
    }
}
