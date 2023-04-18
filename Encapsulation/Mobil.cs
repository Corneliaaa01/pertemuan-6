using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Mobil
    {
        private string merk;
        private string warna;
        private int tahunkeluaran;
        

        public Mobil(string merk, string warna, int tahunkeluaran)
        {
            this.merk = merk;
            this.warna = warna;
            this.tahunkeluaran = tahunkeluaran;  
        }
        public string Merk
        {
            get { return merk; }
            set { merk = value; }
        }

        public string Warna
        {
            get { return warna; }
            set { warna = value; }
        }

        public int Tahunkeluaran
        {
            get { return tahunkeluaran; }
            set { tahunkeluaran = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Merk: " + merk);
            Console.WriteLine("Warna: " + warna);
            Console.WriteLine("Tahunkeluaran: " + tahunkeluaran);
        }
    }
}
