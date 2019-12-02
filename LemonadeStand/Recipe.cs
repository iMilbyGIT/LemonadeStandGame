using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {
        // member variables (HAS A)
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double costToMakePerCup;

        // constructor (SPAWNER)
        public Recipe(int amountOfLemons, int amountOfSugarCubes, int amountOfIceCubes)
        {
            this.amountOfLemons = amountOfLemons;
            this.amountOfSugarCubes = amountOfSugarCubes;
            this.amountOfIceCubes = amountOfIceCubes;
        }
        //member methods (CAN DO)
        public void CalcCostPerCup()
        {
        //    costToMakePerCup = Store.pricePerLemon;
        }


    }
}
