using GunShop.Models.UserModels;
using GunShop.Models.WeaponModels;
using GunShop.Models.WeaponModels.Concrete;
using GunShop.Strategy;
using System;
using System.Collections.Generic;
using System.Threading;

namespace GunShop
{
    class Program
    {
        static List<Weapon> GenerateWeapons()
        {
            return new List<Weapon> { new AK47(30, 1000, 200, 30,100), new M4A4(25, 800, 150, 35,200), };
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome to Gun Tier!");
            Console.WriteLine("Enter your Name: ");
            string name=Console.ReadLine();
            User user = new User(name, 1000);
            Console.Clear();
            bool play = true;
            while (play)
            {
                Console.WriteLine($"\t\tHello {user.Name}! Your initial bank is: {user.Money}\n\n");
                Console.WriteLine("1.Shop\n2.WeaponTest\n3.Inventory\n4.Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Shop shop = new Shop(user, GenerateWeapons());
                        shop.ShowShop();
                        break;
                    case 2:
                        Console.Clear();
                        if (user.Gun!=null)
                        {
                            ShootDrafter shootDrafter = new ShootDrafter(user.Gun);
                            shootDrafter.BuildShots();
                            user.Money += user.Gun.Price;
                            Console.WriteLine($"You have gained {user.Gun.Price}$!");
                        }
                        else
                        {
                            Console.WriteLine("You have no weapons!");
                        }
                        Thread.Sleep(2000);
                        break;
                    case 3:
                        Console.Clear();
                        user.ShowInventory();

                        break;
                    case 4:
                        play = false;
                        break;
                    default:
                        break;
                }
                Console.Clear();

            }
        }
    }
}
