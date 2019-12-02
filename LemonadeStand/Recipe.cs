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
        public string itemsInRecipe;
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double costToMakePerCup;
        public double cupSellsFor;

        // constructor (SPAWNER)
        public Recipe()
        {
            itemsInRecipe = 
        }

        //member methods (CAN DO)
        public void CalcCostPerCup()
        {
        //    costToMakePerCup = Store.pricePerLemon;
        }
        public void CreateRecipe()
        {
            Console.WriteLine("How many lemons would you like to add for this recipe?");
            amountOfLemons = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many sugar cubes would you like to add for this recipe?");
            amountOfSugarCubes = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many ice cubes would you like to add for this recipe?");
            amountOfIceCubes = Int32.Parse(Console.ReadLine());
        }

    }
}
