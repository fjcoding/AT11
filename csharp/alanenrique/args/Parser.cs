using System;
public class Parser
{
    //List <Arg> schema = new List<Arg>;
    public string getFlagType(string argument)
    {
        const string logging = "-l ";
        const string port = "-p ";
        const string directory = "-d ";
        const string listString = "-g ";
        const string listInt = "-d 1";

        string message = "Error, the argument is not Exist";

        string cutArgumentToThird = argument.Substring(0,3);

        //string cutArgumentToFourth = argument.Substring(0,4);

        if(cutArgumentToThird.Equals(logging) )
        {
            message = "logging";
        }

        /*if(cutArgumentToThird.Equals(port) )
        {
            message = "port";
        }

        if(cutArgumentToFourth.Equals(directory) )
        {
            message = "directory";
        }

        if(cutArgumentToThird.Equals(listString) )
        {
            message = "listString";
        }

        if(cutArgumentToFourth.Equals(listInt) )
        {
            message = "listInt";
        }
        */
        return message;
    }
}