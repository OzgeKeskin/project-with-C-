using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace f_Login_paneli_olusturma
{
    public partial class secenekler : Form
    {
        public secenekler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hizmetSec ac = new hizmetSec();
            ac.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hismetSecYet ap = new hismetSecYet();
            ap.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 donn = new Form1();
            donn.Show();
            this.Hide();
        }
    }
}
