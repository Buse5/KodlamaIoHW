using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidatıonManager());
            gamerManager.Add(new Gamer {Id=1, BirdhYear=1999,FirstName="Buse"});
            Console.WriteLine("Hello World!");
        }
    }
}
