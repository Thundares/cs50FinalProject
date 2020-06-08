using System;

namespace Classes
{
    public class Verb : Word
    {
        //props
        public Word Subject { get; set; }
        public Word Object { get; set; }
        public string Complement { get; set; }

        //methods
        Verb(Word sub, Word obj)
        {
            Subject = sub;
            Object = obj;
        }

    }
}