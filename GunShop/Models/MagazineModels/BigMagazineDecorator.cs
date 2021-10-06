using GunShop.Models.WeaponModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop.Models.MagazineModels
{
    class BigMagazineDecorator : BaseMagazineDecorator
    {
        public BigMagazineDecorator(Weapon weapon) : base(weapon.Damage, weapon.Distance, weapon.Price*=2, weapon.Magazine*=4, weapon.ShotTime, weapon)
        {

        }

    }
}
