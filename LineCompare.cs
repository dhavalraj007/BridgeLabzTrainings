using System;

namespace MyApp
{
    class LineCompare
    {
        static LineCompare()
        {
            Console.WriteLine("Welcome to Line Comparison");
        }

        public static double LineLength(int x1,int y1,int x2,int y2)
        {
            return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
        }

        public static bool AreLinesEqual(int x11,int y11,int x12,int y12,int x21,int y21,int x22,int y22)
        {
            return x11==x21 && x12==x22 && y11==y21 && y12==y22;
        }

        public static void WhichIsGreater(int x11,int y11,int x12,int y12,int x21,int y21,int x22,int y22)
        {
            double line1 = LineLength(x11,y11,x12,y12);
            double line2 = LineLength(x21,y21,x22,y22);
            if(line1>line2)
                Console.WriteLine("Line 1 is greater");
            else if(line1<line2)
                Console.WriteLine("Line 2 is Greater");
            else
                Console.WriteLine("Lines are Same");
        }
    }
}