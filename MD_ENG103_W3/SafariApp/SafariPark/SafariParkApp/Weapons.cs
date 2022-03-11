using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public abstract class Weapons : iShootable
    {
        private string _brand;
        //private string Brand { get; init; }
        private string _weaponType = "none";

        public virtual string Shoot()
        {
            return $"shot using {_brand}";
        }

        public override string ToString()
        {
            return $"Brand: {_brand}";
        }
            
        public void Weapon(string brand, string weaponType) //set Method
        {
            _brand = brand;
            _weaponType = weaponType;
        } 
    
        public string WeaponType()
        {
            return _weaponType;
        }

        public string ShootAnimal(ZooAnimal animal)
        {
            if (_weaponType == "Camera")
                return $"The {animal} squints it's eyes";
            else if (_weaponType == "LaserGun")
                return $"The {animal} disintegrates";
            else if (_weaponType == "WaterPistol")
                return $"The {animal} is angry, grr!";
            else
                return $"The {animal} doesn't react";
        }
    }
}
