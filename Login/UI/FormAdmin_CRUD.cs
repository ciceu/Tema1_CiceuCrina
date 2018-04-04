using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FormAdmin_CRUD : Form
    {
        public FormAdmin_CRUD()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            string titlu = titluT.Text;
            string regia = regieT.Text;
            string distributia = distributieT.Text;
            string premiera = premieraT.Text;
            int nrBilete = int.Parse(BileteT.Text);
            string dataFinala = finalT.Text;
            String ora = difuzareT.Text;

            FilmService film = new FilmService();
            film.addFilm(titlu, regia, distributia, premiera, nrBilete, dataFinala, ora);

        }

        private void read_Click(object sender, EventArgs e)
        {
            
            FilmService f = new FilmService();
            List<Film> films = f.viewFilm();
            DataTable dt = new DataTable();

            dt.Columns.Add("Titlu", typeof(string));
            dt.Columns.Add("Regia", typeof(string));
            dt.Columns.Add("Distributia", typeof(string));
            dt.Columns.Add("Premiera", typeof(string));
            dt.Columns.Add("nrBilete", typeof(string));
            dt.Columns.Add("dataFinala", typeof(string));
            dt.Columns.Add("ora", typeof(string));

            foreach (Film f1 in films)
            {
                dt.Rows.Add(new object[]{f1.getTitlu(), f1.getRegia(), f1.getDistributia(), f1.getPremiera(), f1.getBilete(), f1.getDatafinala(), f1.getOra() });
            }

            tabel.DataSource = dt;

        }



        private void update_Click(object sender, EventArgs e)
        {
            string titlu = titluT.Text;
            string premiera = premieraT.Text;
            int nrBilete = int.Parse(BileteT.Text);
            string dataFinala = finalT.Text;
            String ora = difuzareT.Text;

            FilmService film = new FilmService();
            film.updateFilm(titlu, premiera, nrBilete, dataFinala, ora);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string titlu = titluT.Text;

            FilmService film = new FilmService();
            film.deleteFilm(titlu);
        }

        private void viewTickets_Click(object sender, EventArgs e)
        {

        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAdmin_CRUD_Load(object sender, EventArgs e)
        {

        }

        private void tabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
