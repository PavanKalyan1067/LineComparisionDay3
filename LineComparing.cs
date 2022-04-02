using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisionProblems
{/// <summary>
/// data abstraction 
/// </summary>
    abstract class LineComparingAbstract
    {
        public abstract void CompareLines();
    }
    class LineComparing : LineComparingAbstract
    {
        private double LengthOfLine1, LengthOfLine2;
        public override void CompareLines()
        {
            FindLength findLength1 = new FindLength(-7, 17, -4, 6);
            FindLength findLength2 = new FindLength(-7, 17, -4, 2);
            LengthOfLine1 = findLength1.Length();
            LengthOfLine2 = findLength2.Length();
            Compare2Lengths(LengthOfLine1, LengthOfLine2);
        }
        private void Compare2Lengths(double LengthOfLine1, double LengthOfLine2)

        {
            if (LengthOfLine1 == LengthOfLine2)
                Console.WriteLine($"Length of line1 {LengthOfLine1} is equal to Length of Line2 {LengthOfLine2}");
            else if (LengthOfLine1 > LengthOfLine2)
                Console.WriteLine($"Length of line1 {LengthOfLine1} is greater than Length of Line2 {LengthOfLine2}");
            else
                Console.WriteLine($"Length of line1 {LengthOfLine1} is less than Length of Line2 {LengthOfLine2}");
        }
    }
}