using System;

namespace MathOverloadDemo
{
    public class EventMath
    {
        //Method 1: Takes an int and adds 10 guests
        public int GuestsCount(int registered)
        {
            return registered + 10;
        }

        //Method 2: Takes a decimal and calculates cost (50.5 per person)
        public int GuestsCount(decimal actualAttended)
        {
            decimal cost = actualAttended * 50.5m;
            return Convert.ToInt32(cost);
        }

        //Method 3: Takes a string, converts it to int, and subtracts no-shows (5)
        public int GuestsCount(string signups)
        {
            int total = Convert.ToInt32(signups);
            return total - 5;
        }
    }
}
