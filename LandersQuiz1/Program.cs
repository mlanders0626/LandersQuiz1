using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandersQuiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pizzaSize = new string [4] {"S", "M", "L", "X" };
            double[] Price = new double[4] { 6.99, 8.99, 11.99, 14.99 };
            string pizzaQ;
            double Time = 5;
            double totalCost = 0;


            Console.WriteLine("How many pizzas would you like to order?");
            pizzaQ = Console.ReadLine();
            double pizzaA = Convert.ToDouble(pizzaQ);
            for (int a = 0; a < pizzaA; a++)
            {



                Console.WriteLine("What kind of pizza would you like for pizza {0}?", a+1);
                string pizzaChoice = Console.ReadLine();
                string upperChoice = pizzaChoice.ToUpper();
                for (int i = 0; i < 4; i++)
                {
                    if (pizzaSize[i] == upperChoice)
                    {
                        totalCost = totalCost + Price[i] * 1.1;
                        Console.WriteLine("Your total including tax will be ${0}.", totalCost);
                    }
                }
                Time = Time + 3;
            }
            Console.WriteLine("Thank you for choosing Pizza. Your order will be ready in {0} minutes!", Time);
            Console.ReadLine();
        }
    }
}
