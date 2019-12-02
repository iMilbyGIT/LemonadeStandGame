using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        // member variable (HAS A)
        Player player;
        List<Day> days;
        int currentDay;
        Store store;
        

        // constructor (SPAWNER)
        public Game()
        {
            days = new List<Day>();
            player = new Player();
            store = new Store();
            BuildDays();
            RunGame();
        }
       

        // member methods (CAN DO)
        public void BuildDays()
        {
            for (int i = 0; i < 7; i++)
            {
                Day day = new Day();
                days.Add(day);
            }
        }
        public void RunGame()
        {
            for (int i = 0; i < 7; i++)
            {
                days[i].RunDay(player, store);
            }
        }

    }   
}
