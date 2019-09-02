using System;
public class Guest
{
     private int woman;
     private int man;
    public Guest()
    {}
    public bool ReturnInviteMoreWomen(int [] inputGuestList)
    {
        this.woman = -1;
        this.man = 1;
        int countwoman = 0;
        int countman = 0;
        int sizeguestlist = inputGuestList.Length;
        if((sizeguestlist<2) || (sizeguestlist > 50) )
        return true;
        
        for (int items = 0; items < inputGuestList.Length; items++)
        {   
            if (inputGuestList[items] == woman)
                countwoman++;
            if(inputGuestList[items] == man)
                countman++;
        }
        if(countman <= countwoman)
            return false;
        return true;

        


    }
}