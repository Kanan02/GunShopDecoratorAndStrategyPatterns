using GunShop.Models.WeaponModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop.Models.MagazineModels
{
    class AverageMagazineDecorator : BaseMagazineDecorator
    {
        public AverageMagazineDecorator(Weapon weapon) : base(weapon.Damage, weapon.Distance,weapon.Price*=1.2,weapon.Magazine*=2, weapon.ShotTime, weapon)
        {
        }
    }
}
