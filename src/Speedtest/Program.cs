using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Speedtest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string file = @"C:\Program Files (x86)\GnuWin32\bin\wget.exe";
            //string cParams = @"wget http://speedtest.wdc01.softlayer.com/downloads/test10.zip ";

            //var proc = Process.Start(file, cParams);

            var proc = Process.Start("CMD.exe", @"cd\ ");
            Process.Start("CMD.exe", @"cd\Program Files (x86)\GnuWin32\bin\");


            //We pauzeren het programma (debugging)
            Console.ReadLine();

            Console.ReadLine();


            Console.ReadLine();


            Console.ReadLine();
            Console.WriteLine("Laatste readline");
            Console.ReadLine();
            


        }
    }
}
