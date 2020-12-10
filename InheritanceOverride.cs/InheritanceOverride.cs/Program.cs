using System;

namespace InheritanceOverride.cs
{
    class Program
    {
        public static void Main(string[] args)
        {
            //4.Create the instance of the “CityDerivedClass” class in the main class, access the methods  and print the values
            var ny = new CityDerivedClass("New York", 400000, 800000);
            Console.WriteLine("The land area per capita is: {0}", ny.LandAreaPerCapita());
        }
    }

    //Create a class as “CityBaseClass”
    abstract class CityBaseClass
    {
        public abstract int LandAreaPerCapita();

    }

    //Create child class as “CityDerivedClass”
    class CityDerivedClass : CityBaseClass
    {
        string name;
        int population;
        int area;

        public CityDerivedClass(string n, int p, int a)
        {
            this.name = n;
            this.population = p;
            this.area = a;
        }

        public override int LandAreaPerCapita()
        {
            return area / population;

        }

    }

}



