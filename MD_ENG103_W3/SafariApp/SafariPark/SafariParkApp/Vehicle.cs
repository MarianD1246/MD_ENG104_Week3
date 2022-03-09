using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Vehicle :iMovalbe
    {
        public string VehicleType { get; init; }
        public int Position { get; protected set; }
        public int Speed { get; init; } //= 10;
        public int PassengerCapacity { get; init; }
        private int _passaengerNum;
        public int NumPassengers
        {
            get => _passaengerNum;

            // set => _passaengerNum = value < 0 ? throw new ArgumentException("Can't carry negative passengers.") : value > PassengerCapacity ? _passaengerNum = PassengerCapacity : _passaengerNum = value;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Can't carry negative passengers.");
                }
                else if (value > PassengerCapacity)
                {
                    _passaengerNum = PassengerCapacity;
                }
                else
                    _passaengerNum = value;
            }
        }


        public virtual string Move()
        {
            //return $"The car is at position: {Position}";
            Position += Speed;
            return "Moving along";
        }
        public virtual string Move(int times)
        {
            Position += (times * Speed);
            return times < 0 ? throw new ArgumentException("Can't move negative times.") : times == 0 ? "Car is stationary." :
                   times == 1 ? "Moving along 1 time." : $"Moving along {times} times.";
        }

        public Vehicle()
        {
            VehicleType = "Car";
            Position = 0;
            Speed = 10;
            PassengerCapacity = 4;
            NumPassengers = 1;
        }
        public Vehicle(int capacity, int speed = 10)
        {
            VehicleType = GetVehicleType(capacity);
            Position = 0;
            Speed = speed;
            PassengerCapacity = capacity;
            NumPassengers = 1;
        }

        public string GetVehicleType(int capacity)
        {
            return capacity <= 5 && capacity > 0 ? "Car" : capacity <= 7 ? "Family Car" : capacity <= 15 ? "Van" : capacity <= 45 ? "Bus" : capacity <= 850 ? "Airplane" : "UFO";
        }
    }
}
