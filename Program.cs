using System;

namespace final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n                     Hero's Journey Generator\n");
            Console.WriteLine("Be sure to have People.txt, Actions.txt and Words.txt in the same directory");
            Console.WriteLine("---------------------------------------------------------------------------");

            bool running = true;

            while(running)
            {
                Console.WriteLine("Create journey(c), Source Code(s), Exit(e)");
                var keyInput = Console.ReadKey().Key;

                //while no existing input
                while(keyInput != ConsoleKey.C && keyInput != ConsoleKey.S && keyInput != ConsoleKey.E)
                {
                    Console.Clear();
                    Console.WriteLine("\nType the letter corresponding to the desired commands");
                    Console.WriteLine("Create journey(c), Source Code(s), Exit(e)");
                    keyInput = Console.ReadKey().Key;
                }

                if(keyInput == ConsoleKey.C)
                {
                    Console.WriteLine("\nTo ve implemented");
                    running = false;
                }

                else if(keyInput == ConsoleKey.S)
                {
                    Console.WriteLine("\nTo ve implemented");
                    running = false;
                }

                else if(keyInput == ConsoleKey.E)
                {
                    running = false;
                }
            }
            //Exit. Running == false
            Console.WriteLine("\nExit");
        }
    }
}
