using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {

            string randomChuckNorris;
            randomChuckNorris = GetRandomFromFile("chuck.txt");
            Console.WriteLine($"Today we are reading anecdote about Chuck Norris {randomChuckNorris}");
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }
        private static string GetRandomFromFile(string filename)

        {
            string filePath = $@"C:\Users\...\samples\chuck.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;


         }

    }
}
