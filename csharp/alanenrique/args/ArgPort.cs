using System;

namespace args
{
    public class ArgPort : Arg
    {
        int valuePort;

        public ArgPort(string Flag) : base(Flag)
        {
            this.valuePort = 0;
        }
        public int ValuePort
        {
            get { return valuePort; }
        }
    }
}