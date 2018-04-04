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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void nume_Click(object sender, EventArgs e)
        {

        }

        //add user button
        private void button1_Click(object sender, EventArgs e)
        {
            FormAdmin_addUser form = new FormAdmin_addUser();
            form.Show();
        }

        //CRUD operations button
        private void button1_Click_1(object sender, EventArgs e)
        {
            FormAdmin_CRUD form = new FormAdmin_CRUD();
            form.Show();
        }
    }
}
