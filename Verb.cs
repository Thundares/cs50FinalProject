using System.Collections.Generic;
using System;

namespace Classes
{
    public class Verb : Word
    {
        //props
        public string Subject { get; set; }
        public string Object { get; set; }
        public string Complement { get; set; }

        //methods
        public Verb()
        {
            Complement = null;
        }
        public Verb(string sub, string obj)
        {
            Subject = sub;
            Object = obj;
        }

        public void RandAction(string Agent, List<Word> Obj, List<Word> Place, List<Word> Someone, List<Verb> Act)
        {
            int LenObj = Obj.Count - 1;
            int LenPlac = Place.Count - 1;
            int LenSome = Someone.Count - 1;
            int LenAct = Act.Count - 1;
            var rand = new Random();

            // The one who will make the action
            Subject = Agent;

            // Check what the verb needs
            if(Object == "object")
            {
                // choose an object from obj list
                Object = Obj[rand.Next(LenObj)].Name;
            }
            else if(Object == "place")
            {
                // choose an object from place list
                Object = Place[rand.Next(LenPlac)].Name;
            }
            else if(Object == "living")
            {
                // choose an object from someone list
                Object = Someone[rand.Next(LenSome)].Name;
            }
            else 
            {
                // The tag was not found
                Console.WriteLine("Error in RandAction. The tag '" + Object + "' was not found.");
                System.Environment.Exit(1);
            }

            // does it need a Complement?
            if(Complement == null)
            {
                return;
            }

            // if yes

            if(Complement == "object")
            {
                // choose an complement from obj list
                Complement = " " + Obj[rand.Next(LenObj)].Name;
            }
            else if(Complement == "place")
            {
                // choose an complement from place list
                Complement = " " + Place[rand.Next(LenPlac)].Name;
            }
            else if(Complement == "living")
            {
                // choose an complement from someone list
                Complement = " " + Someone[rand.Next(LenSome)].Name;
            }
            else if(Complement == "verb")
            {
                // choose an complement from act list. Can lead to infinity recursion, but what are the chances?
                Verb OtherVerb = new Verb();
                OtherVerb = Act[rand.Next(LenAct)];
                OtherVerb.RandAction("", Obj, Place, Someone, Act);
                Complement = OtherVerb.ToString();
            }
            else 
            {
                // The tag was not found
                Console.WriteLine("Error in RandAction. The tag '" + Complement + "' was not found.");
                System.Environment.Exit(1);
            }

        }

        public override string ToString()
        {
            return Subject + " need to " + Name + " " + Object + Complement;
        }
    }
}