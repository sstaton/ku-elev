using System;

namespace ku_elev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many floors?");
            int flo = Console.Read();
            Console.WriteLine(flo);
            Console.WriteLine("How many elevators?");
            int elev = Console.Read();
            Console.WriteLine(elev);
            ControlBoard controlBoard = new ControlBoard(flo, elev);
        }
    }
}
