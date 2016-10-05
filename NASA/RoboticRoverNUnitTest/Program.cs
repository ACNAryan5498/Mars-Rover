using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
// <author>Gorkem Sazara</author>
// <date>12/02/2016</date>
// <summary>Nasa Mars Rover Console App Unit Test</summary>
namespace RoboticRoverNUnitTest
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string[] my_args = { Assembly.GetExecutingAssembly().Location };

            int returnCode = NUnit.ConsoleRunner.Runner.Main(my_args);

            if (returnCode != 0)
                Console.Beep();
        }
    }
}
