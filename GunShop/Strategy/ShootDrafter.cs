using GunShop.Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop.Strategy
{
    public class ShootDrafter
    {
        public ShootDrafter(IShootStrategy gun)
        {
            Gun = gun;
        }
        public IShootStrategy Gun { get; set; }
        
        public void BuildShots()
        {
            Gun.buildShots();
        }

    }
}
