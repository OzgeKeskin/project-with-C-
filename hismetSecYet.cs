using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace f_Login_paneli_olusturma
{
    public partial class hismetSecYet : Form
    {
        public hismetSecYet()
        {
            InitializeComponent();
        }

        int hesapla =0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add(checkBox1.Text);
                hesapla = hesapla + 200;
            }
            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add(checkBox2.Text);
                hesapla = hesapla + 500;
            }
            if (checkBox3.Checked == true)
            {
                listBox1.Items.Add(checkBox3.Text);
                hesapla = hesapla + 150;
            }
            if (checkBox4.Checked == true)
            {
                listBox1.Items.Add(checkBox4.Text);
                hesapla = hesapla + 300;
            }
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            hesapla = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Ödemeniz Gereken Tutar : " + hesapla.ToString() + "TL'dir.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            secenekler donus = new secenekler();
            donus.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            odeme odek = new odeme();
            odek.Show();
            this.Hide();
        }
    }
}
