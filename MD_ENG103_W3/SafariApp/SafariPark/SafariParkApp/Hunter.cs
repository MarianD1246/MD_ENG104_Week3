using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Hunter : Person, iShootable
    {
        private readonly object _camera;

        //private string _camera;

        public iShootable Shooter { get ; set ;}

        public Hunter(string fName, string lName, iShootable shooter) : base(fName, lName)
        {
            Shooter = shooter;
        }

        public Hunter(string fName, string lName) : base(fName, lName)
        {

        }

        public Hunter()
        {   

        }

        //Change theHunterShoot method so the Hunter calls the Shooter Shoot() method.
        //(Hunters aren’t born with the power to shoot, they need to use an object that can).
        public string Shoot()
        {
            var shot = Shooter.Shoot();
            return $"{GetFullName()} has shot with {shot}"; 
        }


        public override string ToString()
        {
            return $"{base.ToString()} Shooter: {Shooter}";
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



