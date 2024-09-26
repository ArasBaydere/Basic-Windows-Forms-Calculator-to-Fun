using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayitoplama
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        char islemoperator;
        double sayi1, sayi2;
        double sonuc;
        StreamWriter txt = new StreamWriter("E:\\arasbaydere\\sayitoplama\\gecici_logdefteri.txt");
        StreamWriter txt2 = new StreamWriter("E:\\arasbaydere\\sayitoplama\\geciciNET_logdefteri.txt");

        private void button1_Click(object sender, EventArgs e)
        {
            faktButton.Visible = true;
            buttonKareKok.Visible = true;
            buttonKare.Visible = true;
            textBox1.Visible = true;
            labelsayi2.Visible = true;
            buttonCarpma.Visible = true;
            buttonBolme.Visible = true;
            buttonCikarma.Visible = true;
            buttonToplama.Visible = true;
            labelSonuc.Text = "Sonuç :";
            textBox3.Text = "";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            islemoperator = '-';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            islemoperator = '*';

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelsayi1_Click(object sender, EventArgs e)
        {

        }

        private void labelsayi2_Click(object sender, EventArgs e)
        {

        }

        private void labelSonuc_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            islemoperator = '+';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            islemoperator = '/';

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (e.Start.Date == new DateTime(2024, 9, 22) && e.End.Date== new DateTime(2024,9,24))
            {
                buttonKareKok.Visible = true;
                buttonKare.Visible = true;
                textBox1.Visible = true;
                labelsayi2.Visible = true;
                buttonCarpma.Visible = true;
                buttonBolme.Visible = true;
                buttonCikarma.Visible = true;
                buttonToplama.Visible = true;
                groupBox2.Visible = false;
                groupBox1.Visible = true;
                fenbosText.Visible = true;
                matbosText.Visible = true;
                netBosBasic.Visible = true;
                faktButton.Visible = true;
            }
            else if (e.Start.Date == new DateTime(2024, 9, 8) && e.End.Date == new DateTime(2024, 9, 10))
            {
                buttonKareKok.Visible = true;
                buttonKare.Visible = true;
                textBox1.Visible = true;
                labelsayi2.Visible = true;
                buttonCarpma.Visible = true;
                buttonBolme.Visible = true;
                buttonCikarma.Visible = true;
                buttonToplama.Visible = true;
                groupBox1.Visible=false;
                groupBox2.Visible = true;
                fenbosText.Visible = true;
                matbosText.Visible = true;
                netBosBasic.Visible = true;

            }
            else
            {
                labelSonuc.Text = "Sonuç :";
                textBox3.Text = "";
                textBox1.Text = "";
                groupBox1.Visible = false; // İstersen diğer tarihleri gizlemek için
                matdvalue.Text = "";
                matyvalue.Text = "";
                fendvalue.Text = "";
                fenyvalue.Text = "";
                matbosText.Text = "";
                fenbosText.Text = "";
                labelnet.Text = "Net Sayısı: ";
                puanText.Text = "Puan:";
                bosvalue.Text = "Toplam Boş Sayısı :";
                groupBox2.Visible = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txt.Close();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void fenNetValue_Click(object sender, EventArgs e)
        {

        }

        private void nethesaplabutton_Click(object sender, EventArgs e)
        {
            
            double matd, maty, fend, feny;
            double toplam_net;
            matd = Convert.ToDouble(matdvalue.Text);
            maty = Convert.ToDouble(matyvalue.Text);
            fend = Convert.ToDouble(fendvalue.Text);
            feny = Convert.ToDouble(fenyvalue.Text);
            double x = feny + maty;
            double y = x / 3;
            toplam_net = (matd+fend) - y;
            double o = 40 - (matd + maty);
            labelnet.Text = "Net Sayısı :"+toplam_net.ToString();
            string z = Convert.ToString(80 - ((matd + fend) + x));
            bosvalue.Text = ("Toplam Boş Sayısı :"+z);
            txt2.WriteLine("Net Sayısı :"+toplam_net);
            double p = 40 - (fend + feny);
            fenbosText.Text = Convert.ToString(p);
            matbosText.Text = Convert.ToString(o);
            double u = (6.25*toplam_net);
            puanText.Text = Convert.ToString("Puan :"+u);
            txt2.WriteLine("Net Sayısı :" + p);
            txt2.WriteLine("Net Sayısı :" + u);
        }

        private void netclbutton_Click(object sender, EventArgs e)
        {
            fenbosText.Visible = true;
            matbosText.Visible = true;
            netBosBasic.Visible = true;
            matbosText.Text = "";
            fenbosText.Text = "";
            matdvalue.Text = "";
            matyvalue.Text = "";
            fendvalue.Text = "";
            fenyvalue.Text = "";
            labelnet.Text = "Net Sayısı: ";
            bosvalue.Text = "Toplam Boş Sayısı :";
            puanText.Text = "Puan:";
        }

        private void matyvalue_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelnet_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txt2.Close();
            this.Close();
        }

        private void bosvalue_Click(object sender, EventArgs e)
        {

        }

        private void buttonKare_Click(object sender, EventArgs e)
        {
            islemoperator = 'k';
            textBox1.Visible = false;
            labelsayi2.Visible = false;
            buttonCarpma.Visible = false;
            buttonBolme.Visible = false;
            buttonCikarma.Visible = false;
            buttonToplama.Visible = false;
            buttonKareKok.Visible = false;
            faktButton.Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            islemoperator = 'j';
            textBox1.Visible = false;
            labelsayi2.Visible = false;
            buttonCarpma.Visible = false;
            buttonBolme.Visible = false;
            buttonCikarma.Visible = false;
            buttonToplama.Visible = false;
            faktButton.Visible = false;
            textBox1.Visible = false;
            labelsayi2.Visible = false;
            buttonCarpma.Visible = false;
            buttonBolme.Visible = false;
            buttonCikarma.Visible = false;
            buttonToplama.Visible = false;
            faktButton.Visible = false;
        }

        private void matbosText_TextChanged(object sender, EventArgs e)
        {

        }

        private void fenbosText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void faktButton_Click(object sender, EventArgs e)
        {
            islemoperator = 'f';
            textBox1.Visible = false;
            labelsayi2.Visible = false;
            buttonCarpma.Visible = false;
            buttonBolme.Visible = false;
            buttonCikarma.Visible = false;
            buttonToplama.Visible = false;
            buttonKareKok.Visible = false;
            buttonKare.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (islemoperator)
            {
                case 'f':
                    sayi1 = Convert.ToDouble(textBox3.Text);
                    double fakt = 1; 
                    for (int i = 2; i <= sayi1; i++)
                    {
                        fakt *= i; // 
                    }
                    labelSonuc.Text = Convert.ToString(fakt);
                    break;

                case 'j':
                    sayi1 = Convert.ToDouble(textBox3.Text);
                    sonuc = sayi1 * sayi1;
                    labelSonuc.Text = "Sonuç : " + Convert.ToString(sonuc);
                    txt.WriteLine(labelSonuc.Text);
                    break;

                case 'k':
                    sayi1 = Convert.ToDouble(textBox3.Text);
                    sonuc = Math.Sqrt(sayi1);
                    labelSonuc.Text = "Sonuç : " + Convert.ToString(sonuc);
                    txt.WriteLine(labelSonuc.Text);
                    break;

                case '+':
                    sayi1 = Convert.ToDouble(textBox3.Text);
                    sayi2 = Convert.ToDouble(textBox1.Text);
                    sonuc = sayi1 + sayi2;
                    labelSonuc.Text = "Sonuç : " + Convert.ToString(sonuc);
                    txt.WriteLine(labelSonuc.Text);
                    break;

                case '/':

                    sayi1 = Convert.ToDouble(textBox3.Text);
                    sayi2 = Convert.ToDouble(textBox1.Text);
                    sonuc = sayi1 / sayi2;
                    labelSonuc.Text = "Sonuç : " + Convert.ToString(sonuc);
                    txt.WriteLine(labelSonuc.Text);
                    

                    break;
                case '*':

                    sayi1 = Convert.ToDouble(textBox3.Text);
                    sayi2 = Convert.ToDouble(textBox1.Text);
                    sonuc = sayi1 * sayi2;
                    labelSonuc.Text = "Sonuç : " + Convert.ToString(sonuc);
                    txt.WriteLine(labelSonuc.Text);
                    break;
                case '-':

                    sayi1 = Convert.ToDouble(textBox3.Text);
                    sayi2 = Convert.ToDouble(textBox1.Text);
                    sonuc = sayi1 - sayi2;
                    labelSonuc.Text = "Sonuç : " + Convert.ToString(sonuc);
                    txt.WriteLine(labelSonuc.Text);
                    break;
                default:
                    break;


            }
        }
    }
}