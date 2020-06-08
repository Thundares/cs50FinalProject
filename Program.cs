using System;
using MainSource;

namespace final
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print Title
            Console.WriteLine("\n                     Hero's Journey Generator\n");
            Console.WriteLine("Be sure to have People.txt, Actions.txt and Words.txt in the same directory");
            Console.WriteLine("---------------------------------------------------------------------------");

            // Auxiliar variables
            bool running = true;

            // Main loop
            while(running)
            {
                Console.WriteLine("Create journey(c), Source Code(s), Exit(e)");
                var keyInput = Console.ReadKey().Key;

                // While no existing input
                while(keyInput != ConsoleKey.C && keyInput != ConsoleKey.S && keyInput != ConsoleKey.E)
                {
                    Console.Clear();
                    Console.WriteLine("\nType the letter corresponding to the desired command");
                    Console.WriteLine("Create journey(c), Source Code(s), Exit(e)");
                    keyInput = Console.ReadKey().Key;
                }

                // Execute program
                if(keyInput == ConsoleKey.C)
                {
                    Generator.Execute();
                    running = false;
                }

                // Show the link to github
                else if(keyInput == ConsoleKey.S)
                {
                    Console.WriteLine("\nOur repository on Github is: https://github.com/Thundares/cs50FinalProject");
                    Console.WriteLine("Feel free to fork us.");
                    running = false;
                }

                // Just quit
                else if(keyInput == ConsoleKey.E)
                {
                    running = false;
                }
            }
            // Exit. Running == false
            Console.WriteLine("\nExit");
        }
    }
}
