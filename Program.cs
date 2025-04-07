using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{

    internal class Program
    {
        
        static void Main (string [ ] args)
        {
            while (true)
            {
                CoffeClass coffee = new CoffeClass( );
                CoffeeType type = new CoffeeType( );
                Console.WriteLine("Выберите кофе:\n1)Americano\n2)Latte\n3)Cappucino\n4)Espresso");
                int c = Convert.ToInt32(Console.ReadLine( ));
                if (c == 1)
                {
                    type = CoffeeType.AMERICANO;
                    coffee.OrderCoffee(type);
                }
                else if (c == 2)
                {
                    type = CoffeeType.CAFFEE_LATTE;
                    coffee.OrderCoffee(type);
                }
                else if (c == 3)
                {
                    type = CoffeeType.CAPPUCINO;
                    coffee.OrderCoffee(type);
                }
                else if (c == 4)
                {
                    type = CoffeeType.ESPRESSO;
                    coffee.OrderCoffee(type);
                }
                Console.ReadKey( );
            }
        }
    }
}
