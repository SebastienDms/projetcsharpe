using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class lampe
    {
        string nom;
        string etat;
        static int nblampes;

        //création ampoule liée à la lampe
        ampoule ampoule1;
        ampoule ampoule2;
        ampoule ampoule3;

        //constructeur 1
        public lampe()
        {
            this.nom = "defaut";
            this.etat = "éteint";
            this.ampoule1 = new ampoule("ampoule 1", 40, "BON", "OFF");
            this.ampoule2 = new ampoule("ampoule 2", 40, "BON", "OFF");
            this.ampoule3 = new ampoule("ampoule 3", 40, "BON", "OFF");

            nblampes++;
            Console.WriteLine("Création d'une lampe");
            Console.WriteLine("Création de lampe (constructeur 1) : " + this.nom);
            Console.WriteLine("Nombre de lampe : " + nblampes);
        }

        //constructeur 2
        public lampe(string nom, string etat)
        {
            this.nom = nom;
            this.etat = etat;
            this.ampoule1 = new ampoule("ampoule 1", 40, "BON", "OFF");
            this.ampoule2 = new ampoule("ampoule 2", 40, "BON", "OFF");
            this.ampoule3 = new ampoule("ampoule 3", 40, "BON", "OFF");

            Console.WriteLine("Création de lampe (constructeur 1) : " + this.nom);
            Console.WriteLine("Création d'une lampe à l'état " + this.etat);
            nblampes++;
            Console.WriteLine("Nombre de lampe : " + nblampes);
        }

        //méthode allume
        public void allume()
        {
            this.ampoule1.allume();
            this.ampoule2.allume();
            this.ampoule3.allume();

            this.etat = "allumée";
            Console.WriteLine("J'allume la lampe ");
        }

        //méthode éteindre
        public void eteint()
        {
            this.ampoule1.eteint();
            this.ampoule2.eteint();
            this.ampoule3.eteint();

            this.etat = "éteint";
            Console.WriteLine("J'éteins la lampe ");
        }
    }
}
