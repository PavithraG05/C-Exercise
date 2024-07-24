using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEx.Day2
{
    internal class ClassPlay
    {
        string playerName;
        int age;
        int years_of_playing;
        string sport_name;
        string currently_playing;

        public ClassPlay(string playerName, int age, int years_of_playing, string sport_name, string currently_playing)
        {
            this.playerName = playerName;
            this.age = age;
            this.years_of_playing = years_of_playing;
            this.sport_name = sport_name;
            this.currently_playing = currently_playing;
        }

        public void displayDetails()
        {
            Console.WriteLine($"{playerName} of age:{age} has been playing sport:{sport_name} for {years_of_playing}years and is he/she currently_playing?:{currently_playing}. ");
        }
    }
}
