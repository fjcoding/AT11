using System;
public class Guest
{
    private const int woman = -1;
    private const int man = 1;
    public Guest()
    {

    }
    public bool VerifyAmountOfGuests(int [] inputGuestList)
    {
        int countWoman = 0;
        int countMan = 0;
                       
        for (int items = 0; items < inputGuestList.Length; items++)
        {   
            countMan += counterOfMen(inputGuestList[items]);
            countWoman += counterOfWomen(inputGuestList[items]);
        }
        return countWoman < countMan;
    }
    private int counterOfMen (int count)
    {
        int count_man = 0;
        if(count == 1)
            count_man++;
        return count_man;
    }
    private int counterOfWomen (int count)
    {
        int count_women = 0;
        if(count == -1)
            count_women++;
        return count_women;
    }
}