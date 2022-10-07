using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StackModel
{
    public class ArrayStack<T>
    {
        private T[] items;
        public int Count => items.Length;
        public ArrayStack(int size = 10)
        {
            items = new T[size];
        }
        public ArrayStack(T data, int size = 10): this(size)
        {
            items[0] = data; 
        }

    }
}
