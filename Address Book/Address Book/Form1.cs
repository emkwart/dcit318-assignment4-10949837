using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Address_Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = textEmail.Text;
            string email = textEmail.Text;
            string number = phoneNumber.Text;
            MessageBox.Show($"name: {textEmail}\nemail: {textEmail}\nnumber: {phoneNumber}", "Login Information");
        }
    }
}
