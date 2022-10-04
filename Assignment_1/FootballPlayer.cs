using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public FootballPlayer(int id, string name, int age, int shirtNumber)
        {
            Id = id;
            Name = name;
            Age = age;
            ShirtNumber = shirtNumber;  
        }

        public void CheckName()
        {
            if (Name.Length < 2)
                throw new ArgumentException();
        }

        public void CheckAge()
        {
            if (Age <= 1)
                throw new ArgumentOutOfRangeException();
        }

        public void CheckShirtNumber()
        {
            if (ShirtNumber < 1 || ShirtNumber > 99)
                throw new ArgumentOutOfRangeException();
        }

    }
}