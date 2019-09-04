using System;
using System.Collections.Generic;
public class PartyOrganizer
{
    int[] listGuests;
    int amountMales, amountFemales;

    const int man = 1, woman = -1;

    public PartyOrganizer(){}

    public void counterGuestBySex()
    {
        for (int index = 0; index < listGuests.Length; index++)
        {
            this.verifyGuestsSex(listGuests[index]);
        }
    }
    public void obtainListGuests(int[] ListGuests)
    {
        this.listGuests = ListGuests;
    }
    private void verifyGuestsSex(int sexGuests)
    {
        if (sexGuests == man)
        {
            amountMales++;
        }
        if (sexGuests == woman)
        {
            amountFemales++;
        }
    }
    public int getAmountMales()
    {
        this.counterGuestBySex();
        return amountMales;
    }
    public int getAmountFemales()
    {
        this.counterGuestBySex();
        return amountFemales;
    }
    public bool verifyFemalesThanMoreMales()
    {
        this.counterGuestBySex();

        return amountFemales >= amountMales;
    }    
}