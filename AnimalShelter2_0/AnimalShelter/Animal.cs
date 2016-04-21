using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
    //lol
{
    [Serializable()]
    public abstract class Animal:ISellable,IComparable<Animal>
    {

        public int ChipRegistrationNumber { get; }
 
        public SimpleDate DateOfBirth { get; }

        public string Name { get; }

        public bool IsReserved { get; set;}

        public abstract decimal Price { get;}

        public int CompareTo(Animal dier)
        {
            if (this.ChipRegistrationNumber == dier.ChipRegistrationNumber)
            {
                return this.Name.CompareTo(dier.Name);
            }
            return dier.ChipRegistrationNumber.CompareTo(this.ChipRegistrationNumber);
        }

        public Animal(int chipRegistrationNumber, SimpleDate dateOfBirth, string name)
        {
           
            if (chipRegistrationNumber > 0 && dateOfBirth != null && name != "" )
            {
                ChipRegistrationNumber = chipRegistrationNumber;
                DateOfBirth = dateOfBirth;
                Name = name;
                IsReserved = false;
            }
        }

        public override string ToString()
        {
            
                string IsReservedString;
                if (IsReserved)
                {
                    IsReservedString = "reserved";
                }
                else
                {
                    IsReservedString = "not reserved";
                }
                string info = ChipRegistrationNumber
                              + ", " + DateOfBirth
                              + ", " + Name
                              + ", " + IsReservedString;
                return info;
            
        }
    }
}
