using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class ZooAnimal
    {
        public string Animal { get; init; }

        public ZooAnimal(string animal)
        {
            Animal = animal;
        }

        public string Reaction(iShootable weapon)
        {
 
            if (weapon is Camera)
                return $"The {Animal} squints it's eyes";
            else if (weapon is LaserGun)
                return $"The {Animal} disintegrates";
            if (weapon is WaterPistol)
                return $"The {Animal} is angry, grr!";
            else
                return $"The {Animal} doesn't react";
            //throw new NotImplementedException();

            //return weapon;
        }
    }
}
