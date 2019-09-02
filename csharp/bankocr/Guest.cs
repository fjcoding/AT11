using System;
using System.Collections.Generic;
public class Guest
{
    List<int> listguests= new List<int>() {-1,-1,1,-1,1,-1,1,-1};
    int amountMales;
    int amountFemales;
    public Guest(){}

    public bool verifyLimitGuests()
    {
        if ((listguests.Count>=2) && (listguests.Count<=50))
        {
            return true;
        }
        return false;
    }
    public void counterGuestSex()
    {
        for(int index =0; index < listguests.Count; index ++)
        {
            this.verifySexGuest(listguests[index]);
        }
    }
    private void verifySexGuest(int guest)
    {
        if(guest == 1)
        {
            amountMales ++;
        }
        if(guest == -1)
        {
            amountFemales ++;
        }
    }
    public int getAmountMales()
    {
        this.counterGuestSex();
        return amountMales;
    }
    public int getAmountFemales()
    {
        this.counterGuestSex();
        return amountFemales;
    }
    public bool verifyFemalesThanMoreMales()
    {
        this.counterGuestSex();

        if (amountFemales>=amountMales && this.verifyLimitGuests())
        {
            return true;
        }
        return false;
    }    
}