using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Camera : iShootable
    {
        private string _brand;

        public Camera(string brand, string weaponType = "Camera")
        {
            //Weapon(brand, weaponType);
            _brand = brand;
        }

        public string Shoot()
        {
            return $"Took a picture using {_brand}";
        }

        public override string ToString()
        {
            return $"Camera: {_brand}";
        }
    }
}
