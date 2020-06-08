using System;

namespace classes
{
    class Verb : Word
    {
        //props
        public Word Subject { get; set; }
        public Word Object { get; set; }

        //methods
        Verb(Word sub, Word obj)
        {
            Subject = sub;
            Object = obj;
        }

    }
}