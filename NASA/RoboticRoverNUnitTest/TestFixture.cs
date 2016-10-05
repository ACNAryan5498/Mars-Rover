using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NASA;
// <author>Gorkem Sazara</author>
// <date>12/02/2016</date>
// <summary>Nasa Mars Rover Console App Unit Test</summary>
namespace RoboticRoverNUnitTest
{
    [TestFixture]
    public class TestFixtureNasa
    {
        private RoboticRover firstRover = null;
        private RoboticRover secondRover = null;

        /// <summary>
        /// Set the first roboticRover
        /// </summary>
        private void SetupFirstRover()
        {            
            firstRover = new RoboticRover(1, 2, RoboticRover.Direction.N, new Plateau(5, 5));            
        }

        /// <summary>
        /// Set the second roboticRover
        /// </summary>
        private void SetupSecondRover()
        {
            secondRover = new RoboticRover(3, 3, RoboticRover.Direction.E, new Plateau(5, 5));           
        }

        /// <summary>
        /// Correct assertion 
        /// </summary>
        [Test]
        public void MoveFirstRover()
        {
            SetupFirstRover();
            firstRover.Command("LMLMLMLMM");
            Assert.AreEqual(firstRover.GetPosition(), "1 3 N");            
        }
        
        /// <summary>
        /// Wrong assertion
        /// </summary>
        [Test]
        public void MoveSecondRover()
        {
            SetupSecondRover();
            secondRover.Command("MMRMMRMRRM");            
            Assert.AreEqual(secondRover.GetPosition(), "1 3 N");
            //Assert.AreEqual(secondRover.GetPosition(), "5 1 E");
        }

        /// <summary>
        /// Can't go out 
        /// </summary>
        [Test]
        public void BlurringTheBounries()
        {
            SetupSecondRover();
            secondRover.Command("MMMMMMMMMM");            
            Assert.AreEqual(secondRover.GetPosition(), "5 3 E");
        }
    }
}
