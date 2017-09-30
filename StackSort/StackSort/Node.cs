namespace StackSort
{
    class Node
    {
        public int Data;
        public Node Next;
        public Node Previous;

        public Node(int nextData)
        {
            Data = nextData;
            Next = null;
            Previous = null;
        }
    }
}
