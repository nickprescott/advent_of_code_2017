using System;

namespace puzzle_3
{
    public class Utils
    {
        public static double findDistanceToOne(int startingValue)
        {
            if(startingValue == 1)
            {
                return 0;
            }
            double distance;
            //always make the square big enough to put 1 at the center
            double sizeOfSquare = squareSize(startingValue);
            double maxDistance = sizeOfSquare -1;
            double sequentialDistanceToSquareValue = Math.Pow(sizeOfSquare, 2) - startingValue;
            //if maxDistance is 4, then the sequence of distances is 4,3,2,3,4 for all values on the
            //edge of the square. 
            distance = (maxDistance/2) + Math.Abs(((sequentialDistanceToSquareValue % maxDistance) - (maxDistance/2)));
            
            return distance;
        }

        public static double squareSize(double startingValue)
        {
            double sizeOfSquare = Math.Ceiling(Math.Sqrt(startingValue));
            if(sizeOfSquare % 2 == 0)
            {
                //always return odd size square
                return sizeOfSquare + 1;
            }
            return sizeOfSquare;
        }
    }
}