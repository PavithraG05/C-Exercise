using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEx.Day2
{
    internal class Person
    {
        string name;
        int age;
        string gender;
        List<Person> list;

        public Person()
        {
            list = new List<Person>();
        }
        public Person(String name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public void addPerson(Person person)
        {
            list.Add(person);
        }

        public void displayAll()
        {
            Console.WriteLine("Display all person details");
            foreach (Person p in list)
            {
                Console.WriteLine($"{p.name} {p.age} {p.gender}");
            }

        }

        public void displayGenderBased(string gender)
        {
            Console.WriteLine($"Display based on Gender:{gender}");
            foreach(Person p in list)
            {
                if (p.gender.Equals(gender))
                {
                    //Console.WriteLine(p);
                    Console.WriteLine($"{p.name} {p.age} {p.gender}");

                }
            }
        }

        public void displayAgeBased(int age1, int age2)
        {
            Console.WriteLine($"Display based on age range:{age1}to{age2}");
            foreach (Person p in list)
            {
                if (p.age >= age1 && p.age <= age2)
                {
                    //Console.WriteLine(p);
                    Console.WriteLine($"{p.name} {p.age} {p.gender}");

                }
            }
        }
    }
}
