using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    
    class Ticket
    {
        private int rand;
        private int loc;
        private string data;
        private int id_film;

        public Ticket(int id_film,int rand, int loc, string data)
        {
            this.id_film = id_film;
            this.rand = rand;
            this.loc = loc;
            this.data = data;
        }

        public int getRand()
        {
            return this.rand;
        }

        public int getLoc()
        {
            return this.loc;
        }

        public string getData()
        {
            return this.data;
        }

        public int getId()
        {
            return this.id_film;
        }
    }
}
