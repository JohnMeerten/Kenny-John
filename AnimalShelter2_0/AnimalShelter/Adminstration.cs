using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace AnimalShelter
{
   
    public class Adminstration
   {
       private  List<Animal> animalList = new List<Animal>();

        public ReadOnlyCollection<Animal> AnimalList
        {
            get { return animalList.AsReadOnly(); }
        }

       

        private BinaryFormatter formatter = new BinaryFormatter();

       public Adminstration()
       {
           
       }

        public bool Add(Animal animal)
        {
            if (animal != null)
            {
                foreach (Animal itemAnimal in animalList)
                {
                    if (itemAnimal.ChipRegistrationNumber == animal.ChipRegistrationNumber)
                    {
                        return false;
                    }
                }
                animalList.Add(animal);
                return true;
            }
            return false;

        }

        public bool RemoveAnimal(int chipRegistrationNumber)
        {
            if (chipRegistrationNumber > 0)
            {
                foreach (Animal itemAnimal in animalList)
                {
                    if (itemAnimal.ChipRegistrationNumber == chipRegistrationNumber)
                    {
                        animalList.Remove(itemAnimal);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }


    public Animal FindAnimal(int chipRegistrationNumber)
        {
         
                foreach (Animal itemAnimal in animalList)
                {
                    if (itemAnimal.ChipRegistrationNumber == chipRegistrationNumber)
                    {
                        return itemAnimal;
                    }
                    else
                    {
                        return null;
                    }
                }
            return null;

        }
       
        public void Save(string fileName)
        {


            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {

                    foreach (Animal dier in animalList)
                    {
                        formatter.Serialize(fs, dier);
                    }
                }
                animalList.Clear();
            }
            catch (SerializationException)
            {
                throw;
            }


        }

     
        public void Load(string fileName)
        {
                animalList.Clear();
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    Animal dier = (Animal) formatter.Deserialize(fs);
                    animalList.Add(dier);
                }
            }
            catch (SerializationException)
            {
                throw;
            }
            catch (FileNotFoundException)
            {
                throw;
            }
            

        }

       public void Export(string fileName )
       {

           try
           {
               using (StreamWriter sw = new StreamWriter(fileName))
               {
                   foreach (Animal dier in animalList)
                   {
                       sw.WriteLine(dier);
                   }
               }
           }
           catch (ArgumentNullException)
           {
               throw;
           }
       }
    }
}
