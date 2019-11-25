using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Wallet
    {
        // member variables (HAS A)
        private double money;

        public double Money
        {
            get
            {
                return money;
            }
        }
        // constructor (SPAWNER)
        public Wallet()
        {
            money = 20.00;
        }
        //member methods(CAN DO)
        public void PayMoneyForItems(double transactionAmount)
        {
            money -= transactionAmount;
        }
    }
}
