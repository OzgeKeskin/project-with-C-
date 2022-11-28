using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f_Login_paneli_olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || maskedTextBox1.Text=="")
            {
                MessageBox.Show("Kullanıcı adı ve Şifre Boş bırakılamaz.");
            }
            else if(maskedTextBox1.Text=="55030106178" && textBox1.Text=="123456")
            {
                
                adminPanel fr = new adminPanel();
                fr.Show();
                this.Hide();
            }
            else
            {
                secenekler fr = new secenekler();
                fr.Show();
                this.Hide();
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("E-posta adresinize gelen linke tıklayarak yeni bir şifre oluşturabilirsiniz.");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            secenekler ab = new secenekler();
            ab.Show();
            this.Hide();
        }
    }
}
