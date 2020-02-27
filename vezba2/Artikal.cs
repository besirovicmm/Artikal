using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezba2
{
    class Artikal
    {
        public static List<Artikal> Artikli = new List<Artikal>();

        public string naziv;
        public string sifra;
        public decimal cena;



        public void promeniStanje(int a)
        {

        }
        public Artikal(string a, string b,  decimal c)
        {
            naziv = b;
            sifra = a;
            cena = c;
            Artikli.Add(this);

        }

        public override string ToString()
        {
            Console.WriteLine();
            return $"{sifra}....{naziv}....{cena}";
        
        }

    }
}
