using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Pitcher
    {
        // member variables (HAS A)
        public int cupsLeftInPitcher;
        public int cupsInAPitcher;
        

        //constructor (Spawner)
        public Pitcher()
        {
            cupsInAPitcher = 16;
        //    cupsLeftInPitcher = null;
        }
        // member methods (CAN DO)
        public void CreatePitcher()
        {
        //    Inventory.lemons
        //    Inventory.sugarCubes
        //    Inventory.iceCubes
        //    Inventory.cups
        }
        public void CupCountDown()
        {
            while (cupsLeftInPitcher >= 0)
            {
                Console.WriteLine(cupsLeftInPitcher);
                if (cupsLeftInPitcher == 0)
                {
                    Console.WriteLine("pitcher is empty!");
                }
                cupsLeftInPitcher--;
            }
        }

    }
}
