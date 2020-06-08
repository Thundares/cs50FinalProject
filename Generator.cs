using System;
using System.IO;
using System.Collections.Generic;
using Classes;

namespace MainSource
{
    public static class Generator
    {
        public static void Execute()
        {
            Console.WriteLine("\nLoading Characters...");
            List<Word> People = new List<Word>();
            FileStream Characters = null;
            StreamReader Reader = null;

            try
            {
                // finding and opening file
                Characters = new FileStream("People.txt", FileMode.Open);
                Reader = new StreamReader(Characters);

                // reading file
                string text = Reader.ReadToEnd();
                string[] names = text.Split('\n');

                // saving file into List
                int i = 0;
                foreach (string item in names)
                {
                    Word aux = new Word();
                    aux.Name = names[i]; 
                    People.Add(aux);
                    Console.WriteLine("Added: " + People[i].Name);
                    i++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nCould not load file...\n" + e.Message);
            }
            finally
            {
                if (Characters != null) Characters.Close();
                if (Reader != null) Reader.Close();
            }
        }
    }
}