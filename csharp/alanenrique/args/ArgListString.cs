using System;

namespace args
{
    public class ArgListString : Arg
    {
        String valueListString;

        public ArgListString(string Flag) : base(Flag)
        {
            this.valueListString = "";
        }
        public String ValueListString
        {
            get { return valueListString; }
        }
    }
}