using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class CoffeClass
    {
        public void GrindCoffee ()
        {
            Console.WriteLine("Перемалываем кофе");
        }
        public void MakeCoffee ()
        {
            Console.WriteLine("Делаем кофе");
        }
        public void PourIntoCup ()
        {
            Console.WriteLine("Наливаем кофе в стакан");
        }
        public CoffeClass OrderCoffee (CoffeeType type)
        {
            CoffeClass coffee = null;
            switch (type)
            {
                case CoffeeType.AMERICANO:
                    coffee = new Americano( );
                    break;
                case CoffeeType.ESPRESSO:
                    coffee = new Espresso( );
                    break;
                case CoffeeType.CAPPUCINO:
                    coffee = new Espresso( );
                    break;
                case CoffeeType.CAFFEE_LATTE:
                    coffee = new CaffeLatte( );
                    break;
            }
            Console.WriteLine($"Вы заказали - {type}");
            coffee.GrindCoffee( );
            coffee.MakeCoffee( );
            coffee.PourIntoCup( );
            Console.WriteLine("Вот ваш кофе, приходите к нам еще!!))");
            return coffee;
        }
    }
}
