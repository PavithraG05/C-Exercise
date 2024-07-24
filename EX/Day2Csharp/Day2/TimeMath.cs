using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEx.Day2
{
    internal class TimeMath
    {
        public void addMin(TimeOnly t1, int min)
        {
            Console.WriteLine($"Adding minutes:{min} to time:{t1} = {t1.AddMinutes(min)}");
        }
    }
}
