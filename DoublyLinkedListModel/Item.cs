namespace DataStructures.DoublyLinkedListModel
{
    internal class Item<T>
    {
        public T Data { get; set; }
        public Item<T> Previous { get; set; }
        public Item<T> Next { get; set; }

        public Item()
        {
            Data = default;
            Previous = null;
            Next = null;
        }
        public Item(T data)
        {
            Data = data;
            Previous = null;
            Next = null;
        }
        public Item(T data, Item<T> previous) : this(data)
        {
            Previous = previous;
        }
        public Item(T data, Item<T> previous, Item<T> next) : this(data, previous)
        {
            Next = next;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
