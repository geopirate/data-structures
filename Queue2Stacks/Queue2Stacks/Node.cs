namespace Queue2Stacks
{
    class Node
    {
        public object Data;
        public Node Next;

        public Node(object newData)
        {
            Data = newData;
            Next = null;
        }
    }
}
