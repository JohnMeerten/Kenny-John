using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    [Serializable()]
    public class Cat : Animal
    {

        public string BadHabits { get; }

        public override decimal Price { get; }

        public Cat(int chipRegistrationNumber, SimpleDate dateOfBirth,
                   string name, string badHabits) : base(chipRegistrationNumber, dateOfBirth, name)
        {
            if (chipRegistrationNumber > 0 && dateOfBirth != null && name != "")
            {
                if (badHabits == "")
                {
                    BadHabits = "none";
                }
                else
                {
                    BadHabits = badHabits;
                }
                int count = badHabits.Length;
                Price = 60 - (20*count);
                if (Price < 20)
                {
                    Price = 20;
                }
            }
        }

        public override string ToString()
        {
            
            string info = "Cat: " + base.ToString() + ", " + BadHabits;
                         
            return info;
        }
    }
}
