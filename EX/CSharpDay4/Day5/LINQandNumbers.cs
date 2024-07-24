using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CSharpDay5.Day5
{
    public class LINQandNumbers
    {
        private int[] arr = new int[50];

        Random randNum = new Random();
        int Min = 1;
        int Max = 10000;
        public LINQandNumbers()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randNum.Next(Min, Max);
            }
        }

        public void ascendingOrder()
        {
            IEnumerable<int> query = from ar in arr
                                        orderby ar
                                        select ar;

            //foreach (int ar in query)
            //{
            //    Console.WriteLine(ar);
            //}
            Display(query);
        }

        public void under500Desc()
        {
            IEnumerable<int> query = from ar in arr orderby ar descending where ar < 500 select ar;
            Display(query);

        }

        public void evenNumber()
        {
            IEnumerable<int> query = from ar in arr where ar %2==0 select ar;
            Display(query);

        }

        public void minmaxavg()
        {
            int min = arr.Min(arr => arr);
            Console.WriteLine($"Min: {min}");
            int max = arr.Max(arr => arr);
            Console.WriteLine($"Max: {max}");
            int total = arr.Sum(arr => arr);
            Console.WriteLine($"Total: {total}");
        }

        public void Display()
        {
            foreach (int ar in arr)
            {
                Console.WriteLine(ar);
            }
        }

        public void Display(IEnumerable<int> query)
        {
            foreach (int ar in query)
            {
                Console.WriteLine(ar);
            }
        }

        

    }
}
