using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// <author>Gorkem Sazara</author>
// <date>12/02/2016</date>
// <summary>Nasa Mars Rover Console App</summary>
namespace NASA
{
    public class Plateau
    {
        public int X { get; set; }
        public int Y { get; set; }

        /// <summary>
        /// Width and height of the Plateau
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Plateau(Int32 x, Int32 y)
        {
            X = x;
            Y = y;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input");
            Console.WriteLine("5 5");

            Console.WriteLine("1 2 N");           
            RoboticRover firstRover = new RoboticRover(1, 2, RoboticRover.Direction.N, new Plateau(5, 5));
            Console.WriteLine("LMLMLMLMM");
            firstRover.Command("LMLMLMLMM");

            Console.WriteLine("3 3 E");
            RoboticRover secondRover = new RoboticRover(3, 3, RoboticRover.Direction.E, new Plateau(5, 5));            
            Console.WriteLine("MMRMMRMRRM");
            secondRover.Command("MMRMMRMRRM");            
            
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Output");

            firstRover.GetPosition();
            secondRover.GetPosition();
            
            Console.ReadLine();
        }
    }
}
