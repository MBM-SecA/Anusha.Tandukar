using System.Linq;
using System;
public class ComplexType
{
    public void LearnLINQ()
    {
     var countries = Country.GetCountries();
            var asianCountries = from country in countries where country.Continent == "Asia" && country.IndependenceDay == default select country.Name;
            var EuCountries = from country in countries where country.Continent == "Europe" && country.Population  < 100000 select country.Name;
            Console.WriteLine("Asian Countries:");
            foreach(var country in asianCountries)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine("Countries in Europe which has population less than 100k:");
            foreach(var country in EuCountries)
            {
                Console.WriteLine(country);
            }
            //HW - Is there any african country in your collection?
            //HW - Print first 2 largest asian country 
}
}