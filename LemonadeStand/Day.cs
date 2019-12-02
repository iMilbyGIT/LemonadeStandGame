using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {   //member variables (HAS A)
        public Weather weather;
        public Customer customer;
        List<Customer> customers;
        public Pitcher pitcher;
        public Recipe recipe;

        // constructor (SPAWNER) 
        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();
            BuildCustomersPerDay();
        }
        // SOLID PRINCIPLE 2 - OPEN/CLOSED EXAMPLE
        void BuildCustomersPerDay()
        {
            for (int i = 0; i < 30; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
            }
        }
        //member methods (CAN DO)
        public void RunDay(Player player, Store store)
        {
            Console.WriteLine("Would you like to buy lemons, sugar cubes, ice cubes, or cups? If you don't need to buy more items please type: -money- to check how much cash you have, -inventory- to check stock levels, or -make- to make recipe for the day.");
            string whatToBuyInput = Console.ReadLine();
                switch(whatToBuyInput)
                {
                    case "lemons":
                    store.SellLemons(player);
                    break;
                    case "sugar cubes":
                    store.SellSugarCubes(player);
                    break;
                    case "ice cubes":
                    store.SellIceCubes(player);
                    break;
                    case "cups":
                    store.SellCups(player);
                    break;
                    case "inventory":
                    
                    break;
                    case "make":
                    player.Recipe(player);
                    break;
                    case "money":
                //    Wallet.Money.get();
                    break;
                    default:
                    Console.WriteLine("That's not one of ades of lemon! Please enter an ingredient or next step to make your delicious lemonade!");
                    return;
                }
        }
    }
}
