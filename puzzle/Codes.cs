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

        public static string ad;

        public static int puan=0;



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

        public bool  DosyayaYazma(string yol, string ad, string puan, string hamle)
        {
            bool ok = true;
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + yol);
                //Write a line of text
                sw.WriteLine(ad+"\t"+puan+"\t"+hamle);
              
                //Close the file
                sw.Close();
                
                return  ok;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                ok = false;
                return ok;
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
                
            }
        }

        public int  puanyaz()
        {
            
            return puan;
        }

        LinkedList<int> konum = new LinkedList<int>();
        public void ListeEkle()
        {

           
            konum.AddFirst(0);
            for(int i=1; i<16; i++)
            {
                konum.AddLast(i);
            }
         

        }

        public bool Kontrol(int i)
        {


            LinkedListNode<int> node = konum.Find(i);
            if(node== null) {
                return false;

            }
            else if (node.Value == i)
            {
                return true;
            }
            else return false;


          
        }
       
       

    }
}
