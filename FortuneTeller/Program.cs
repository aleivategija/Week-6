using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] predictions = { "win a million", "fall in love", "buy youtube premium", "join the dark side for cookies" };

            Random rnd = new Random();
            int future = rnd.Next(0, predictions.Length);

            Console.WriteLine($"Your prediction is following: {predictions[future]}");



        }
    }
}
