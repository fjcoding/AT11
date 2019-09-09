using System;

namespace args
{
    public class ArgDirectory : Arg
    {
        String valueDirectory;

        public ArgDirectory(string Flag) : base(Flag)
        {
            this.valueDirectory = "";
        }
        public String ValueDirectory
        {
            get { return valueDirectory; }
        }
    }
}