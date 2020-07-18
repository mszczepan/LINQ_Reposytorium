using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _1.Wprowadzenie
{
    class Program
    {
        static void Main(string[] args)
        {
            var sciezka = @"c:\windows";
            PokazDuzePlikiBezLinq(sciezka);        }

        private static void PokazDuzePlikiBezLinq(string sciezka)
        {
            DirectoryInfo katalog = new DirectoryInfo(sciezka);
            FileInfo[] pliki = katalog.GetFiles();

            Array.Sort(pliki,new FileInfoComparer());

            for (int i = 0; i < 4; i++)
            {

            }

            for (var i=0; i<5;i++)
            {
                Console.WriteLine($"{pliki[i].Name,-20}:{pliki[i].Length,20:N0}");
            }
        }

    }
            public class FileInfoComparer:IComparer<FileInfo>
            {
                public int Compare(FileInfo x, FileInfo y)
                {
                    return y.Length.CompareTo(x.Length);
                }

            }
       
    
}
