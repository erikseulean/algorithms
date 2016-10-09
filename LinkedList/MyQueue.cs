namespace LinkedList
{
    public class MyQueue
    {
        private Node front, back;

        public void Enqueue(Node n)
        {
            if (front == null)
            {
                front = n;
                back = n;
            }
            else
            {
                back.Next = n;
                back = n;
            }
        }

        public Node Dequeue()
        {
            if (front == null) return null;
            else
            {
                Node oldFirst = front;
                front = front.Next;
                return oldFirst;
            }
        }
    }
}

