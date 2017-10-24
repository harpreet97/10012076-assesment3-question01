using System;
using System.Collections.Generic;


namespace randomnumbergeneration
{
    class Program
    {
        static List<string> falconers = new List<string> { "Debbie", "Heidi", "Noel", "Melissa", "kirsten", "Koshy" };
        static List<string> falcons = new List<string> { "Hisan", "Ka Kite", "Siren", "Koa", "Stella", "Mojo" };
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("Flying for the WINGSPAN display today is:");

            Console.WriteLine("Falconer :"+ DisplayFalconers());
            Console.WriteLine("With Falcon :" + DisplayFalcons());

            Console.WriteLine("*****************************************");
        }

        static int GenerateRandomNumber(List<string> myList)
        {
            var rand = new Random();
            return rand.Next(1, myList.Count);

        }
        static string DisplayFalconers()
        {

            var selectedFalconers = falconers[GenerateRandomNumber(falconers)];


            return $"{selectedFalconers}";
        }
        static string DisplayFalcons()
        {
            var selectedFalcons = falcons[GenerateRandomNumber(falcons)];

            return $"{selectedFalcons}";
        }
    }
}