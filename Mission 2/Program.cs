using System;

namespace Mission_2
{
   public class Program
    {
        static void Main()
        {
            Console.WriteLine("5°) Une méthode ToString");

            Compte c, c1, c2;
            c = new Compte();
            c1 = new Compte(12345, "toto", 1000, -500);
            Console.WriteLine(c.ToString());
            Console.WriteLine(c1.ToString());

            Console.ReadKey(true);

            Console.WriteLine("\n \n6°) Ecriture des méthodes restantes\nTest 1");

            c1 = new Compte(12345, "toto", 1000, -500);
            Console.WriteLine("Créditer 2000 au compte toto.");
            c1.Crediter(2000);
            Console.WriteLine(c1.ToString());
            Console.WriteLine("Débiter 1300 au compte toto.");
            c1.Debiter(1300);
            Console.WriteLine(c1.ToString());

            Console.ReadKey(true);

            Console.WriteLine("\n \n6°) Test 2");

            c1 = new Compte(12345, "toto", 1000, -500);
            Console.WriteLine("Créditer 2000 au compte toto.");
            c1.Crediter(2000);
            Console.WriteLine(c1.ToString());
            Console.WriteLine("Débiter 3300 au compte toto.");
            c1.Debiter(3300);
            Console.WriteLine(c1.ToString());

            Console.ReadKey(true);

            Console.WriteLine("\n \n6°) Test 3");

            c1 = new Compte(12345, "toto", 1000, -500);
            Console.WriteLine("Créditer 2000 au compte toto.");
            c1.Crediter(2000);
            Console.WriteLine(c1.ToString());
            Console.WriteLine("Débiter 5300 au compte toto.");
            c1.Debiter(5300);
            Console.WriteLine(c1.ToString());

            Console.ReadKey(true);

            Console.WriteLine("\n \n6°) Méthode transferer()\nTest 1");

            c1 = new Compte(12345, "toto", 1000, -500);
            c2 = new Compte(45657, "titi", 2000, -1000);
            Console.WriteLine("Transférer 1300 du compte toto au compte titi.");
            c1.Transferer(1300, c2);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());

            Console.ReadKey(true);

            Console.WriteLine("\n \n6°) Méthode transferer()\n Test 2");


            c1 = new Compte(12345, "toto", 1000, -500);
            c2 = new Compte(45657, "titi", 2000, -1000);
            Console.WriteLine("Transférer 3300 du compte toto au compte titi.");
            c1.Transferer(3300, c2);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());


            Console.ReadKey(true);

            Console.WriteLine("\n \n6°) Méthode supérerieur()/inférieur()");

            c1 = new Compte(12345, "toto", 1000, -500);
            c2 = new Compte(45657, "titi", 2000, -1000);
            if (c1.Superieur(c2))
                Console.WriteLine("superieur");
            else
                Console.WriteLine("inférieur");


            Console.ReadKey(true);

            Console.WriteLine("\n \n7°) Nouvelles règles de gestion");
            Console.WriteLine("\n \n8°) Etude du code des classes");


            Banque b = new Banque();
            b.Ajouter(c1);
            b.Ajouter(45657, "titi", 2000, -1000);
            b.Ajouter(12654, "tintin", 5000, -500);
            Console.WriteLine(b.ToString());

            foreach (Compte cpt in b.MesComptes)
            {
                Console.WriteLine(cpt.ToString());
            }

            Console.ReadKey(true);

            Console.WriteLine("\n \n8°) Methode rendCompte()\nRécupération du compte " + b.MesComptes[0].Numero);
            
            Compte cptRecup = b.RendCompte(b.MesComptes[0].Numero);

            Console.WriteLine(cptRecup.ToString());

            Console.WriteLine("Fin");
        }
    }
}
