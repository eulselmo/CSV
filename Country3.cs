using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.IO;

class CoutriesOfTheWorld
{

    public static void Main()
    {
        String[] args = Environment.GetCommandLineArgs();
        if (args.Length == 1)
        {
            Console.WriteLine("There are no command line arguments.");
            return;
        }

        String theContinent = args[1];

        IEnumerable<Country> Countries = GetCountries();
        Console.WriteLine("The number of countries: {0}", Countries.Count());

        var result = from c in Countries
                     where c.Continent == theContinent && c.Population / c.Area > 100
                     orderby c.Population / c.Area descending
                     select c;

        foreach (Country c in result)
        {
            Console.WriteLine("{0} {1} {2} {3}", c.Name, c.Population, c.Area, c.Population / c.Area);
        }

    }


    public class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }
        public int Population { get; set; }
        public int Area { get; set; }
        public double Gdp2010 { get; set; }
    }


    public static IEnumerable<Country> GetCountries()
    {
        var countries = System.IO.File.ReadAllLines("data.csv");


        return (from line in countries
                let fields = line.Split(',')

                select new Country()
                {
                    Name = fields[0].Trim(),
                    Continent = fields[1].Trim(),
                    Population = Convert.ToInt32(fields[2].Trim()),
                    Area = Convert.ToInt32(fields[3].Trim()),
                    Gdp2010 = Convert.ToDouble(fields[6].Trim())
                });

    }

}

