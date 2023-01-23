namespace MyApp
{
    class Node<T>
    {
        public T data;
        public Node<T>? Next;
        
        public Node(T _data)
        {
            data = _data;
            Next = null;
        }

        public override string? ToString()
        {
            if(data==null)
                return "null";
            return data.ToString() ;
        }
    }
    class LinkedList<T> where T:IEquatable<T>
    {
        public Node<T>? head;
        public int count;
        public LinkedList()
        {
            head = null;
            count = 0;
        }

        public void AddLast(T _data)
        {
            AddAt(count, _data);
        }

        public void AddFront(T _data)
        {
            AddAt(0, _data);
        }

        public void AddAt(int index, T _data)
        {
            Node<T>? nodeBefore = head;
            if (index <= 0)
            {
                Node<T> newNode = new Node<T>(_data);
                newNode.Next = head;
                head = newNode;
                count++;
                return;
            }
            int c = 0;
            while (c < index - 1 && nodeBefore != null)
            {
                nodeBefore = nodeBefore.Next;
                c++;
            }
            if (nodeBefore != null)
            {
                Node<T> newNode = new Node<T>(_data);
                newNode.Next = nodeBefore.Next;
                nodeBefore.Next = newNode;
                count++;
            }
        }

        public void DeleteFirst()
        {
            DeleteFrom(0);
        }

        public void DeleteLast()
        {
            DeleteFrom(count - 1);
        }
        public void DeleteFrom(int index)
        {
            Node<T>? nodeBefore = head;
            if (index < 0 || head == null)
                return;
            if (index == 0)
            {
                head = head.Next;
                count--;
                return;
            }
            int c = 0;
            while (c < index - 1 && nodeBefore != null)
            {
                nodeBefore = nodeBefore.Next;
                c++;
            }
            if (nodeBefore != null && nodeBefore.Next != null)
            {
                nodeBefore.Next = nodeBefore.Next.Next;
                count--;
            }
        }

        public Node<T>? search(T data)
        {
            Node<T>? temp = head;
            while (temp != null && !temp.data.Equals(data))
            {
                temp = temp.Next;
            }
            return temp;
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