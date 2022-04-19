using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63DersIndexers
{
    class Program
    {
        class Futbolcu
        {
            string[] futbolcular = new string[10]; // Indexers sayesinde futbolcularin isimlerini burada tutuyoruz.
            public string this[int index]
            {
                get { return futbolcular[index]; }
                set { futbolcular[index] = value; }
            }
        }
        static void Main(string[] args)
        {
            Futbolcu IlkOnluGrup = new Futbolcu();
            IlkOnluGrup[0] = "Murat";
            IlkOnluGrup[1] = "Hasan";
            IlkOnluGrup[2] = "Emre";
            IlkOnluGrup[3] = "Yunus";
            IlkOnluGrup[4] = "Kaan";

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(IlkOnluGrup[i]);
            }
        }
    }
}
