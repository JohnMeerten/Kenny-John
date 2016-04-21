using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelter
{
    [Serializable()]
    public class Dog : Animal
    {

        public SimpleDate LastWalkDate { get; }

        public override decimal Price { get; }
        
        public Dog(int chipRegistrationNumber, SimpleDate dateOfBirth,
            string name, SimpleDate lastWalkDate) : base(chipRegistrationNumber, dateOfBirth, name)
        {
            
            if (chipRegistrationNumber > 0 && dateOfBirth != null && name != "")
            {
                this.LastWalkDate = lastWalkDate;
                if (ChipRegistrationNumber < 50000)
                {
                    Price = 200;
                }
                else
                {
                    Price = 350;
                }
            }
        } 

        public override string ToString()
        {
            string lastWalkDateString;
            
            if (LastWalkDate == null)
            {
                lastWalkDateString = "Unknown";
            }
            else
            {
                lastWalkDateString = LastWalkDate.ToString();
            }

            string info = "Dog: " + base.ToString() + ", " + lastWalkDateString;
            return info;
        }
    }
}

