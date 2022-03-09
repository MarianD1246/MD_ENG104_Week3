using NUnit.Framework;
using SafariParkApp;
using System;


namespace SafariTestPark
{
    public class PersonTests
    {
        [TestCase("Cathy", "French", "Cathy French")]
        [TestCase("", "", " ")]

        public void GetFullNameTest(string fName, string lName, string expected)
        {
            var subject = new Person(fName, lName);
            var result = subject.GetFullName();
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void AgeTest()
        {
            var subject = new Person("A", "B");
            subject.Age = 35;
            Assert.AreEqual(35, subject.Age);

        }
    }

    public class VehicleTests
    {
        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times.", result);
            Assert.AreEqual("Car", v.VehicleType);
        }
        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle vi = new Vehicle(6, 40);
            var result = vi.Move();
            Assert.AreEqual(40, vi.Position);
            Assert.AreEqual("Moving along", result);
            Assert.AreEqual("Family Car", vi.VehicleType);
        }

        [Test]
        public void WhenVehicalCapacityIs16andNumberOfPassangerExceedCapacity_VehicalTypeIsBusAndVehicalCapacityEqualsMaxCpacity()
        {
            Vehicle v = new Vehicle(16, 30);
            var result = v.Move();
            Assert.AreEqual(30, v.Position);
            Assert.AreEqual("Moving along", result);
            Assert.AreEqual("Bus", v.VehicleType);
            v.NumPassengers = 20;
            Assert.AreEqual(v.NumPassengers, 16);
        }
    }

    public class AirplaneTests
    {
        [Test]
        public void TestingAirplaneHappyScenario()
        {
            Airplane a = new Airplane(120, 200, "UinAir") { NumPassengers = 80};
            a.Ascend(350);
            var moving = a.Move();
            Assert.AreEqual(200, a.Position);
            Assert.AreEqual("Moving along at an altitude of 350 meters.", moving);
            Assert.AreEqual("Airplane", a.GetVehicleType(120));
            Assert.AreEqual(80, a.NumPassengers);
            Assert.AreEqual(a.ToString(), "Thank you for flying UinAir: SafariParkApp.Airplane capacity: 120 passengers: 80 speed: 200 position: 200 altitude: 350");
            a.Descend(50);
            moving = a.Move(2);
            Assert.AreEqual("Moving along 2 times at an altitude of 300 meters.", moving);
            Assert.AreEqual(600, a.Position);
            Assert.AreEqual(a.ToString(), "Thank you for flying UinAir: SafariParkApp.Airplane capacity: 120 passengers: 80 speed: 200 position: 600 altitude: 300");

        }

        [Test]
        public void TestingAirplaneAlternativeScenario()
        {
            Airplane a = new(120,0,"") { NumPassengers = 80 };
            var moving = a.Move();
            a.Ascend(150);
            a.Move();
            Assert.AreEqual(0, a.Position);
            Assert.AreEqual("Airplane on stand by at position 0", moving);
            Assert.AreEqual("Airplane", a.GetVehicleType(120));
            Assert.AreEqual(80, a.NumPassengers);
            Assert.AreEqual(a.ToString(), "Thank you for flying : SafariParkApp.Airplane capacity: 120 passengers: 80 speed: 0 position: 0 altitude: 0");
        }

        [Test]
        public void TestingAirplaneTrowExceptionWhenNumPassengersIsNegative()
        {
            Airplane a = new(120);
            Assert.Throws<ArgumentException>(() => a.NumPassengers = -80);
            
        }
    }
}