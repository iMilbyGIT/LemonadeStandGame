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
        public void RunDay()
        {
            Console.WriteLine("Welcome to the C# Lemonade Stand! Would you like to buy lemons, sugar cubes, ice cubes, or cups?");
            string whatToBuyInput = Console.ReadLine();
                switch(whatToBuyInput)
                {
                case "lemons":

                case "sugar cubes":

                case "ice cubes":

                case "cups":

                default:
                Console.WriteLine("That's not one of ades of lemond! Please enter an ingredient to make your delicious lemonade!");
                return;
            }
        }
    }
}
