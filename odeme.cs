using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace f_Login_paneli_olusturma
{
    public partial class odeme : Form
    {
        public odeme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adres Başarıyla Eklendi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
                MessageBox.Show("Satın Alma İşlemi Başarılı");
            
        }
    }
}
