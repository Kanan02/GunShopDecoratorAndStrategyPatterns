using GunShop.Models.WeaponModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop.Models.UserModels
{
    public class User
    {
        public User(string name, double money)
        {
            Name = name;
            Money = money;
            Weapons = new List<Weapon>();
        }
        public User(string name, double money, Weapon gun) : this(name, money)
        {
            Gun = gun;
        }

        public string Name { get; set; }
        public double Money { get; set; }
        public Weapon Gun { get; set; } = null;
        public List<Weapon> Weapons { get; set; }
        public void ShowInventory()
        {
            if (Weapons.Count == 0)
            {
                Console.WriteLine("\t\tYour Inventory is Empty!\n\nPress any key to continue...");
                Console.ReadKey();
                return;
            }
            for (int i = 0; i < Weapons.Count; i++)
            {
                if (Gun==Weapons[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine($"{i + 1}." + Weapons[i]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine($"Exit:{Weapons.Count+1}");
            Console.WriteLine("Choose Main Weapon:");
            int choice = int.Parse(Console.ReadLine());
            if (choice != Weapons.Count+1)
            {
                Gun = Weapons[choice - 1];
            }

        }
        public override string ToString()
        {
            string gun;
            if (Gun==null)
            {
                gun =string.Empty;
            }
            else
            {
                gun = Gun.Name;
            }
            return $"{Name}, Balance: {Money}, Weapon: {gun}";
        }
    }
}
