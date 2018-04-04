using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Film
    {
        private string titlu;
        private string regia;
        private string distributia;
        private int nr_bilete;
        private String premiera;
        private String ora;
        private String dataFinala;

        public Film(string titlu, string regia, string distributia, String premiera, int nr_bilete, String ora, String dataFinala)
        {
            this.titlu = titlu;
            this.regia = regia;
            this.distributia = distributia;
            this.premiera = premiera;
            this.nr_bilete = nr_bilete;
            this.ora = ora;
            this.dataFinala = dataFinala;
        }
        
        public string getTitlu()
        {
            return this.titlu;
        }

        public string getRegia()
        {
            return this.regia;
        }

        public string getDistributia()
        {
            return this.distributia;
        }

        public string getPremiera()
        {
            return this.premiera;
        }

        public string getOra()
        {
            return this.ora;
        }

        public int getBilete()
        {
            return this.nr_bilete;
        }

        public string getDatafinala()
        {
            return this.dataFinala;
        }
    }
}
