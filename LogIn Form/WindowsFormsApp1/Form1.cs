using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textUserName(object sender, EventArgs e)
        {

        }

        private void textPassword(object sender, EventArgs e)
        {

        }

        private void logInBtn(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            MessageBox.Show($"Username: {username}\nPassword: {password}", "Login Information");

        }

        private void label1(object sender, EventArgs e)
        {

        }

        private void label2(object sender, EventArgs e)
        {

        }
    }
}
