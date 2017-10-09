namespace StackQueue
{
    class Queue : LinkedList
    {
        // add
        public void Enqueue(object thisData)
        {
            Node current = head;

            if(current == null)
            {
                head = new Node(thisData);
                return;
            }
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node(thisData);
        }

        // delete
        public Node Dequeue()
        {
            return Delete();
        }
    }
}
