using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Funkcje
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<Pracownik> programisci = new Pracownik[]
            {
                new Pracownik{Id=1,Imie="Marcin",Nazwisko="Kowlski" },
                new Pracownik{Id=2,Imie="Tomek",Nazwisko="Sobota" },
                new Pracownik{Id=3,Imie="Krzysztof",Nazwisko="Bosak" },
                new Pracownik{Id=4,Imie="Marcin",Nazwisko="Maniura" },

            };

            IEnumerable<Pracownik> kierowcy = new List<Pracownik>
            {
                new Pracownik{Id=5,Imie="Andrzej",Nazwisko="Krzywy" },
                new Pracownik{Id=6,Imie="Franciszek",Nazwisko="Bielas" },
                new Pracownik{Id=7,Imie="Anna",Nazwisko="Szara" },
            };

           // foreach (var osoba in programisci)
            // {

            //    Console.WriteLine(osoba.Imie + " " + osoba.Nazwisko);

            // }

            IEnumerator<Pracownik> enumerator = kierowcy.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Imie);
            }

        }
    }
}
