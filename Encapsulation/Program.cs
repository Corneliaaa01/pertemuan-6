using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new Mobil("Toyota", "Hitam", 2022);


            mobil1.Merk = "Toyota";
            mobil1.Warna = "Hitam";
            mobil1.Tahunkeluaran = 2022;
            mobil1.DisplayInfo();
 
        }
    }
}

            

