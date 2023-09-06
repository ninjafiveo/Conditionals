using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IfElseStuff();

            Console.ReadLine();
        }

        static void IfElseStuff()
        {
            Console.WriteLine("Please enter how much gold you have: ");
            double goldBalance = double.Parse(Console.ReadLine());
            Console.WriteLine(goldBalance);

            if (goldBalance >= 400)
            {
                Console.WriteLine("Congrats. You have enough to buy a ticket for you and a friend.");
            }
            else if (goldBalance >= 200)
            {
                Console.WriteLine("Congrats. You have enough to buy at least one ticket.");
            }
            else
            {
                Console.WriteLine("Too bad. Go make more money.");
            }
        }
    }
}
