using System;

namespace DataStructures.QueueModel
{
    public class EasyQueue<T>
    {
        private List<T> _items = new List<T>();
        private T Head => _items.Last();
        private T Tail => _items.First();
        public int Count => _items.Count;
        public EasyQueue() { }
        public EasyQueue(T data)
        {
            _items.Add(data);
        }
        public void Enqueue(T data)
        {
            _items.Insert(0, data);
        }
        public T Dequeue()
        {
            if (Count == 0) 
            {
                throw new ArgumentException("Queue is empty!");
            }
            else 
            { 
                var result= _items.Last();
                _items.RemoveAt(Count - 1);
                return result;
            }
        }
        public T Peek()
        {
            if (Count == 0)
            {
                throw new ArgumentException("Queue is empty!");
            }
            return _items.Last();
        }
    }
}
