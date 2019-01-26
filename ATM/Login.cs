using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            String card = String.Format(txtCard.Text);
            if (card == "1111222233334444")
            {
                f.Show();
            }
            else
            {
                MessageBox.Show("Invalid Card Number");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
