using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace f_Login_paneli_olusturma
{
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Palyaço Gösterisi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Balon Süsleme");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Şişme Oyun Parkuru ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Yüz Boyama");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kostümlü Karakterler");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Uçan Balon");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Doğum Günü Masa Konsepti");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kareoke Hizmeti");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Karnaval Yiyecekler");
        }

        private void adminPanel_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 ar = new Form1();
            ar.Show();
            this.Hide();
        }
    }
}
