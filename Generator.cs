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

            // read people.txt to list our possible characters
            readFile("People.txt", People);

            Console.WriteLine("\nComplete!");
            Console.WriteLine("\nLoading Words...");

            // read Objects.txt to list our vocabulary
            List<Word> Obj = new List<Word>();
            readFile("Objects.txt", Obj);

            // read Places.txt
            List<Word> Places = new List<Word>();
            readFile("Places.txt", Places);

            Console.WriteLine("\nComplete!");
            Console.WriteLine("\nLoading Verbs...");

            // read Verbs.txt to list our actions
            List<Verb> Actions = new List<Verb>();
            readVerb("Verbs.txt", Actions);

            Console.WriteLine("\nComplete");
        }

        static void readFile(string path, List<Word> list)
        {
            FileStream Characters = null;
            StreamReader Reader = null;

            try
            {
                // finding and opening file
                Characters = new FileStream(path, FileMode.Open);
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
                    list.Add(aux);
                    /* -debug log- */Console.WriteLine("Added: " + list[i].Name);
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

        static void readVerb(string path, List<Verb> list)
        {
            FileStream Characters = null;
            StreamReader Reader = null;

            try
            {
                // finding and opening file
                Characters = new FileStream(path, FileMode.Open);
                Reader = new StreamReader(Characters);

                // reading file
                string text = Reader.ReadToEnd();
                string[] names = text.Split('\n');

                // saving file into List
                int i = 0;
                foreach (string item in names)
                {
                    Verb aux = new Verb();

                    //split comas
                    string[] NameObjComp = names[i].Split(',');

                    aux.Name = NameObjComp[0];
                    aux.Object = NameObjComp[1];
                    if (NameObjComp.Length > 2)
                    {
                        aux.Complement = NameObjComp[2];
                    }

                    list.Add(aux);
                    /* -debug log- */Console.WriteLine("Added: " + list[i].Name);
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