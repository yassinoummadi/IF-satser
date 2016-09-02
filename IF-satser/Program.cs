using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_satser
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Övning 1
            Console.Write("Skriv in mönster djup (i mm):");
            string inmatat = Console.ReadLine();
            double x = double.Parse(inmatat);

            if (x > 1.6)
            {
                Console.WriteLine("Olagligt däck!");
            }
            else if (x<1.6)
            {
                Console.WriteLine("Lagligt däck!");
            }

            */
            /* Övning 2
            Console.Write("Skriv din ålder: ");
            string inmatat = Console.ReadLine();
            double x = double.Parse(inmatat);

            if (x <= 12)
            {
                Console.WriteLine("Färg: Vit ");
            }

            else if (x <= 18 && x >= 13)
            {
                Console.WriteLine("Färg: Grön ");
            }

            else if (x <= 25 && x >= 19)
            {
                Console.WriteLine("Färg: Röd ");
            }

            else if (x <= 99 && x >= 26)
            {
                Console.WriteLine("Färg: Blå ");
            }

            else
            {
                Console.WriteLine("Ogiltig ålder ");
            }
            */
            /* Övning 3
            Console.Write("Mata in tal 1: ");
            string inmatat1 = Console.ReadLine();
            Console.Write("Mata in tal 2: ");
            string inmatat2 = Console.ReadLine();

            decimal a = decimal.Parse(inmatat1);
            decimal b = decimal.Parse(inmatat2);

            if (a>b)
            {
                Console.Write("Tal 1 var störst: " + a);
            }

            else if (b>a)
            {
                Console.Write("Tal 2 var störst: " + b);
            }

            else if (a==b)
            {
                Console.Write("Talen var lika!: " + a);
            }
            */

            /* Övning 4 
            Console.Write("Mata in ett tal: ");
            string inmatat1 = Console.ReadLine();
            
            int a = int.Parse(inmatat1);
            

            if (a%7 == 0)
            {
                Console.Write("Talet är delbart med 7 ! Svar:" + (a/7));
            }

            else
            {
                Console.Write("Talet går inte att dela med 7... Resten: " + (a%7));
            }

           

            Console.ReadLine();

            */

            
        }
    }
}
