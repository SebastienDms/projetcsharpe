using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ampoule
    {
        private string nom;
        private int watt;
        private string etat;
        private string OnOff;
        
        //constructeur
        public ampoule(string nom, int watt, string etat, string onoff)
        {
            this.nom = nom;
            this.watt = watt;
            this.etat = etat;
            this.OnOff = onoff;
            Console.WriteLine(" Dans ampoule, création d'une ampoule : " + this.nom);
        }

        //méthode allume
        public void allume()
        {
            this.OnOff = "ON";
            Console.WriteLine("Ampoule " + this.nom + " est : " + this.OnOff);
        }

        //méthode eteint
        public void eteint()
        {
            this.OnOff = "OFF";
            Console.WriteLine("Ampoule " + this.nom + " est : " + this.OnOff);
        }
    }
}
