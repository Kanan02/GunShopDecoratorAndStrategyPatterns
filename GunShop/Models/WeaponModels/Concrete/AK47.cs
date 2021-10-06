using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop.Models.WeaponModels.Concrete
{
    public class AK47:Weapon
    {
        public AK47(double damage, double distance, double price, int magazine,int shotTime):base(damage,distance,price,magazine,shotTime)
        {
            Name = nameof(AK47);
        }
    }
}
