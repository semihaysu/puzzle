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
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

       
        private void Select_Load(object sender, EventArgs e)
        {
            

            pictureBox1.Image = Image.FromFile(@"..\..\img\1.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile(@"..\..\img\2.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.Image = Image.FromFile(@"..\..\img\3.jpg");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox4.Image = Image.FromFile(@"..\..\img\4.jpg");
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox5.Image = Image.FromFile(@"..\..\img\5.jpg");
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox6.Image = Image.FromFile(@"..\..\img\6.jpg");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox7.Image = Image.FromFile(@"..\..\img\7.jpg");
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox8.Image = Image.FromFile(@"..\..\img\8.jpg");
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;

         

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            
            PictureBox picture = ( PictureBox) sender;
            main.image = picture.Image;
            
            //Codes.ad= textBoxAd.Text;
            main.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox9.ImageLocation = textBox1.Text;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDosya_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            dosya.Title = "www.yazilimkodlama.com";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            pictureBox9.ImageLocation = DosyaYolu;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        
    }
}
