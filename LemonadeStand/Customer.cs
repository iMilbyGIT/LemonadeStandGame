using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        // member variables (HAS A)
        List<string> names;
        public string name;
        List<string> preferences;
        public string preference;
        public string weatherPreferenceProfile;


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
         //   names = new List<string> {"Light Yagami", "Kenshiro", "Guts", "Baki Hanma", "Edward Elric", "Inuyasha", "Akira Fudo", "Natsu Dragneel", "Yusuke Urameshi", "Korosensei", "Meliodas", "Ken Kaneki", "Ichigo Kurosaki", "Naruto Uzumaki", "Alucard", "Isaac Netero", "Eren Yaeger", "Mob", "Jotaro Kujo", "Simon", "Goku", "Tetsuo Shima", "Kyubey", "Zeno", "Saitama", "Asta", "Erza", "Deku", "All Might", "Senku", "Monkey", "Freeza", "Majin Boo", "Zara", "Boruto"};
            Random rng = new Random();
            int indexValue = rng.Next(0, names.Count);
            name = names[indexValue];
        }
        void GenerateWeatherPreferences()
        {
         //   preferences = new List<string> { "PrefSunny", "PrefMostlySunny", "PrefPartlyCloudy/Sunny", "PrefMostlyCloudy", "PrefOvercast" };
            Random rng = new Random();
            int indexValue = rng.Next(0, preferences.Count);
            preference = preferences[indexValue];
        }
        void AssignWeatherPreference()
        {
         //   Random rng = new Random();
         //   weatherPreferenceProfile =  + rng.Next();
        }
    }
}
