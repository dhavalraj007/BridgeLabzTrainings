using System;

namespace MyApp
{
    class Program
    {
        static T FindMax<T>(params T[] list) where T:IComparable<T>
        {
            Array.Sort(list);

            return list.Last();
        }

        static void FindAndPrintMax<T>(params T[] list) where T:IComparable<T>
        {
            Array.Sort(list);
            System.Console.WriteLine("Max is "+list.Last());
        }
        static void Main(string[] args)
        {   
            System.Console.WriteLine(FindMax<int>(1,2,4,3,5,11,2,3));
            System.Console.WriteLine(FindMax<double>(1.2,2.21,4.21,3.2,5.2,11.2,2.2,3.45));
            System.Console.WriteLine(FindMax<String>("aWord","mWord","cWord","oWord"));
            FindAndPrintMax<int>(1,2,4,3,5,11,2,3);
        }
    }
}

