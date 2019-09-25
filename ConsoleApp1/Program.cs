using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            lampe Living = new lampe("Living", "OFF");
            lampe Toilettes = new lampe("Toilettes", "OFF");

            interrupteur interLiving = new interrupteur(Living);

            interLiving.On();
            //interLiving.off();


            //Living.allume();
            //Living.eteint();



            Console.ReadLine();
        }
    }
}
