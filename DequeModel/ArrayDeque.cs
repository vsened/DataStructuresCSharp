using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DequeModel
{
    public class ArrayDeque<T>
    {
        private T[] _array;
        public int Count => _array.Length;
        public ArrayDeque()
        {
            _array = new T[0];
        }
        public ArrayDeque(T data)
        {
            _array = new T[1] { data };
        }
        public ArrayDeque(T[] deque)
        {
            _array = deque;
        }
        public void Pushback(T data)
        {
            var newArray = new T[Count + 1];
            newArray[0]=data;
            Array.ConstrainedCopy(_array, 0, newArray, 1, _array.Length);
            _array = newArray;
        }       
        public T Popback()
        {
            var newArray = new T[Count - 1];
            var result = _array.First();
            Array.ConstrainedCopy(_array, 1, newArray, 0, Count - 1);
            _array = newArray;
            return result;
        }
        public T Peekback()
        {
            var result = _array.First();
            return result;
        }
        public void Pushfront(T data)
        {
            var newArray = new T[Count + 1];
            newArray[Count] = data;
            Array.ConstrainedCopy(_array, 0, newArray, 0, Count);
            _array = newArray;
        }
        public T Popfront()
        {
            var newArray = new T[Count - 1];
            var result = _array.Last();
            Array.ConstrainedCopy(_array, 0, newArray, 0, Count - 1);
            _array = newArray;
            return result;
        }
        public T Peekfront()
        {
            var result = _array.Last();
            return result;
        }
    }
}
