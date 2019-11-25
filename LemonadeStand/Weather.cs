using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        //member variables (HAS A)
        public string Condition;
        public int Temperature;
        public List<string> PossibleConditions;

        // constructor (SPAWNER)
        public Weather()
        {

        }

        // member methods (CAN DO)
        public void GenerateTemp()
        {
            Random rng = new Random();
            Temperature = rng.Next(30, 95);   
        }
        public void GenerateCondition()
        {
            PossibleConditions = new List<string> { "Sunny", "Mostly Sunny", "Partly Cloudy/Sunny", "Mostly Cloudy", "Overcast" };
            Random rng = new Random();
            Condition = rng.Next();
        }
    }
}
