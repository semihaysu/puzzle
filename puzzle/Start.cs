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
            Select select = new Select();
            select.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            Codes codes = new Codes();
            
            richTextBox1.Text = codes.dosyaEnYuksekSkorOkuma("enyuksekskor.txt");
        }


    }
}

