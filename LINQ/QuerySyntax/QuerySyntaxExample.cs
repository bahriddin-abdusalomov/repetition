using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.QuerySyntax
{
    public class QuerySyntaxExample
    {
        public static void Run()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };

            //Where

            var evenNumbers = from number in list where number % 2 == 0 select number;

            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
