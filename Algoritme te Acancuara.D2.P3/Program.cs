using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritme_te_Acancuara.D2.P3
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = AlbertoTheAviator.MaximumFlights(10, new[] { 10 }, new[] { 0 });
            Console.WriteLine($"0) f=10 d=[10], r=[0] => {result}");
            result = AlbertoTheAviator.MaximumFlights(10, new[] { 8, 4 }, new[] { 0, 2 });
            Console.WriteLine($"1) f=10 d=[8,4], r=[0,2] => {result}");
            result = AlbertoTheAviator.MaximumFlights(12, new[] { 4, 8, 2, 1 }, new[] { 2, 0, 0, 0 });
            Console.WriteLine($"2) f=12 d=[4,8,2,1], r=[2,0,0,0] => {result}");
            result = AlbertoTheAviator.MaximumFlights(9, new[] { 4, 6 }, new[] { 0, 1 });
            Console.WriteLine($"3) f=9 d=[4,6], r=[0,1] => {result}");
            result = AlbertoTheAviator.MaximumFlights(100, new[] { 101 }, new[] { 100 });
            Console.WriteLine($"4) f=100 d=[101], r=[100] => {result}");
            result = AlbertoTheAviator.MaximumFlights(1947, new[] { 2407, 2979, 1269, 2401, 3227, 2230, 3991, 2133, 3338, 356, 2535, 3859, 3267, 365 }, new[] { 2406, 793, 905, 2400, 1789, 2229, 1378, 2132, 1815, 355, 72, 3858, 3266, 364 });
            Console.WriteLine($"5) f=1947 d=[2407,2979,1269,2401,3227,2230,3991,2133,3338,356,2535,3859,3267,365], r=[2406,793,905,2400,1789,2229,1378,2132,1815,355,72,3858,3266,364] => {result}");
            Console.ReadLine();
        }
    }
}
