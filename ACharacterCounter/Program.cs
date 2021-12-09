using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi: ");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();

            Console.WriteLine(fullName);

            int aCounter = 0;

            for(int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a')
                {
                    aCounter++;
                }
            }

            if (aCounter != 1)
            {
                Console.WriteLine($"Sinu t2isnimes on {aCounter} 'a' t2hte.");
            }
            else
            {
                Console.WriteLine($"Sinu t2isnimes on {aCounter} 'a' t2ht.");
            }

        }
    }
}
