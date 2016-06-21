using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pozitif_Negatif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
int gsayi;
            int ntoplam,ptoplam,nsayac,psayac,osayi;
            int toplam;
        private void button1_Click(object sender, EventArgs e)
        {
            

            for (int i = 0; i <=100; i++)
            {


                gsayi = Convert.ToInt16(textBox1.Text);
                
                }
toplam++;
            if (toplam==100)
            {
                textBox1.Enabled = false;
                textBox1.Text = "100 Adet Sayı Girdiniz.";
            }
            if (toplam<=100)
            {
                
          if (gsayi<0)
                {

                    nsayac = nsayac+1;
                    ntoplam = gsayi + ntoplam;
                    label3.Text ="Negatiflerin Toplamı : " +ntoplam.ToString();
                    label5.Text ="Negatiflerin Sayı : "+ nsayac.ToString();
                   
 
               }
                if (gsayi>0)
                {
                    psayac = psayac+ 1;
                    ptoplam = gsayi + ptoplam;
                    label2.Text = "Pozitiflerin Toplamı : " + ptoplam.ToString();
                    label4.Text = "Pozitiflerin Sayısı : " + psayac.ToString();
                }
                if (gsayi==0)
                {
                    osayi = osayi + 1;
                    label6.Text = "0 Olanların Sayısı : " + osayi.ToString() ;
                }
            
            }
                
       }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                 this.Width = +675;
            this.Height = +496;
            }
            else
            {
                this.Width = +353;
                this.Height = +210;

            }
        }

        private void sayilarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sayilarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pozitif_NegatifDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pozitif_NegatifDataSet.Sayilar' table. You can move, or remove it, as needed.
            this.sayilarTableAdapter.Fill(this.pozitif_NegatifDataSet.Sayilar);
            sayilarBindingSource.AddNew();

        }
  
    }
}
