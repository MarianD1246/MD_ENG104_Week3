using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class LaserGun : Weapons
    {

        public LaserGun(string brand, string weaponType = "LaserGun") 
        {
            Weapon(brand, weaponType);  
        }

        public override string Shoot()
        {
            return $"Zing!! {base.Shoot()}";
        }

        public override string ToString()
        {
            return $"{base.ToString}";
        }
    }
}
