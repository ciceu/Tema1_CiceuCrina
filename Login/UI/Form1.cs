using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            UserService user = new UserService();
            String role = user.Login(passText.Text,nameText.Text);
            if (role.Equals("administrator"))
            {
                FormAdmin f = new FormAdmin();
                f.Show();
            }
            else
            {
                FormAngajat f = new FormAngajat();
                f.Show();
            }
        }

        private void passText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
