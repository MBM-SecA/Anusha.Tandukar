using System.Linq;
using System.Collections.Generic;
using System;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            // LINQ - Language Integrated Query

            int[] numbers = { 23,34, 56, 35, 67, 10,71 };

            // Fetch numbers which are gretaer than 50 and less than 70

            // Using method syntax - Lambda expression
            var result1 = numbers.Where(x => x>50 && x < 70);

            //Using sql query syntax - query expression
            var result2 = from x in numbers where x >50 && x < 70 select x;

            string[] names = {"anusha", "ram", "sita",  "hari", "rita", "rhea", "Rosy"};

            // Names having length > 3 and starts with letter 'R'

            var result3 = names.Where(y => y.Length > 3 && y.StartsWith("r"));
            var result4 = from y in names where y.Length > 3 && y.ToUpper().StartsWith("R") select y;
            foreach(var name in result4)
            {
                Console.WriteLine(name);
            }
            
            
           var countries = Country.GetCountries();
           var asianCountries = from country in countries where country.Continent == "Asia" select country;
        }
    }
}

