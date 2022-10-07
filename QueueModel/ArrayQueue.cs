using System;
using System.Collections.Generic;


namespace DataStructures.QueueModel
{
    public class ArrayQueue<T>
    {
        private T[] _array;
        public int Count { get; private set; }
        public int HeadIndex { get; private set; }
        public int TailIndex { get; private set; }
        public ArrayQueue()
        {
            _array = new T[0];
            Count = 0;
        }
        public ArrayQueue(T data)
        {
            _array = new T[1];
            HeadIndex = 0;
            TailIndex = 0;
            _array[HeadIndex] = data;
            Count = 1;
        }

        public void Enqueue(T data)
        {
            var newArray = new T[Count + 1];
            Array.Copy(_array, TailIndex, newArray, 1, Count);
            newArray[0] = data;
            _array = newArray;
            if (Count != 0)
            {
                HeadIndex++;
            }
            Count++;
            
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new ArgumentException("Queue is empty!");
            }
            var newArray = new T[Count-1];
            var result = _array.Last();
            Array.ConstrainedCopy(_array, TailIndex, newArray, 0, --Count);
            _array = newArray;
            HeadIndex--;
            return result;
        }
        public T Peek()
        {
            return _array.Last();
        }
    }
}
