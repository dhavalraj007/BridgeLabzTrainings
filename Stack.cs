namespace MyApp
{
    class Stack<T>
    {
        Node<T>? top = null;
        public void push(T data)
        {
            if(top==null)
            {
                top = new Node<T>(data);
            }
            else
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = top;
                top = newNode;
            }
        }

        public void pop()
        {
            if(top==null)
            {
                System.Console.WriteLine("Stack is Empty!");
            }
            else
                top = top.Next; 
        }
        public T? peak()
        {
            if(top ==null)
            {
                System.Console.WriteLine("Empty stack");
                return default(T);
            }
            else
            {
                //System.Console.WriteLine("Top is "+top.data);
                return top.data;
            }
        }

        public override string ToString()
        {
            String ret = "";
            Node<T>? temp = top;
            while(temp!=null)
            {
                ret+= temp.data+"\n |\n";
                temp = temp.Next;
            }
            ret+="null";
            return ret;
        }

    }
}
