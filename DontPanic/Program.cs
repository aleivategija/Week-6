using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            string panic = "Don't Panic";

            panic = panic.Replace('o', '0');
            panic = panic.Replace('a', '4');
            Console.WriteLine(panic);
        }
    }
}
