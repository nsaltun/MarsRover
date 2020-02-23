using System;
using System.Reflection;

namespace MarsRoverProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "5 5" + "\n" +
                "1 2 N" + "\n" +
                "LMLMLMLMM" + "\n" +
                "3 3 E" + "\n" +
                "MMRMMRMRRM";
            var marsRover = new MarsRover.MarsRover(input);
            marsRover.ExplorePlateau();

            Console.ReadKey();
        }

    }
}
