using GunShop.Models.WeaponModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop.Models.MagazineModels
{
    class SmallMagazineDecorator : BaseMagazineDecorator
    {
        public SmallMagazineDecorator(Weapon weapon) : base(weapon.Damage, weapon.Distance, weapon.Price, weapon.Magazine, weapon.ShotTime, weapon)
        {
        }
    }
}
