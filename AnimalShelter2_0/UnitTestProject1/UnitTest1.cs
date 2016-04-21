using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Cat cattest;
        private Dog dogtest;
        private Adminstration admintest;

        [TestMethod]

        public void MakeDog()
        {
            int chipRegistrationNumber = 123;
            SimpleDate dateOfBirth = new SimpleDate(4, 4, 2016);
            string name = "Willem";
            SimpleDate lastWalkDate = new SimpleDate(5, 5, 2016);

            dogtest = new Dog(chipRegistrationNumber, dateOfBirth, name, lastWalkDate);

        }

        [TestMethod]
        public void MakeCat()
        {
            int chipRegistrationNumber = 123;
            SimpleDate dateOfBirth = new SimpleDate(2, 3, 2015);
            string name = "Piet";
            string badHabits = "slaapt veel";

            cattest = new Cat(chipRegistrationNumber, dateOfBirth, name, badHabits);
        }
        [TestMethod]
        public void TestAdmin()
        {
            admintest = new Adminstration();
            MakeCat();
            admintest.Add(cattest);
            Animal mycat = admintest.FindAnimal(123);
            Assert.AreEqual(mycat.Name, "Piet");
        }

        [TestMethod]
        public void TestAdminRemove()
        {
            admintest = new Adminstration();
            MakeCat();
            admintest.Add(cattest);
            Animal mycat = admintest.FindAnimal(123);
            admintest.RemoveAnimal(123);
            Animal geencat = admintest.FindAnimal(123);
            Assert.AreEqual(geencat, null);

        }


        [TestMethod]
        public void TestDogchipnumber()
        {
            MakeDog();
            int expected = 123;
            int actual = dogtest.ChipRegistrationNumber;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestDogDateofbirth()
        {
            MakeDog();

            SimpleDate expected = new SimpleDate(4, 4, 2016);
            SimpleDate actual = dogtest.DateOfBirth;

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void TestDogName()
        {
            MakeDog();
            string expected = "Willem";
            String actual = dogtest.Name;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDogLastwalkdate()
        {
            MakeDog();
            SimpleDate expected = new SimpleDate(5, 5, 2016);
            SimpleDate actual = dogtest.LastWalkDate;

            Assert.AreEqual(expected.ToString(), actual.ToString());

        }
        //
        //
        //
        [TestMethod]
        public void TestCatChipnumber()
        {
            MakeCat();
            int expected = 123;
            int actual = cattest.ChipRegistrationNumber;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCatDateofbirth()
        {
            MakeCat();
            SimpleDate expected = new SimpleDate(2, 3, 2015);
            SimpleDate actual = cattest.DateOfBirth;

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void TestCatName()
        {
            MakeCat();
            string expected = "Piet";
            string actual = cattest.Name;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCatBadhabits()
        {
            MakeCat();
            string expected = "slaapt veel";
            string actual = cattest.BadHabits;

            Assert.AreEqual(expected, actual);

        }



        public void TestAdminFind()
        {

        }


    }
}
