using System;

namespace args
{
    public class Arg
    {
        string flag;
        
        public Arg(string Flag)
        {
            this.flag = Flag;
        }
        public String Flag
        {
            get { return flag; }
            set { flag = value; }
        }
        
    }
}