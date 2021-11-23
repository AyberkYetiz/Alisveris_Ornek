using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alisveris_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //0-20 arasindaki kitap alimlarina %20 indirim 21-40 arasinda kitap alana %40 +41 kitap alimlarinda ise %50 indirim.
        //Klavyeden girilen kitap adedi ve kitap fiyatına göre ödenmesi gereken tutarı ve indirimi hesaplayan programi kodlayiniz.

        private void button1_Click(object sender, EventArgs e)
        {
            int alinan, fiyat, indirim, total;
            alinan = Convert.ToInt16(textBox1.Text);
            fiyat = Convert.ToInt16(textBox2.Text);

            if(alinan>0)
            {
                if(alinan<=20)
                {
                    
                    indirim = 20;
                    total = alinan * fiyat - (alinan * fiyat) * indirim / 100;
                    label4.Text = indirim.ToString();
                    label6.Text = total.ToString();



                }
                else if (alinan>20 && alinan<=40)
                {
                    
                    indirim = 40;
                    total= alinan * fiyat - (alinan * fiyat) * indirim / 100;
                    label4.Text = indirim.ToString();
                    label6.Text = total.ToString();
                }
                else
                {
                    
                    indirim = 50;
                    total= alinan * fiyat - (alinan * fiyat) * indirim / 100;
                    label4.Text = indirim.ToString();
                    label6.Text = total.ToString();
                }
            }
            else
            {
                MessageBox.Show("Dassak mi geciyorsunuz");
            }

        }
    }
}
