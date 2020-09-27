using System;
using System.Linq;
using System.Collections.Generic;
 
namespace LINQ
{
    class Program
    {
        static void Main()
        {
            //LINQ - Language Integrated Query
            //LINQ to objects
            int[] numbers = { 23, 34, 56, 12, 23, 89, 67, 10, 445, 32, 66, 69 };
            //fetch numbers which are greater than 50
            var result1 = numbers.Where(x => x > 50 && x < 70);

            //Using Sql query syntax - query expression
            var result2 = from x in numbers where x > 50 && x < 70 select x;
 
            string[] names = { "Anusha", "ram", "Ria", "shyam", "Ruby", "Rajesh"};
            var result3 = names.Where(y => y.Length > 3 && y.StartsWith("R"));
            var result4 = from y in names where y.Length > 3 && y.ToLower().StartsWith("r") select y;
 
            
            //foreach(var name  in result4)
           // {
               // Console.WriteLine(name);
           // }
 
             // projections
             var result5 = numbers.Select (x => x* x);

             //Ordering 
            var result6 = from num in numbers orderby num select num;

             // Partitioning
             var result7 = numbers.Skip(5).Take(5);
             
             //Quantifier
             var result8 = numbers.Any(x=> x% 2 == 0);
             var result9 = numbers.All(x=> x% 2 == 0);
             var result10 = numbers.Contains(34);

             var result11 = Enumerable.Range(1,100);
             var result12 = Enumerable.Repeat("Hello World", 10);
             foreach (var num in result12)
             {
                 Console.WriteLine(num);
             }
        }
    }
}

