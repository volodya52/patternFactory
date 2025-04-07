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
            CoffeClass coffee = new CoffeClass( );
            CoffeeType type = new CoffeeType( );
            type = CoffeeType.CAPPUCINO;
            coffee.OrderCoffee(type);
            Console.ReadKey( );
        }

        

        
    }
}
