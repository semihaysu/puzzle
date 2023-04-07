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
            ListeEkle();
            Karıstır();

            //button1.BackgroundImage = imgarray[0];
            //button2.BackgroundImage = imgarray[1];
            //button3.BackgroundImage = imgarray[2];
            //button4.BackgroundImage = imgarray[3];
            //button5.BackgroundImage = imgarray[4];
            //button6.BackgroundImage = imgarray[5];
            //button7.BackgroundImage = imgarray[6];
            //button8.BackgroundImage = imgarray[7];
            //button9.BackgroundImage = imgarray[8];
            //button10.BackgroundImage = imgarray[9];
            //button11.BackgroundImage = imgarray[10];
            //button12.BackgroundImage = imgarray[11];
            //button13.BackgroundImage = imgarray[12];
            //button14.BackgroundImage = imgarray[13];
            //button15.BackgroundImage = imgarray[14];
            //button16.BackgroundImage = imgarray[15];

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

           
            Karıstır();
            Codes.puan=Codes.puan - 5;
            labelPuan.Text = codes.puanyaz().ToString();
        }

        int[] dizi = new int[16];

        public void Karıstır()
        {

           


            Random sayi = new Random();
            int tut = 0;
            
            for (int i = 0; i < 16;)
            {
                tut = sayi.Next(16);

                bool degerVar = false;
                for (int j = 0; j < i; j++)
                {
                    if (tut == dizi[j])
                    {
                        degerVar = true;
                        break;
                    }
                }

                if (!degerVar)
                {
                    dizi[i++] = tut;
                }
            }

            button1.BackgroundImage = imgarray[dizi[0]];
            button2.BackgroundImage = imgarray[dizi[1]];
            button3.BackgroundImage = imgarray[dizi[2]];
            button4.BackgroundImage = imgarray[dizi[3]];
            button5.BackgroundImage = imgarray[dizi[4]];
            button6.BackgroundImage = imgarray[dizi[5]];
            button7.BackgroundImage = imgarray[dizi[6]];
            button8.BackgroundImage = imgarray[dizi[7]];
            button9.BackgroundImage = imgarray[dizi[8]];
            button10.BackgroundImage = imgarray[dizi[9]];
            button11.BackgroundImage = imgarray[dizi[10]];
            button12.BackgroundImage = imgarray[dizi[11]];
            button13.BackgroundImage = imgarray[dizi[12]];
            button14.BackgroundImage = imgarray[dizi[13]];
            button15.BackgroundImage = imgarray[dizi[14]];
            button16.BackgroundImage = imgarray[dizi[15]];



        }
        int tut=0;
        Image[] imgarraytut = new Image[1];
        Image[] imgarraytut1 = new Image[1];
        Button btn = new Button();
        Button btn1 = new Button();
        private void button12_Click(object sender, EventArgs e)
        {
           

            // Button btn1 = (Button)sender;
            // Button btn = (Button)sender;
            Codes.hamle = Codes.hamle + 1;

            if (tut == 0)
            {      btn1=(Button)sender;
                //   Button  btn1 = (Button)sender;
                imgarraytut1[0] = btn1.BackgroundImage;
                
            }
            
            if (tut == 1)
            {   btn=(Button)sender;
                //  Button  btn = (Button)sender;
                imgarraytut[0] = btn.BackgroundImage;
                
            }
            tut++;
            if (tut == 2)
            {

                btn1.BackgroundImage = imgarraytut[0];
                btn.BackgroundImage = imgarraytut1[0];
               
           //    imgarray[dizi[]] = imgarraytut[0];
                //imgarray[dizi[6]]= imgarraytut1[0];
                tut = 0;
                imgarraytut[0] = null;
                imgarraytut1[0] = null;

                
            }
            else
            {

            }

            /*for (int f = 0; f < 16; f++)
            {
                if (btn1.BackgroundImage == imgarray[dizi[f]])
                {
                    labelAd.Text = dizi[f].ToString();
                    Kontrol(imgarray[dizi[f]],f);
                    
                }
           }*/
            

            if (Codes.hamle % 2 == 0)
            {
                labelHamle.Text = codes.hamleyaz().ToString();
            }

            
           // dizi[5] = 8;
            //for (int d = 0; d < 16; d++)
            //{
            //    if(codes.Kontrol(d) == dizi[d])
            //    {
            //        labelAd.Text = codes.Kontrol(d).ToString();
            //    }
               
             
            //}
        }
        LinkedList<Image> konum = new LinkedList<Image>();
        public void ListeEkle()
        {
            

            konum.AddFirst(imgarray[dizi[0]]);
            for (int i = 1; i < 16; i++)
            {
                konum.AddLast(imgarray[dizi[i]]);
            }


        }
        public bool  Kontrol(Image i, int f)
        {

            //string g=f.ToString();
            
            //LinkedListNode<Image> node = konum.Find(i);
            //if (g== node.ToString())
            //{
            //    btn.Enabled= false;
            //}
            
            if(konum.ElementAt(f)== i)
            {
                btn.Enabled= false;
            }
            
            return false;


        }

        private void bıtırButton_Click(object sender, EventArgs e)
        {
            codes.DosyayaYazma("enyuksekskor.txt", labelAd.Text, labelPuan.Text, labelHamle.Text);
           
        }
    }

}
