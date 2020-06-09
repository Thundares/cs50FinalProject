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
        }
        public Verb(string sub, string obj)
        {
            Subject = sub;
            Object = obj;
        }

    }
}