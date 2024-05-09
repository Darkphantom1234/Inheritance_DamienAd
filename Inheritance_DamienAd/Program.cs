using System;

namespace Inheritance_DamienAd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FPS myFPS = new FPS("E", "R6");

            Console.WriteLine(myFPS.Describe());
            myFPS.PlayGame();

            FPS csGo = new FPS("M", "CS:Go");
            Console.WriteLine(csGo.Describe());
            csGo.PlayGame();

        }
    }
}