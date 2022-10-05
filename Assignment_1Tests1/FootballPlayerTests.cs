using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        private FootballPlayer player = new FootballPlayer (1, "Abcde", 25, 10 );
        private FootballPlayer playerName = new FootballPlayer (2, "A", 22,15 );
        private FootballPlayer playerAge = new FootballPlayer (4, "Abcdef", 0, 25 );
        private FootballPlayer playerShirt = new FootballPlayer (5,"Abcdefg",22, 200 );


        [TestMethod()]
        public void ValidateNameTest()
        {
            player.CheckName();
            Assert.ThrowsException<ArgumentException>(() => playerName.CheckName());
        }

        [TestMethod()]
        public void ValidateAgeTest()
        {
            player.CheckAge();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerAge.CheckAge());
        }

        [TestMethod()]
        public void ValidateShirtNumberTest()
        {
            player.CheckShirtNumber();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerShirt.CheckShirtNumber());
        }

    }
}