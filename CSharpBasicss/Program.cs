
using System;
using System.IO;
using System.Linq;
using LearnCollections;
public class Program
{
    static  void Main()
    //{
        //FileIO fileIO =  new FileIO();
        //fileIO.LearnDirectories();
    //}

    {
      string countriesText = File.ReadAllText("Countries.txt");
      string[] countries = countriesText.Split("\n\r");

      var countriesWithNIntial = countries.Select(x => x.StartsWith("N"));

      foreach (var country in countriesWithNIntial)
      {
        Console.WriteLine(country);
      }
    }
}