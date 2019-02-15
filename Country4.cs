//Hacer un programa que tome la asignatura, el profesor y el grado (cada uno tiene un valor) y los ordene por asignatura.
using System;
using System.Linq;
using System.Collections.Generic;

// LINQ Query Syntax examples

public class CoutriesOfTheWorld
{
    public static void Main()
    {
        String[] args = Environment.GetCommandLineArgs();
        if (args.Length == 1){
            Console.WriteLine("There are no command line arguments.");
            return;
        }        
        String theContinent = args[1];
        IEnumerable<Country> Countries = GetCountries();
        
        Console.WriteLine("----------------------------------------");
        
        var result = from s in Countries
            where s.Continent == theContinent && s.Population / s.Area > 70
            orderby s.Population/s.Area descending
            select s; 


            long total = 0;
            foreach (Country s in result)
            {
                 total += s.Population;
            }
            
            foreach (Country s in result)
            {
                 Console.WriteLine("{0, -25} {1, 15} ", s.Name, s.Population);
            }
        
        Console.WriteLine("----------------------------------------");


        Console.WriteLine("----------------------------------------");
        
        var result2 = from s in Countries
            where s.Continent == theContinent
            group s by s.Continent into groups
            select new
            {
                Continent = groups.Key,
                AveragePopulation = groups.Sum(s => s.Population),
            }; 
            
            foreach (Country s in result2)
            {
                 Console.WriteLine("{0, -25} {1, 15} ", s.Continent, s.AveragePopulation);
            }
        
        Console.WriteLine("----------------------------------------");
    
        //-----------------------------------
    
    }


public class Country
        {
            public string Name { get; set; }
            public string Continent { get; set; }
            public long Population { get; set; }
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
                    Population = Convert.ToInt64(fields[2].Trim()),
                    Area = Convert.ToInt32(fields[3].Trim()),   
                    Gdp2010 = Convert.ToDouble(fields[6].Trim())
                });
               
    }

}