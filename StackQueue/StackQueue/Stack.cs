namespace StackQueue
{
    class Stack : LinkedList
    {
        // add
        public void Push(object thisData)
        {
            Node toPush = new Node(thisData)
            {
                Next = head
            };
            head = toPush;
        }
        // delete
        public Node Pop()
        {
            return Delete();
        }
    }
}
