using System;
using System.Threading;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler1 = null;
            ChocolateBoiler boiler2 = null;

            Thread t1 = new Thread(() =>
            {
                boiler1 = ChocolateBoiler.GetInstance();
                Console.WriteLine("Thread 1 kreeg instantie: " + boiler1);
            });

            Thread t2 = new Thread(() =>
            {
                boiler2 = ChocolateBoiler.GetInstance();
                Console.WriteLine("Thread 2 kreeg instantie: " + boiler2);
            });

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            // Controleer of het om hetzelfde object gaat
            if (ReferenceEquals(boiler1, boiler2))
            {
                Console.WriteLine("Beide threads hebben dezelfde instantie gekregen.");
            }
            else
            {
                Console.WriteLine("Verschillende instanties: singleton is niet thread safe.");
            }
        }
    }
}
