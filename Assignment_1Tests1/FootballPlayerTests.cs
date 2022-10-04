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
        private FootballPlayer player = new FootballPlayer { Id = 1, Name = "Abcde", Age = 25, ShirtNumber = 10 };
        private FootballPlayer playerName = new FootballPlayer { Id = 2, Name = "A", Age = 22, ShirtNumber = 15 };
        private FootballPlayer playerAge = new FootballPlayer { Id = 4, Name = "Abcde", Age = 0, ShirtNumber = 25 };
        private FootballPlayer playerShirt = new FootballPlayer { Id = 5, Name = "Abcde", Age = 22, ShirtNumber = 200 };


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