using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    internal class WaterPistol : Weapons
    {

        public WaterPistol(string brand, string weaponType = "WaterPistol")
        {
            Weapon(brand, weaponType);
        }

        public override string Shoot()
        {
            return $"Splas {base.Shoot()}";
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
 

    }
}
