using System;

namespace puzzle1
{
    public class Utils
    {
        public static int sumString(string text)
        {
            int sum = 0;
            //strings with 0 or 1 digits always sum to zero
            if(text.Length == 0 || text.Length ==1)
            {
                return 0;
            }

            for (int x=0; x< text.Length; x++)
            {
                //allow for circular list
                if(text[x] == text[(x+1) % text.Length])
                {
                    sum += int.Parse(text[x].ToString());
                }
            }
            return sum;
        }
    }
}