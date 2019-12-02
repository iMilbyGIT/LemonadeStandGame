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
        public int lemonsInAPitcher;
        public int sugarCubesInAPitcher;
        public int iceCubesInAPitcher;
        bool isFull;
        

        //constructor (Spawner)
        public Pitcher()
        {
            cupsLeftInPitcher = 0;
            isFull = false;
        }
        // member methods (CAN DO)
        public void CreatePitcher()
        {
        //    Inventory.lemons
        //    Inventory.sugarCubes
        //    Inventory.iceCubes
        //    Inventory.cups
        }
        public void IngredientCountDown()
        {
//            while (cookTime >= 0)
//            {
//                Console.WriteLine(cookTime);
//                if (cookTime == 0)
//                {
//                    PowerOff();
//                    Console.WriteLine("microwave turned off!");
//                }
//                cookTime--;
//            }
        }

    }
}
