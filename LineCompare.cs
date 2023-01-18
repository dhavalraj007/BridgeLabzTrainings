using System;

namespace MyApp
{

    class Line:IComparable<Line>
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;

        public Line(int x1,int y1,int x2,int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public double Length()
        {
            return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
        }
        public int CompareTo(Line? other)
        {
            if(other==null) return 1; // if other is null consider it smaller than this
            return this.Length().CompareTo(other.Length());
        }

        public static bool operator> (Line l1,Line l2)
        {
            return l1.CompareTo(l2)>0;
        }

        public static bool operator>= (Line l1,Line l2)
        {
            return l1.CompareTo(l2)>=0;
        }
        public static bool operator< (Line l1,Line l2)
        {
            return l1.CompareTo(l2)<0;
        }
        public static bool operator<= (Line l1,Line l2)
        {
            return l1.CompareTo(l2)<=0;
        }

        public override string ToString()
        {
            return $"Line: ({x1},{y1}) , ({x2},{y2}) with Length {this.Length()}";
        }
    }
}