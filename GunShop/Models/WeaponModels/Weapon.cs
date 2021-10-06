using GunShop.Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GunShop.Models.WeaponModels
{
    public abstract class Weapon : IShootStrategy
    {
        protected Weapon(double damage, double distance, double price, int magazine,int shotTime)
        {
            Damage = damage;
            Distance = distance;
            Price = price;
            Magazine = magazine;
            ShotTime = shotTime;
        }
        public string Name { get; set; } = null;
        public double Damage { get; set; }
        public double Distance { get; set; }
        public int ShotTime { get; set; }
        public double Price { get; set; }
        public int Magazine { get; set; }
        public void buildShots()
        {
            Console.WriteLine(this);
            for (int i = 0; i < Magazine; i++)
            {
                
                Thread.Sleep(ShotTime);
                Console.Write("-");
                
            }
            Console.WriteLine();
        }
        public override string ToString()
        {
            return $"Name:{Name} Damage:{Damage} Distance:{Distance} Price:{Price} Magazine:{Magazine} ";
        }
    }
}
