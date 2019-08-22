using System;
public class Scanner
{
    public Scanner()
    {}
    public bool verifyLength(String line1Input, String line2Input, String line3Input)
    {
        return  line1Input.Length == 27 &&
                line2Input.Length == 27 && 
                line3Input.Length == 27;
    }
}