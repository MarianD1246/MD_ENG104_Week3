using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Airplane : Vehicle
    {
        private string _airline = "AirCurve"; 

        public int Altitude {  get; private set; }

        public Airplane(int capacity) :base(capacity)
        {
            //:base(capacity) does the same as line below
            //PassengerCapacity = capacity;
        }

        public Airplane(int capacity, int speed, string airline)
        {
            PassengerCapacity = capacity;
            Speed = speed;
            _airline = airline;
        }

        public void Ascend(int distance)
        {
            Altitude += Speed > 0 ? distance : 0;
        }
        public void Descend(int distance)
        {
            Altitude -= distance;
            if (Altitude < 0)
                Altitude = 0;
        }

        public override string Move()
        {
            Position += Speed; 
            return Altitude > 0 ? $"Moving along at an altitude of {Altitude} meters." : $"Airplane on stand by at position {Position}";
        }

        public override string Move(int times)
        {
            Position += Speed * times;
            return Altitude > 0 ? $"Moving along {times} times at an altitude of {Altitude} meters." : $"Airplane on stand by at position {Position}";
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} capacity: {PassengerCapacity} passengers: {NumPassengers} speed: {Speed} position: {Position} altitude: {Altitude}";
        }
    }
}
