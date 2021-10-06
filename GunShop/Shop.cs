using GunShop.Models.MagazineModels;
using GunShop.Models.UserModels;
using GunShop.Models.WeaponModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop
{
    public class Shop
    {
        public Shop(User user,List<Weapon> weapons)
        {
            User = user;
            Weapons = weapons;
        }
        public User User { get; set; }
        public List<Weapon> Weapons { get; set; }
        public void ShowShop()
        {
            Console.Clear();
            Console.WriteLine(User);
            for (int i = 0; i < Weapons.Count; i++)
            {
                Console.WriteLine($"{i+1}.{Weapons[i]}");
            }
            Console.WriteLine($"{Weapons.Count+1}.Exit");
            Console.Write("Choose Weapon:");
            int choice = int.Parse(Console.ReadLine());
            if (choice==Weapons.Count+1)
            {
                Console.Clear();
                return;
            }
            User.Gun = Weapons[choice - 1];
            Console.Clear();
            Console.WriteLine(User);
            Console.WriteLine("Choose Magazine for your weapon: ");
            List<BaseMagazineDecorator> magazines = new List<BaseMagazineDecorator> { new SmallMagazineDecorator(User.Gun), new AverageMagazineDecorator(User.Gun), new BigMagazineDecorator(User.Gun) };
            for (int i = 0; i < magazines.Count; i++)
            {
                Console.WriteLine($"{i+1}. {magazines[i].Magazine} ammos. Overall Price of weapon will be: {magazines[i].Price}");
            }
            choice=int.Parse(Console.ReadLine());
            User.Gun = magazines[choice - 1];
            User.Money -= User.Gun.Price;
            User.Weapons.Add( magazines[choice - 1]);
        }

        
    }
}
