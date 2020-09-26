using System;
using System.Collections.Generic;
public class Country
{
    public string Name { get; set;}
    public string Continent { get; set;}
    public double Area { get; set;}
    public long Population { get; set;}
    public DateTime IndependenceDay { get; set;}
 
    
 
    public Country(string n, string c, double a,long p, DateTime i = default)
    {
        Name=  n;
        Continent = c;
        Area = a;
        Population = p;
        IndependenceDay = i;
     }
 
    public static List<Country> GetCountries()
    {
            Country c1 = new Country( "Nepal", "Asia", 2121212.121, 334244353534);
            Country c2 = new Country( "India", "Asia", 2121212.121, 334244353534);
            Country c3 = new Country( "Germany", "Europe", 2121212.121, 334244353534);
            Country c4 = new Country( "USA", "North America", 2121212.121, 334244353534);
            Country c5 = new Country( "Russia", "Europe", 2121212.121, 334244353534);
            Country c6 = new Country( "Sweden", "Europe", 2121212.121, 334244353534);
            Country c7 = new Country( "Ukraine", "Europe", 2121212.121, 334244353534);
            Country c8 = new Country( "France", "Europe", 2121212.121, 334244353534);
            Country c9 = new Country( "Spain", "Europe", 10000, 334244353534);
            Country c10 = new Country( "Norway", "Europe", 2121212.121, 334244353534);
            Country c11= new Country( "Cyprus", "Europe", 2121212.121, 1445);
            Country c12= new Country( "Finland", "Europe", 2121212.121, 334244353534);
            Country c13= new Country( "Poland", "Europe", 2121212.121, 1234);
            Country c14= new Country( "Italy", "Europe", 212.121, 334244353534);
            Country c15= new Country( "Uk", "Europe", 2122.121, 334244353534);
            Country c16= new Country( "Romania", "Europe", 2121212.121, 334244353534);
            Country c17= new Country( "Greece", "Europe", 2121212.121, 334244353534);
            Country c18= new Country( "Austria", "Europe", 212.121, 334244353534);
            Country c19= new Country( "Serbia", "Europe", 2121212.121, 7798);
            Country c20= new Country( "Croatia", "Europe", 2121212.121, 3345);
 
            var countries = new List<Country> {c1,c2,c3,c4,c5,c6,c7,c8,c9,c10,c11,c12,c13,c14,c15,c16,c17,c18,c19,c20};
 
            return countries; 
    }
 
}