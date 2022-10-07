using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DequeModel
{
    public class ListDeque<T>
    {
        private List<T> _items;
        public int Count => _items.Count;
        public ListDeque()
        {
            _items = new List<T>();
        }
        public ListDeque(T data)
        {
            _items = new List<T> { data };
        }
        public void Pushback(T data)
        {
            _items.Insert(0, data);
        }
        public T Popback()
        {
            IsAblePop();
            var result = _items.First();
            _items.RemoveAt(0);
            return result;
        }
        public T PeekBack()
        {
            return _items.First();
        }
        public void Pushfront(T data)
        {
            _items.Add(data);
        }
        public T Popfront()
        {
            IsAblePop();
            var result = _items.Last();
            _items.RemoveAt(Count - 1);
            return result;
        }
        public T Peekfront()
        {
            return _items.Last();
        }
        private void IsAblePop()
        {
            if (Count == 0)
                throw new InvalidOperationException("Deque is empty!");
        }
    }
}
