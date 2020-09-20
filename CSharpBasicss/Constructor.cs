using System;
namespace AllAboutClasses
{
    public class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public readonly double AREA = 4323.76;
        public static readonly bool IsOnEarth = true;
        // Instance Consructors
        //Default constructor
        public Country()
        {

        }
        // Parameterized constructor
        public Country(string name)
        {
            Name = name;
        }
        public Country(string name, int population, double area)
        {
            Name = name;
            Population = population;
            AREA = area;
        }
        // Static Constructor
        static Country()
        {
           IsOnEarth = true;
        }
        ~Country()
        {
            Console.Write("I am dying..");
        }
    }
    public class Demo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country country2 = new Country("Nepal");

        }
    }
}