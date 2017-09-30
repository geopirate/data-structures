namespace Queue2Stacks
{
    class Stack
    {
        public Node Head = null;

        public void Push(object data)
        {
            Node newNode = new Node(data);

            
                newNode.Next = Head;
     
            Head = newNode;
        }

        public void Pop()
        {
            Head = Head.Next;
        }

        public object Pop(bool e)
        {
            Node curr = Head;
            Head = curr.Next;
            return curr.Data;
        }
    }
}
