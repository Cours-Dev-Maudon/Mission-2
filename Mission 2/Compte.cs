using System;
using System.Collections.Generic;
using System.Text;

namespace Mission_2
{
    class Compte
    {
        private int numero;
        public string nom;
        public double solde;
        public double decouvert;

        public Compte()
        {
            this.numero = 0;
            this.nom = "";
            this.solde = 0;
            this.decouvert = 0;
        }
        public Compte(int numero, string nom, int solde, int decouvert)
        {
            this.numero = numero;
            this.nom = nom;
            this.solde = solde;
            this.decouvert = decouvert;
        }

        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }
        public double Solde
        {
            get { return this.solde; }
            set { this.solde = value; }
        }

        public double Decouvert
        {
            get { return this.decouvert; }
            set { this.decouvert = value; }
        }
        public bool Crediter(int somme)
        {
            this.solde += somme;
            return true;
        }

        public bool Debiter(int somme)
        {
            bool debited = false;

            if (this.solde - somme > this.decouvert)
            {
                this.solde -= somme;
                debited = true;
            }
            return debited;
        }

        public bool Transferer(int somme, Compte cpt)
        {

            bool transfered = false;

            if (this.Debiter(somme))
            {
                cpt.Crediter(somme);
                transfered = true;
            }

            return transfered;
        }

        public bool Superieur(Compte cpt)
        {

            if (this.solde > cpt.solde)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return "numero: " + this.numero
                    + " nom: " + this.nom
                    + " solde: " + this.solde
                    + " découvert autorisé: " + this.decouvert;
        } 

    }
}
