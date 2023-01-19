namespace MyApp
{
    class Queue<T>
    {
        Node<T>? head = null;
        public void enqueue(T data)
        {
            if(head==null)
            {
                head = new Node<T>(data);
            }
            else
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = head;
                head = newNode;
            }
        }

        public void dequeue()
        {
            if(head==null)
            {
                System.Console.WriteLine("Stack is Empty!");
            }
            else
            {
                Node<T> temp = head;
                if(temp.Next==null)
                {
                    head = null;
                    return;
                }
                while(temp.Next!=null && temp.Next.Next!=null)
                {
                    temp = temp.Next;
                }
                temp.Next = null;
            }
        }
        public override string ToString()
        {
            if (head == null)
                return "null";
            string ret = "";
            Node<T>? temp = head;
            while (temp != null)
            {
                ret += temp.ToString() + "->";
                temp = temp.Next;
            }
            ret += "null";
            return ret;
        }

    }
}
