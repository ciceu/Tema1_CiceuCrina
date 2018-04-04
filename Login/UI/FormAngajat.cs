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
    public partial class FormAngajat : Form
    {
        public FormAngajat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titlu = titluT.Text;
            int rand = int.Parse(randT.Text);
            int loc = int.Parse(locT.Text);
            string data = dataT.Text;
            TicketService t = new TicketService();
            if (t.addTicket(titlu, rand, loc, data))
                MessageBox.Show("Bilet adaugat cu succes!");
            else
                MessageBox.Show("Nu se poate adauga biletul!");

        }

        private void tabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewTickets_Click(object sender, EventArgs e)
        {
            TicketService t = new TicketService();
            List<Ticket> tickets = t.viewTicket();
            DataTable dt = new DataTable();

            dt.Columns.Add("idFilm", typeof(string));
            dt.Columns.Add("Rand", typeof(string));
            dt.Columns.Add("Loc", typeof(string));
            dt.Columns.Add("Data", typeof(string));

            foreach (Ticket t1 in tickets)
            {
                dt.Rows.Add(new object[] { t1.getId(), t1.getRand(), t1.getLoc(), t1.getLoc() });
            }

            tabel.DataSource = dt;
        }
    }
}
