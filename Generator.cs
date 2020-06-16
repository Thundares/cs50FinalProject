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
            Generate(People, Places, Obj, Actions);
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

        // Article generator
        static string Article(string word, bool the)
        {
            // if it is a Name with Uppercase there will be no article
            if(word[0] < 91)
            {
                if(the)
                {
                    return "the ";
                }
                else
                    return "";
            }

            // else run the code
            char aux = word[0];
            char.ToUpper(aux);

            // check if Grammar is right
            if(aux == 'A' || aux == 'E' || aux == 'I' || aux == 'O' || aux == 'H')
            {
                return "an ";
            }
            else
            {
                return "a ";
            }
        }

        // Generates the Hero's Journey
        static void Generate(List<Word> People, List<Word> Places, List<Word> Obj, List<Verb> Actions)
        {
            // auxiliar variables
            int LenPeop = People.Count - 1;
            int LenPlac = Places.Count - 1;
            int LenObj = Obj.Count - 1;
            int LenAct = Actions.Count - 1;
            var rand = new Random();

            // Printing in Console
            Console.WriteLine("\n\n\n\n\n\n\n                    The Journey Starts...\n\n\n\n\n\n\n\n");

            // The Ordinary World
            Word Hero = People[rand.Next(LenPeop)];
            Word OrdinaryWorld = Places[rand.Next(LenPlac)];
            Console.WriteLine("At the beginning there was " + Article(Hero.Name, false) 
            + Hero.Name + ". Who lived in " + Article(OrdinaryWorld.Name, true) 
            + OrdinaryWorld.Name + ".\n\n\n\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Call to Adventure
            Verb MainAction = Actions[rand.Next(LenAct)];
            MainAction.RandAction(Article(Hero.Name, false) + Hero.Name, Obj, Places, People, Actions);
            Console.WriteLine("\n\n\n" + MainAction.ToString() + "\n\n\n\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Refuse of the Call
            Word TempWord = People[rand.Next(LenPeop)];
            Console.WriteLine("\n\n\nBut was reluctant to accept the task because of " 
            + Article(TempWord.Name,false) + TempWord.Name + ".\n\n\n\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Meeting with Mentor
            Word Mentor = People[rand.Next(LenPeop)];
            Console.WriteLine("\n\n\n" + Hero.Name + " could only decide after "
            + Article(Mentor.Name, false) + Mentor.Name + " appeared as a Mentor.\n\n\n\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Crossing the first threshold
            TempWord = Places[rand.Next(LenPlac)];
            Console.WriteLine("\n\n\nWhen they reached " + TempWord.Name + " " + Hero.Name
            + " could not believe how the world could be so different.\n\n\n\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Test, Allies and enemies
            Word Enemy = People[rand.Next(LenPeop)];
            Word Ally = People[rand.Next(LenPeop)];
            Verb Test = Actions[rand.Next(LenAct)];
            Test.RandAction(Hero.Name + " needed ", Obj, Places, People, Actions);
            Console.WriteLine("\n\n\nOn the new world " + Test.ToString() 
            + ".\nAs a friend there was " + Article(Ally.Name, false) + Ally.Name
            + ".\nAnd as a enemy there was " + Article(Enemy.Name, false) + Enemy.Name + ".\n\n\n\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Approach to the inmost cave

            // The Ordeal

            // Reward

            // The road back

            // The ressurrection

            // Return with the Elixir 
        }
    }
}