using SuperHeros.Logic;
using System;

namespace SuperHeros
{
    class Program
    {
        static void Main(string[] args)
        {
            var superherologic = new PowerLogic();
            superherologic.DisplayHeros();
            Console.ReadKey();
        }
    }
}
