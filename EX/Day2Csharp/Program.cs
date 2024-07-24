//// See https://aka.ms/new-console-template for more information


using CSharpEx.Day2;

Console.WriteLine("Hello, World!");

//Ex1
nameage ex2 = new nameage();
while (true)
{
    ex2.getDetails();
    Console.WriteLine("Do you want to enter another?(Y/N)");
    string inp = Console.ReadLine();
    if (inp.Equals("y") || inp.Equals("Y"))
    {
        continue;
    }
    else
    {
        break;
    }
}

//Ex2
ClassPlay player1 = new ClassPlay("Pavi", 22, 12, "swimming", "yes");
ClassPlay player2 = new ClassPlay("Suresh", 29, 10, "cricket", "no");
ClassPlay player3 = new ClassPlay("Ravi", 39, 19, "football", "yes");

player1.displayDetails();
player2.displayDetails();
player3.displayDetails();

//Ex3
ProcessTestScores ts = new ProcessTestScores();
ts.GetTestScores();
ts.GetHighestScore();
ts.GetLowestScore();
ts.GetAverageScore();

//Ex-4

FavoriteMovies fav = new FavoriteMovies();
fav.getMovies();
Console.WriteLine("ENTER THE SEARCH INPUT TO SEARCH PARTIAL");
string input = Console.ReadLine();
fav.search(input);
Console.WriteLine("ENTER THE SEARCH INPUT TO SEARCH EXACT");
string input2 = Console.ReadLine();
fav.exactsearch(input2);

//Ex-5

Person p1 = new Person();

while (true)
{
    Console.WriteLine("Enter name age and gender");
    string name = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());
    string gender = Console.ReadLine();
    p1.addPerson(new Person(name, age, gender));
    Console.WriteLine("Press Y/N to stop entering");
    string inpt = Console.ReadLine();
    if (inpt.Equals("N") || inpt.Equals("n"))
    {
        break;
    }

}


bool flag = true;
do
{
    Console.WriteLine("Enter the option\n 1.Display all Person\n 2.Display person based on age \n 3.Display person based on gender");
    int option = int.Parse(Console.ReadLine());
    switch (option)
    {

        case 1:
            Console.WriteLine("Display all person");
            p1.displayAll();
            break;

        case 2:
            Console.WriteLine("Display person based on age. enter age1 and age2");
            int age1 = int.Parse(Console.ReadLine());
            int age2 = int.Parse(Console.ReadLine());
            p1.displayAgeBased(age1, age2);
            break;

        case 3:
            Console.WriteLine("Display person based on gender");
            string gender = Console.ReadLine();

            p1.displayGenderBased(gender);
            break;
        default:
            Console.WriteLine("Exit");
            flag = false;
            break;
    }

} while (flag);

//Ex-6
TimeMath t = new TimeMath();
Console.WriteLine("Enter time");
TimeOnly t1 = TimeOnly.Parse(Console.ReadLine());
Console.WriteLine("Enter minutes");
int min = int.Parse(Console.ReadLine());
t.addMin(t1, min);



