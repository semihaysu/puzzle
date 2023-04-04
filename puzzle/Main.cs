using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace puzzle
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Image[] imgarray = new Image[16];
        public Image image { get; set; }
        Codes codes = new Codes();
        private void Main_Load(object sender, EventArgs e)
        {
            codes.ListeEkle();

            labelGöster.Text = "3/3";
            labelPuan.Text = codes.puanyaz().ToString();

            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            labelAd.Text=Codes.ad.ToString();
            pictureBox1.Hide();

         

            
            var img = image;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var index = j * 4 + i;
                    imgarray[index] = new Bitmap(image.Width/4, image.Height/4);
                    var graphics = Graphics.FromImage(imgarray[index]);
                    graphics.DrawImage(img, new Rectangle(0, 0, image.Width/4, image.Height/4), new Rectangle(i * image.Width/ 4, j * image.Height / 4, image.Width/4, image.Height / 4), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }


            
            button1.BackgroundImage = imgarray[0];
            button2.BackgroundImage = imgarray[1];
            button3.BackgroundImage = imgarray[2];
            button4.BackgroundImage = imgarray[3];
            button5.BackgroundImage = imgarray[4];
            button6.BackgroundImage = imgarray[5];
            button7.BackgroundImage = imgarray[6];
            button8.BackgroundImage = imgarray[7];
            button9.BackgroundImage = imgarray[8];
            button10.BackgroundImage = imgarray[9];
            button11.BackgroundImage = imgarray[10];
            button12.BackgroundImage = imgarray[11];
            button13.BackgroundImage = imgarray[12];
            button14.BackgroundImage = imgarray[13];
            button15.BackgroundImage = imgarray[14];
            button16.BackgroundImage = imgarray[15];

        }

        private void buttonGöster_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Show();
        }

        private void buttonGöster_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        private void buttonGöster_Click(object sender, EventArgs e)
        {

                sayac++;
            //if (sayac == 0)
            //{
            //    labelGöster.Text = "3/3";
            //    Codes.puan = Codes.puan - 10;
            //}
             if (sayac == 1)
            {
                Codes.puan = Codes.puan - 10;
                labelGöster.Text = "2/3";
                
            }
            else if (sayac == 2)
            {
                Codes.puan = Codes.puan - 10;
                labelGöster.Text = "1/3";
               
            }
            else if (sayac == 3)
            {
                Codes.puan = Codes.puan - 10;
                labelGöster.Text = "0/3";
                buttonGöster.Visible= false;
            }
            else
            {

            }


            labelPuan.Text = codes.puanyaz().ToString();
        }

        private void buttonKarıstır_Click(object sender, EventArgs e)
        {


            if (codes.Kontrol(6) == true)
            {
                labelHamle.Text = "true";
            }
            //else if (codes.Kontrol(17) == false)
            //{
            //    labelHamle.Text = "false";
            //}
            else { labelHamle.Text = "false"; }
            Karıstır();
        }



        public void Karıstır()
        {



            //button1.BackgroundImage = imgarray[SayiDizisi[0]];
            //button2.BackgroundImage = imgarray[SayiDizisi[1]];
            //button3.BackgroundImage = imgarray[SayiDizisi[2]];
            //button4.BackgroundImage = imgarray[SayiDizisi[3]];
            //button5.BackgroundImage = imgarray[SayiDizisi[5]];
            //button6.BackgroundImage = imgarray[SayiDizisi[6]];
            //button7.BackgroundImage = imgarray[SayiDizisi[7]];
            //button8.BackgroundImage = imgarray[SayiDizisi[8]];
            //button9.BackgroundImage = imgarray[SayiDizisi[9]];
            //button10.BackgroundImage = imgarray[SayiDizisi[10]];
            //button11.BackgroundImage = imgarray[SayiDizisi[11]];
            //button12.BackgroundImage = imgarray[SayiDizisi[12]];
            //button13.BackgroundImage = imgarray[SayiDizisi[13]];
            //button14.BackgroundImage = imgarray[SayiDizisi[14]];
            //button15.BackgroundImage = imgarray[SayiDizisi[15]];
            //button16.BackgroundImage = imgarray[SayiDizisi[16]];
          

            Random r = new Random();
            int num = r.Next(0, 16);
            int[] sıra = new int[16];

            for (int loop = 0; loop < 16; loop++)
            {
                int n = r.Next(0, 15);
                num = n >= num ? n + 1 : n;
               
                sıra[loop] = num;
                
            }
            button1.BackgroundImage = imgarray[sıra[0]];
            button2.BackgroundImage = imgarray[sıra[1]];
            button3.BackgroundImage = imgarray[sıra[2]];
            button4.BackgroundImage = imgarray[sıra[3]];
            button5.BackgroundImage = imgarray[sıra[4]];
            button6.BackgroundImage = imgarray[sıra[5]];
            button7.BackgroundImage = imgarray[sıra[6]];
            button8.BackgroundImage = imgarray[sıra[7]];
            button9.BackgroundImage = imgarray[sıra[8]];
            button10.BackgroundImage = imgarray[sıra[9]];
            button11.BackgroundImage = imgarray[sıra[10]];
            button12.BackgroundImage = imgarray[sıra[11]];
            button13.BackgroundImage = imgarray[sıra[12]];
            button14.BackgroundImage = imgarray[sıra[13]];
            button15.BackgroundImage = imgarray[sıra[14]];
            button16.BackgroundImage = imgarray[sıra[15]];



        }
    }

}
