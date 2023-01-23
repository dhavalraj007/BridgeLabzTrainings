namespace MyApp
{
    class LinkedListTest
    {
        public static void UC2()
        {
            LinkedList<int> ls = new LinkedList<int>();
            ls.AddLast(56);
            ls.AddLast(30);
            ls.AddLast(70);
            System.Console.WriteLine(ls.ToString());
        }

        public static void UC3()
        {
            LinkedList<int> ls = new LinkedList<int>();
            ls.AddFront(70);
            ls.AddFront(30);
            ls.AddFront(56);
            System.Console.WriteLine(ls.ToString());
        }

        public static void UC4()
        {
            LinkedList<int> ls = new LinkedList<int>();
            ls.AddLast(56);
            ls.AddLast(70);
            System.Console.WriteLine(ls.ToString());
            ls.AddAt(1, 30);
            System.Console.WriteLine(ls.ToString());

        }

        public static void UC5()
        {
            LinkedList<int> ls = new LinkedList<int>();
            ls.AddLast(56);
            ls.AddLast(30);
            ls.AddLast(70);
            System.Console.WriteLine(ls.ToString());
            ls.DeleteFirst();
            System.Console.WriteLine(ls.ToString());
        }

        public static void UC6()
        {
            LinkedList<int> ls = new LinkedList<int>();
            ls.AddLast(56);
            ls.AddLast(30);
            ls.AddLast(70);
            System.Console.WriteLine(ls.ToString());
            ls.DeleteLast();
            System.Console.WriteLine(ls.ToString());
        }

        public static void UC7()
        {
            LinkedList<int> ls = new LinkedList<int>();
            ls.AddLast(56);
            ls.AddLast(30);
            ls.AddLast(70);
            System.Console.WriteLine(ls.ToString());
            System.Console.WriteLine("30 exists ?  = " + (ls.search(30) is not null));
            System.Console.WriteLine("1 exists ?  = " + (ls.search(1) is not null));
        }
        public static void UC10()
        {
            SortedLinkedList<int> sls = new SortedLinkedList<int>();
            sls.Add(56);
            System.Console.WriteLine(sls.ToString());
            sls.Add(30);
            System.Console.WriteLine(sls.ToString());
            sls.Add(40);
            System.Console.WriteLine(sls.ToString());
            sls.Add(70);
            System.Console.WriteLine(sls.ToString());
            sls.Add(20);
            System.Console.WriteLine(sls.ToString());
        }
        public static void UC11()
        {
            LinkedList<double> ls = new LinkedList<double>();
            ls.AddLast(56.1);
            ls.AddLast(30.23);
            ls.AddLast(70.213);
            System.Console.WriteLine(ls.ToString());
            System.Console.WriteLine("30 exists ?  = " + (ls.search(30) is not null));
            System.Console.WriteLine("56.1 exists ?  = " + (ls.search(56.1) is not null));
        }
    }

    class StackTest
    {
        public static void UC1()
        {
            Stack<int> s = new Stack<int>();
            s.push(30);
            s.push(56);
            s.push(70);
            System.Console.WriteLine(s.ToString());
        }
        public static void UC2()
        {
            Stack<int> s = new Stack<int>();
            s.push(30);
            s.push(56);
            s.push(70);
            System.Console.WriteLine(s.ToString());
            System.Console.WriteLine("peak : "+ s.peak());
            s.pop();
            System.Console.WriteLine("\nAfter pop");
            System.Console.WriteLine(s.ToString());
        }
    }

    class QueueTest
    {
        public static void UC3()
        {
            Queue<int> q = new Queue<int>();
            q.enqueue(56);
            q.enqueue(30);
            q.enqueue(70);
            System.Console.WriteLine(q.ToString());
        }
        public static void UC4()
        {
            Queue<int> q = new Queue<int>();
            q.enqueue(56);
            q.enqueue(30);
            q.enqueue(70);
            System.Console.WriteLine(q.ToString());
            q.dequeue();
            System.Console.WriteLine("After dequeue");
            System.Console.WriteLine(q.ToString());
        }
    }
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
