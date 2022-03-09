using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Hunter : Person
    {
        private string _camera;

        public Hunter(string fName, string lName, String camera = "") : base(fName, lName)
        {
            _camera = camera;
        }
        public Hunter()
        {

        }

        public string Shoot()
        {
            return $"{FullName} has taken a photo with {_camera}"; 
        }


        public override string ToString()
        {
            return $"{base.ToString()} Camera: {_camera}";
        }

    }


    public class MonsterHunter : Hunter
    {
        public override string ToString()
        {
            return "I'm a Monster Hunter.";
        }
    }
}



