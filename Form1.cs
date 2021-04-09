using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        int toplamkasa=0;
        private void button1_Click(object sender, EventArgs e)
        {   int toplamfiyat=0;
           
            int bilet, su, cay, misir;
         
            bilet = Convert.ToInt16(txtbilet.Text);
            su = Convert.ToInt16(txtsu.Text);
            cay = Convert.ToInt16(txtcay.Text);
            misir = Convert.ToInt16(txtmisir.Text);
            toplamfiyat=bilet*14 + misir*8 +su*2 +  cay*3;
            toplamkasa = toplamkasa + toplamfiyat;
            lbltutar.Text = toplamfiyat.ToString(); // toplam fiyatı labela aktarıyorum
            lblkasa.Text = toplamkasa.ToString();

             
          
   
       
        }
    }
}
