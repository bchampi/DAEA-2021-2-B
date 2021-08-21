using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, como te llamas?");
            String name = Console.ReadLine();
            Console.WriteLine("Mucho gusto en conocerte " + name);
        }
    }
}
