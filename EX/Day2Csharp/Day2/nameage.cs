
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEx.Day2
{
    internal class nameage
    {
        string name = "";
        int age;
        public void getDetails()
        {
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age as of dec 31");
            age = int.Parse(Console.ReadLine());
            calculateAge();
        }

        public void calculateAge()
        {
            var myDate = DateTime.Now;
            var yob = myDate.AddYears(-age);
            Console.WriteLine($"{name} was born in {yob.Year}");

        }

       
    }
}


