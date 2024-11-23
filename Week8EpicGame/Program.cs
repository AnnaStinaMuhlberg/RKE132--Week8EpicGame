using System;
using System.IO;

namespace DataFromFile
{
    class Program
{
    static void Main(string[] args)
    {
            string filePathHeroes = @"/Users/anna-stina/Documents/Tehnikakõrgkool/2.kursus/C#/App/Week8EpicGame/data/heroes.txt";
            string filePathVillains = @"/Users/anna-stina/Documents/Tehnikakõrgkool/2.kursus/C#/App/Week8EpicGame/data/villains.txt";

            string[] heroes = File.ReadAllLines(filePathHeroes);
            string[] villains = File.ReadAllLines(filePathVillains);

            string[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword", "lego brick" };

            string hero = GetRandomValueFromArray(heroes);
            string heroWeapon = GetRandomValueFromArray(weapon);
            Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

            string villain = GetRandomValueFromArray(villains);
            string villainWeapon = GetRandomValueFromArray(weapon);
            Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the world!");



            static string GetRandomValueFromArray(string[] someArray)
            {
                Random rnd = new Random();
                int randomIndex = rnd.Next(0, someArray.Length);
                string randomStringFromArray = someArray[randomIndex];
                return randomStringFromArray;
            }

            //foreach (string element in dataFromFile)
            //{
            //    Console.WriteLine(element);
            //}
        }
}
}







//string[] heroes = { "Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo" };
//string[] villains = { "Voldemort", "Darth Vader", "Dracula", "Joker", "Sauron" };







//string[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword", "lego brick" };


//string hero = GetRandomValueFromArray(heroes);
//string heroWeapon = GetRandomValueFromArray(weapon);
//Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

//string villain = GetRandomValueFromArray(villains);
//string villainWeapon = GetRandomValueFromArray(weapon);
//Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the world!");



//static string GetRandomValueFromArray(string[] someArray)
//{
//  Random rnd = new Random();
//   int randomIndex = rnd.Next(0, someArray.Length);
//  string randomStringFromArray = someArray[randomIndex];
//  return randomStringFromArray;
//}