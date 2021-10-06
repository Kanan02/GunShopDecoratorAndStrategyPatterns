using GunShop.Models.WeaponModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop.Models.MagazineModels
{
    public abstract class BaseMagazineDecorator:Weapon
    {
        public BaseMagazineDecorator(double damage, double distance, double price, int magazine, int shotTime,Weapon weapon): base(damage, distance, price, magazine, shotTime)
        {
            Weapon = weapon;
            Name = weapon.Name;
        }
        public Weapon Weapon { get; set; }

    }
}
