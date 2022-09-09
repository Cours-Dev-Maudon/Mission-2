using System;

namespace Mission_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            Compte c, c1;
            c = new Compte();
            c1 = new Compte(12345, "toto", 1000, -500);
            Console.WriteLine(c.ToString());
            Console.WriteLine(c1.ToString());

            Console.WriteLine("\n \n Test 2");

            Banque b = new Banque();
            b.Ajouter(c1);
            b.Ajouter(45657, "titi", 2000, -1000);
            b.Ajouter(12654, "tintin", 5000, -500);
            Console.WriteLine(b.ToString());

            foreach (Compte cpt in b.MesComptes)
            {
                Console.WriteLine(cpt.ToString());
            }

            Console.WriteLine("Fin");
        }
    }
}
