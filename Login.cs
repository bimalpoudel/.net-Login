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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            attemptLogin();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                attemptLogin();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.escape();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                attemptLogin();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.escape();
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                attemptLogin();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.escape();
            }
        }

        private void attemptLogin()
        {
            MessageBox.Show("Login attempt!");
        }

        private void escape()
        {
            this.Dispose();
        }
    }
}
