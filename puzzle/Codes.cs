using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle
{
    internal class Codes
    {



        public string dosyaEnYuksekSkorOkuma(string yol)
        {
            try
            { 
                string enyuksekskor;
                //var dosyaYolu = Application.StartupPath + @"enyuksekskor.txt";
                StreamReader oku = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + yol);
               enyuksekskor = oku.ReadToEnd();
                oku.Close();
                return enyuksekskor;
            }
            catch (Exception)
            {
                MessageBox.Show("En Yüksek Skor Bilgisi Okunmadı.");
                return "HATA";
            }
           

        }





    }
}
