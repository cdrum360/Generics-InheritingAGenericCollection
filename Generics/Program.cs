using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            UseTheMagicHat();

            Console.WriteLine("Ta Da!");
            Console.ReadLine();
        }

        private static void UseTheMagicHat()
        {
            Console.WriteLine("Abracadabra");

            MagicHat<Rabbit> hat = new MagicHat<Rabbit>();      // instaniate a MagicHat of Rabbit
            
            hat.Enqueue(new Rabbit { Name = "Bugs" });          // use the operations inherited Queue<T> 
            hat.Enqueue(new Rabbit { Name = "Roger" });
            hat.Enqueue(new Rabbit { Name = "Thumper" });

            Rabbit firstRabbit = hat.Dequeue();                 
        }
    }
}
