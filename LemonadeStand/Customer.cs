using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{ // SOLID PRINCIPLE EXAMPLE - SINGLE RESPONSIBILITY
    class Customer
    {
        // member variables (HAS A)
        List<string> names;
        public string name;
        List<string> preferences;
        public string preference;


        // constructor (SPAWNER)
        public Customer()
        {
            names = new List<string> { "Light Yagami", "Kenshiro", "Guts", "Baki Hanma", "Edward Elric", "Inuyasha", "Akira Fudo", "Natsu Dragneel", "Yusuke Urameshi", "Korosensei", "Meliodas", "Ken Kaneki", "Ichigo Kurosaki", "Naruto Uzumaki", "Alucard", "Isaac Netero", "Eren Yaeger", "Mob", "Jotaro Kujo", "Simon", "Goku", "Tetsuo Shima", "Kyubey", "Zeno", "Saitama", "Asta", "Erza", "Deku", "All Might", "Senku", "Monkey", "Freeza", "Majin Boo", "Zara", "Boruto" };
            preferences = new List<string> { "PrefSunny", "PrefMostlySunny", "PrefPartlyCloudy/Sunny", "PrefMostlyCloudy", "PrefOvercast" };
            GenerateCustomerNames();
            GenerateWeatherPreferences();
        }
        //member methods(CAN DO)
        void GenerateCustomerNames()
        {
            Random rng = new Random();
            int indexValue = rng.Next(0, names.Count);
            name = names[indexValue];
        }
        void GenerateWeatherPreferences()
        {
            Random rng = new Random();
            int indexValue = rng.Next(0, preferences.Count);
            preference = preferences[indexValue];
        }
    }
}
