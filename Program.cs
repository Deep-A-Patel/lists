using System;
using System.Collections.Generic;


namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////// Practice: Planet and Spaceships ///////////////////// 

            //Add() Jupiter and Saturn at the end of the list.
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            //Create another List that contains that last two planet of our solar system.
            List<string> lastPlanet = new List<string>() { "Neptune", "Uranus" };
            //Combine the two lists by using AddRange().
            planetList.AddRange(lastPlanet);
            //Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            //Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");
            planetList.ForEach(planet => Console.WriteLine(planet));
            //Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
            List<string> rockyPlanets = planetList.GetRange(2, 2);
            rockyPlanets.ForEach(planet => Console.WriteLine($"rocky planets: {planet}"));
            //Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            planetList.Remove("Pluto");
            planetList.ForEach(planet => Console.WriteLine(planet));


            //////////////// Practice: Random Numbers ////////////////





        }
    }
}