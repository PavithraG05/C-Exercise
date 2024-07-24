using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpDay5.Day5
{
    public class Person
    {
        private string Name { get; set; }
        private string Gender { get; set; }
        private int Age { get; set; }
        private string Hometown {  get; set; }

        public List<Person> persn = new List<Person>();

        public Person()
        {

        }
        public Person(string name, string gender, int age, string hometown)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Hometown = hometown;
        }
        public void getPersons()
        {
            persn.Add(new Person("Pavi","Female",21,"Dgl"));
            persn.Add(new Person("Ravi", "Male", 23, "Dgl"));
            persn.Add(new Person("Kevin", "Male", 33, "Mdu"));
            persn.Add(new Person("Prasanna", "Male", 21, "Dgl"));
            persn.Add(new Person("Suresh", "Male", 31, "Chen"));
            persn.Add(new Person("Bhavani", "Female", 31, "Chen"));
            persn.Add(new Person("Nivi", "Female", 21, "Chen"));
            persn.Add(new Person("Thara", "Female", 11, "Chen"));
            persn.Add(new Person("Sita", "Female", 61, "Dgl"));
            persn.Add(new Person("Kannan", "Male", 51, "Dgl"));

        }

        public void displayAll()
        {
            foreach (Person person in persn)
            {
                Console.WriteLine($"{person.Name}");
                Console.WriteLine($"{person.Gender}");
                Console.WriteLine($"{person.Age}");
                Console.WriteLine($"{person.Hometown}");
                Console.WriteLine($"---------------");
                Console.WriteLine($"");



            }
        }

        public void displayAll(List<Person> p)
        {
            foreach (Person person in p)
            {
                Console.WriteLine($"{person.Name}");
                Console.WriteLine($"{person.Gender}");
                Console.WriteLine($"{person.Age}");
                Console.WriteLine($"{person.Hometown}");
                Console.WriteLine($"---------------");
                Console.WriteLine($"");



            }
        }

        public void displayAll(List<string> towns)
        {
            foreach (string home in towns)
            {
                Console.WriteLine($"{home}");
               
            }
        }

        public void MaleUnder25()
        {
            List<Person> Males = (from person in persn where person.Age <= 25 && person.Gender == "Male" select person).ToList();
            displayAll(Males);
        }

        public void distinctHometown()
        {
            List<string> home = (from person in persn orderby person.Hometown select person.Hometown).Distinct().ToList();
            displayAll(home);
        }

        public void sortHometown()
        {
            List<Person> query = (from person in persn orderby person.Hometown, person.Name select person).ToList();
            displayAll(query);
        }

        public void avgAge()
        {
            double menAvgAge = (from person in persn where person.Gender == "Male" select person.Age).Average();
            Console.WriteLine($"Men avg age:{menAvgAge}");
            double womenAvgAge = (from person in persn where person.Gender == "Female" select person.Age).Average();
            Console.WriteLine($"Women avg age:{womenAvgAge}");
        }

        public void groupHometown()
        {
            foreach (var line in persn.GroupBy(person => person.Hometown)
                                        .Select(group => new {
                                            Metric = group.Key,
                                            Count = group.Count()
                                        })
                                        .OrderBy(x => x.Metric))
            {
                Console.WriteLine("{0} {1}", line.Metric, line.Count);
            }
        }
    }
}
