using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Insertion_Sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;
        int[] Sayilar = new int[5];

        private void button2_Click(object sender, EventArgs e)
        {
            if(sayac != 5)
            {
                Sayilar[sayac] = Convert.ToInt32(textBox1.Text);
                listBox1.Items.Add(textBox1.Text);  
                MessageBox.Show(Convert.ToString(Sayilar[sayac]));
                sayac++;
                textBox1.Clear();
            }
            else  if (textBox1.Text == "")
            {
                MessageBox.Show("Sayı girmelisiniz");
            }
            else if(sayac == 5)
            {
                MessageBox.Show("5 adet sayı girdiniz sıralama yapabilirsiniz");
            }
          
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Siralama.siralama(Sayilar);
            Siralama.Yazdirma(Sayilar, listBox2);
        }
    }
}
