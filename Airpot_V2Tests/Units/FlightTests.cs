using Microsoft.VisualStudio.TestTools.UnitTesting;
using Airpot_V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airpot_V2.Tests
{
    [TestClass()]
    public class FlightTests
    {



        [TestMethod()]
        public void FlightTest()
        {
            Flight flightA = new Flight();
            Flight flightB = new Flight();

            Assert.AreNotEqual(flightA, flightB);
        }

        [TestMethod()]
        public void FlightTest1()
        {
            Flight flightA = new Flight(2015, 12, 1, 1, 1, 21, 1, 1, "kharkiv", "MAU", Status.unknown, Direction.Arrival);
            Flight flightB = new Flight(2016, 12, 1, 1, 1, 21, 1, 1, "kharkiv", "MAU", Status.unknown, Direction.Arrival);
            Assert.AreNotSame(flightA, flightB);
        }



        [TestMethod()]
        public void ToStringTest()
        {

        }

        [TestMethod()]
        public void GetPassangersQuantityTest()
        {

        }
    }
}