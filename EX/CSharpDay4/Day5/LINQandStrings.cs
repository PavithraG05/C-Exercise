using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay5.Day5
{
    public class LINQandStrings
    {
        private List<string> strings = new List<string>() { "apple","mango","orange","watermelon","muskmelon","lemon",
          "carrot","beetroot","ladiesfinger","cabbage","potato","bitter guard","bottle guard","strawberry","cherry","banana","blueberry","guava","Cauliflower"};

        public void displayList()
        {
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }

        public void startwithb()
        {
            IEnumerable<string> query = from str in strings where str.StartsWith('b') || str.StartsWith('B') select str;
            displayList(query);
        }

        public void containberry()
        {
            IEnumerable<string> query = from str in strings where str.Contains("berry") select str;
            displayList(query);
        }

        public void startswithAM()
        {
            IEnumerable<string> query = from str in strings where str.StartsWithAny("ABCDEFGHIJKLMabcdefghijklm".ToCharArray()) select str;
            displayList(query);
        }

        public void countstartswithNZ()
        {
            int count = (from str in strings where str.StartsWithAny("NOPQRSTUVWXYZnopqrstuvwxyz".ToCharArray()) select str).Count();
            Console.WriteLine(count);
            
        }

        public void longString()
        {
            List<string> query = (from str in strings orderby str.Length descending select str).ToList();
            //Console.WriteLine(query);
            displayList(query);

        }
        public void displayList(IEnumerable<string> query)
        {
            foreach (string s in query)
            {
                Console.WriteLine(s);
            }
        }


    }

    public static class StringExtensions
    {
        public static bool StartsWithAny(this string str, char[] characters)
        {
            foreach (char ch in characters)
            {
                if (str.StartsWith(ch.ToString()))
                    return true;
            }
            return false;
        }
    }
}
