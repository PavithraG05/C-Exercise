using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEx.Day2
{
    internal class ProcessTestScores
    {
        int[] testscores = new int[6];

        public void GetTestScores()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter the testscore");
                int testscore = int.Parse(Console.ReadLine());
                testscores[i] = testscore;
            }
        }

        public void GetHighestScore()
        {
            Array.Sort(testscores);
            Console.WriteLine($"Highest Testscore:{testscores[testscores.Length-1]}");
        }

        public void GetAverageScore()
        {
            int total = 0;
            foreach(int i in testscores)
            {
                total += i;
         
            }
            int avg = total / testscores.Length;
            Console.WriteLine($"Average Testscore:{avg}");

        }

        public void GetLowestScore()
        {
            //Array.Sort(testscores);
            Console.WriteLine($"Lowest Testscore:{testscores[0]}");
        }
    }
}
