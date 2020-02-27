using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezba2
{

    
    class Program
    {

        static void stampajMeni()
        {
            Console.WriteLine("1.Unesi");
            Console.WriteLine("2.Izmena");
            Console.WriteLine("3.stampaj");
            Console.WriteLine("4.brisanje");
            Console.WriteLine("3.izadji");
        }
        static public (string,string,decimal) unos()
        {
            Console.WriteLine();
            Console.WriteLine("Unesi Sifru , Naziv i Cenu");
            string[] unos = Console.ReadLine().Split(' ');

            return (unos[0], unos[1], decimal.Parse(unos[2]));
        }
        static void brisanje()
        {
            stampaj();
            Console.WriteLine("Unesi sifru artikla koji zelis da brises");
            string x = Console.ReadLine();
            foreach(Artikal p in Artikal.Artikli)
            {
                if (p.sifra == x)
                {
                    Artikal.Artikli.Remove(p);
                }
            }

        }

        static void ispis()
        {
            foreach(Artikal n in Artikal.Artikli)
            {
                Console.WriteLine(n);
            }
        }
        static void izmena()
        {
            Console.WriteLine("Unesite sifru artikla koji zelite da izmena");
            Console.WriteLine();

            string sifraUnos = Console.ReadLine();
            foreach(Artikal x in Artikal.Artikli)
            {   
                if (x.sifra == sifraUnos)
                {
                    Console.WriteLine("Unesi novi naziv , sifru i cenu");
                    var n  = unos();
                    x.naziv = n.Item1;
                    x.sifra = n.Item2;
                    x.cena = n.Item3;
                }

            }

        }
        static void stampaj()
        {
            foreach(Artikal w in Artikal.Artikli)
            {
                Console.WriteLine(w);
            }
        }
        static void Main(string[] args)
        {
            do
            {
                stampajMeni();
                char brojx = Console.ReadKey().KeyChar;
                switch (brojx)
                {
                    case '1':
                         var test= unos();
                        Artikal x = new Artikal(test.Item1, test.Item2,test.Item3);
                        break;
                    case '2':
                        izmena();
                        break;
                    case '3':
                        stampaj();
                        break;
                    case '4':
                        brisanje();
                        break;
                    default:
                        Environment.Exit(2);
                        break;


                }
            } while (true);

                
        }
    }
}
//marza. 