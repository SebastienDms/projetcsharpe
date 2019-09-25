using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class interrupteur
    {
        lampe MaLampe;
        string OnOff;

        //constructeur
        public interrupteur (lampe MaLampe)
        {
            this.MaLampe = MaLampe;
            OnOff = "OFF";
            Console.WriteLine("Crétaion interrupteur: etat: " + this.OnOff);
        }

        //Méthode On
        public void On()
        {
            OnOff = "ON";
            Console.WriteLine("Dans interrupteur, je mets ON ");
            this.MaLampe.allume();
        }

        //Méthode Off
        public void off()
        {
            OnOff = "OFF";
            Console.WriteLine("Dans interrupteur, je mets OFF ");
            this.MaLampe.allume();
        }

    }
}
