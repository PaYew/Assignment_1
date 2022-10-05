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
        public FootballPlayer(int id, string name, int age, int shirtNo)
        {
            Id = id;
            Name = name;
            Age = age;
            ShirtNo = shirtNo;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNo { get; set; }


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
            if (ShirtNo < 1 || ShirtNo > 99)
                throw new ArgumentOutOfRangeException();
        }

    }
}