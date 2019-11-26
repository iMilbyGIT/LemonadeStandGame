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
            BuildCustomersPerDay();
        }

        void BuildCustomersPerDay()
        {
            for (int i = 0; i < 15; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
            }
        }



        //member methods (CAN DO)
        public void RunDay()
        {
         //all the logic needed for one day to happen
        }
    }
}
