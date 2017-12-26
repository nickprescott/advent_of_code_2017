using System;

namespace puzzle1
{
    public class SumNums
    {
        public static void Main()
        {
            string text = System.IO.File.ReadAllText("input_1.txt");
            int sum = Utils.sumString(text);
            Console.Write(sum);
        }   

        
    }
}