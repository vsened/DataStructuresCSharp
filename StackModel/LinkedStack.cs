using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StackModel
{
    public class LinkedStack<T>
    {
        public Item<T> Root { get; set; }
        public Item<T> Head { get; set; }
        public int Count { get; set; }
        public LinkedStack()
        {
            Root = null;
            Head = null;
            Count = 0;
        }
        public LinkedStack(T data)
        {
            var item = new Item<T>(data);
            Root = item;
            Head = item;
            Count = 1;
        }
        public LinkedStack(Item<T> item)
        {
            Root = item;
            Head = item;
            Count = 1;
        }
        public void Push(T data)
        {
            var item = new Item<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;
        }
        public void Push(Item<T> item)
        {
            item.Previous = Head;
            Head = item;
            Count++;
        }
        public Item<T> Pop()
        {
            if (Count == 0)
                throw new NullReferenceException("Stack is empty!");
            else if (Count == 1)
            {
                var item = Head;
                Head = null;
                Root = null;
                Count = 0;
                return item;
            }
            else
            {
                var prev = Head.Previous;
                var item = Head;
                Head = prev;
                Count--;
                return item;
            }
            
        }
        public Item<T> Peek()
        {
            var item = Head;
            return item;
        }

    }
}
