using System;

namespace args
{
    public class ArgListInt : Arg
    {
        int valueListInt;

        public ArgListInt(string Flag) : base(Flag)
        {
            this.valueListInt = 0;
        }
        public int ValueListInt
        {
            get { return valueListInt; }
        }
    }
}