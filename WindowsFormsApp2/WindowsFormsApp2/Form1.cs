using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int  kullaniciadi, sifre;
        int hata_var = 0;
        int giris_hakki = 3;
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "admin")
            {
                hata_var = 1;
            }
            if (textBox2.Text != "123")
            {
                hata_var = 2;
                giris_hakki--;
            }

            if (textBox2.Text != "123" && textBox1.Text != "admin")
            {
                hata_var = 3;
                giris_hakki--;
            }
            else if (hata_var == 1)
            {
                MessageBox.Show("kullanıcı ve şifre hatalı + kalan giriş hakkı :" + giris_hakki);
            }
            else if (hata_var==2)
            {
                MessageBox.Show("şifre hatalı kalan giriş hakkı :" + giris_hakki);
            }
            else
            {
                MessageBox.Show("giriş başarılı");
            }

            if (giris_hakki == 0)
            {
                button1.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            } 



          //  if (textBox1.Text == "admin" )
         //   {
          //      if (textBox2.Text=="sifre")
           //     {
             //       MessageBox.Show("giriş başaralı");
            //    }
             //   else
              //  {
              //      MessageBox.Show("şifre yanlış");
           //     } 
           // }
           // else
           // {
            //    MessageBox.Show("kullanıcı bulunamadı");
           // }
            
             
            
            
        }
    }
}
