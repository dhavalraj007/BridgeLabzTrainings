namespace MyApp
{
    class SortedLinkedList<T> where T:IComparable<T>
    {
        public Node<T>? head;
        public int count;
        public SortedLinkedList()
        {
            head = null;
            count = 0;
        }


        public void Add(T _data)
        {
            Node<T>? temp = head;
            Node<T> newNode = new Node<T>(_data);
            if(temp==null)
            {
                head = new Node<T>(_data);
                count++;
                return;
            }
            if(temp.data.CompareTo(_data)>0)     //because temp.data might already be greater than _data
            {
                newNode.Next = temp;
                if(temp==head)
                    head = newNode;
                count++;
                return;
            }
            while(temp.Next!=null && temp.Next.data.CompareTo(_data)<0)
            {
                temp = temp.Next;
            }
            //temp here is last smaller element than _data
            if(temp.Next==null)
            {
                temp.Next = newNode;
                count++;
                return;
            }
            newNode.Next = temp.Next;
            temp.Next = newNode;
            count++;
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
            while (temp != null && temp.data.CompareTo(data)==0)
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