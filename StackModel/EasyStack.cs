using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StackModel
{
    public class EasyStack<T>
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;

        public bool IsEmpty => items.Count == 0;
        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (!IsEmpty)
            {
                var item = items.Last();
                items.RemoveAt(Count - 1);
                return item;
            }
            else
            {
                throw new NullReferenceException("Stack is empty!");
            }
        }
        public void Clear()
        {
            items.Clear();
        }
        public object Clone()
        {
            var newStack = new EasyStack<T>();
            newStack.items = new List<T>(items);
            return newStack;
        }
        public T Peek()
        {
            if (!IsEmpty)
            {
                return items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Stack is empty!");
            }
        }
        public override string ToString()
        {
            return $"Stack | Count elements: {Count}";
        }

    }
}
