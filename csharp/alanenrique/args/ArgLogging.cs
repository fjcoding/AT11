using System;

namespace args
{
    public class ArgLogging : Arg
    {
        bool valueLogging;

        public ArgLogging(string Flag) : base(Flag)
        {
            this.valueLogging = false;
        }
        public bool ValueLogging
        {
            get { return valueLogging; }
        }
    }
}