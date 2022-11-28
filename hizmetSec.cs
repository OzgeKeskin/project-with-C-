using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace f_Login_paneli_olusturma
{
    public partial class hizmetSec : Form
    {
        public hizmetSec()
        {
            InitializeComponent();
        }

        private void hizmetSec_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        int tutar = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            

            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add(checkBox1.Text);
                tutar = tutar + 150;
            }
            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add(checkBox2.Text);
                tutar = tutar + 100;
            }
            if (checkBox3.Checked == true)
            {
                listBox1.Items.Add(checkBox3.Text);
                tutar = tutar + 450;
            }
            if (checkBox4.Checked == true)
            {
                listBox1.Items.Add(checkBox4.Text);
                tutar = tutar + 100;
            }
            if (checkBox5.Checked == true)
            {
                listBox1.Items.Add(checkBox5.Text);
                tutar = tutar + 300;
            }


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            tutar = 0;
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Ödemeniz Gereken Tutar : "+ tutar.ToString() + "TL'dir.");


        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            secenekler don = new secenekler();
            don.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            odeme ode = new odeme();
            ode.Show();
            this.Hide();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
