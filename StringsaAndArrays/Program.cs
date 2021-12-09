using System;

namespace StringsaAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();
            int firstNameLength = firstName.Length;
            int lastNameLength = lastName.Length;

            if(firstNameLength > lastNameLength)
            {
                Console.WriteLine($"Eesnimi on pikem {firstNameLength} karakteri võrra");
            }
            else
            {
                Console.WriteLine($"Perekonnanimi on pikem {lastNameLength} karakteri võrra:");
            }
        }
    }
}
