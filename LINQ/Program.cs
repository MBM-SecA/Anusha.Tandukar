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
 
            var countries = Country.GetCountries();
            var EuCountries = from country in countries where country.Continent == "Europe" && country.Population  < 100000 select country.Name;
            foreach(var country in EuCountries)
            {
                Console.WriteLine(country);
            }
 
//List countries in Europe which has population less than 100k.
//List countries in Asia which are not ever invaded.
        }
    }
}

