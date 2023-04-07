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

namespace puzzle
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(oyuncuAdText.Text == "")
            {
                MessageBox.Show("Lütfen İsim Giriniz.");
            }
            else
            { Select select = new Select();
                 select.Show();
                Start Start = new Start();
                Start.Hide();
            }
        }
        private void Start_Load(object sender, EventArgs e)
        {
            Codes codes = new Codes();
            skorTabloText.ReadOnly = true;
            skorTabloText.Text = codes.dosyaEnYuksekSkorOkuma("enyuksekskor.txt");
        }
        private void skorTabloText_TextChanged(object sender, EventArgs e)
        {

        }
        private void oyuncuAdText_TextChanged(object sender, EventArgs e)
        {
            Codes.ad = oyuncuAdText.Text;
        }
        private void oyuncuAdLabel_Click(object sender, EventArgs e)
        {

        }
        private void skorTabloLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

