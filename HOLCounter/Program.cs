using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!".ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < helloWorld.Length; i++) 
            {
                if (helloWorld[i] == 'h')
                {
                    hCounter++;
                }
            }

            for (int b = 0; b < helloWorld.Length; b++)
            {
                if (helloWorld[b] == 'o')
                {
                    oCounter++;
                }
            }

            for (int c = 0; c < helloWorld.Length; c++)
            {
                if (helloWorld[c] == 'l')
                {
                    lCounter++;
                }
            }

            Console.WriteLine($"Lauses 'Hello World!' on {hCounter} 'h' t2hte, {oCounter} 'o' t2hte ja {lCounter} 'l' t2hte.");

        }
    }
}
