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
        public int ActualTemp;
        public int ForecastTemp;
        public List<string> PossibleConditions;

        // constructor (SPAWNER)
        public Weather()
        {
            PossibleConditions = new List<string> { "Sunny", "Mostly Sunny", "Partly Cloudy/Sunny", "Mostly Cloudy", "Overcast" };
            GenerateCondition();
            GenerateTemp();
            ActualTempurature();
        }

        // member methods (CAN DO)
        void GenerateTemp()
        {
            Random rng = new Random();
            ForecastTemp = rng.Next(32, 100);   
        }
        void GenerateCondition()
        {
            Random rng = new Random();
            int indexValue = rng.Next(0, PossibleConditions.Count);
            Condition = PossibleConditions[indexValue];
        }
        void ActualTempurature()
        {
            Random rng = new Random();
            ActualTemp = ForecastTemp + rng.Next(0, 5);
        }
    }
}
