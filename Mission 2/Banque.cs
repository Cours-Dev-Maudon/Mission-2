using System;
using System.Collections.Generic;
using System.Text;

namespace Mission_2
{
    public class Banque
    {
        private List<Compte> mesComptes;
        public Banque()
        {
            mesComptes = new List<Compte>();
        }

        public void Ajouter(Compte newCPT)
        {
            this.mesComptes.Add(newCPT);
        }

        public List<Compte> MesComptes
        {
            get { return this.mesComptes; }
        }

        public void Ajouter(int numero, string nom, int solde, int decouvert)
        {
            Compte newCPT = new Compte(numero, nom, solde, decouvert);

            this.mesComptes.Add(newCPT);
        }


        public Compte RendCompte(int numeroCPT)
        {
            return this.mesComptes.Find(cpt => cpt.Numero.ToString().Contains(numeroCPT.ToString()));
        }

    }
}
