using System.Linq;
using System;
public class ComplexType
{
    public void LearnLINQ()
    {
    // var countries = Country.GetCountries();
           // var asianCountries = from country in countries where country.Continent == "Asia" && country.IndependenceDay == default select country.Name;
            //var EuCountries = from country in countries where country.Continent == "Europe" && country.Population  < 100000 select country.Name;
           // Console.WriteLine("Asian Countries:");
            //foreach(var country in asianCountries)
            //{
              //  Console.WriteLine(country);
            //}
           // Console.WriteLine("Countries in Europe which has population less than 100k:");
           // foreach(var country in EuCountries)
           // {
               // Console.WriteLine(country);
           // }
            var countries = Country.GetCountries();
            // HW - Is there any African country in your country collection
            var africanMember = countries.Any (x=> x.Continent=="Africa");
            if( africanMember)
                Console.WriteLine("List contains african member");
            else
                 Console.WriteLine("List doesn't contain african member");
        //Hw- Print First 2 largest asian country names.
        var asianCountries = from country in countries where country.Continent == "Asia" select country;
        var areaOrderedList = asianCountries.OrderByDescending( x => x.Area);
        var firstTwoLargestCountry = areaOrderedList.Take(2);
         Console.WriteLine("Two largest members are:");
        foreach (var item in firstTwoLargestCountry)
            {
                Console.WriteLine(item.Name);
            }
}
}