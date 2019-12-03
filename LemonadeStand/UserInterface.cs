using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    static class UserInterface
    {
        public static void DisplayForecast(Day days, Weather weather)
        {
            Console.WriteLine($"{days.weather} Day Forecast");
            Console.WriteLine("- - - - - - - - - - - - -\n");
            for (int i = 0; i < 7 ; i++)
            {
                string dayLabel = i == 0 ? "TODAY: " : $"{i} DAYS OUT: ";
                Console.WriteLine($"{dayLabel} A high of {days.weather.ActualTemp}°F and will be {days.weather.Condition}.");
            }
            return;
        }

        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");
                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }
            return quantityOfItem;
        }
        public static void DisplayWalletBalance(Player player)
        {
            Console.WriteLine($"{player} your current bank account balance is ${player.wallet}\n");
        }
    }
}
