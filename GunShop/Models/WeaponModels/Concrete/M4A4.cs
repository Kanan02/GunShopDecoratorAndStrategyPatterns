using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop.Models.WeaponModels.Concrete
{
    public class M4A4:Weapon
    {
        public M4A4(double damage, double distance, double price, int magazine, int shotTime) : base(damage, distance, price, magazine, shotTime)
        {
            Name = nameof(M4A4);
        }
    }
}
