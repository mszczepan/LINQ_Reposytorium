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

            PokazDuzePlikiZLinq(sciezka);

            Console.WriteLine("******************");
            PokazDuzePlikiBezLinq(sciezka);

            Console.WriteLine("******************");
            PokazDuzePlikiZLinq2(sciezka);

        }

        private static void PokazDuzePlikiZLinq2(string sciezka)
        {
            var zapytanie = new DirectoryInfo(sciezka).GetFiles()
                            .OrderByDescending(p => p.Length)
                            .Take(5);

            foreach (var plik in zapytanie)
            {
                Console.WriteLine($"{plik.Name,-20}:{plik.Length,20:N0}");
            }
        }

        private static void PokazDuzePlikiZLinq(string sciezka)
        {
            var zapytanie = from plik in new DirectoryInfo(sciezka).GetFiles()
                            orderby plik.Length descending
                            select plik;

            foreach (var plik in zapytanie.Take(5))
            {

                Console.WriteLine($"{plik.Name,-20}:{plik.Length,20:N0}");
            }
        }

        private static void PokazDuzePlikiBezLinq(string sciezka)
        {
            DirectoryInfo katalog = new DirectoryInfo(sciezka);
            FileInfo[] pliki = katalog.GetFiles();

            Array.Sort(pliki,new FileInfoComparer());

  
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
