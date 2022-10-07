using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DequeModel
{
    public class DoubyLinkedListDeque<T>
    {
        public DoubyLinkedListNode<T> Head { get; set; }
        public DoubyLinkedListNode<T> Tail { get; set; }
        public int Count { get; set; }
        public DoubyLinkedListDeque()
        {
            SetClearList();
        }
        public DoubyLinkedListDeque(T data)
        {
            Head = new DoubyLinkedListNode<T>(data);
            Tail = new DoubyLinkedListNode<T>(data);
            Count = 0;
        }
        public void Pushback(DoubyLinkedListNode<T> node)
        {
            Tail.Previos = node;
            node.Next = Tail;
            Tail = node;
            Count++;
        }
        public void Pushback(T data)
        {
            var node = new DoubyLinkedListNode<T>(data);
            Pushback(node);
        }
        public T Popback()
        {
            var result = Tail.Data;
            Tail = Tail.Next;
            Tail.Previos = null;
            Count--;
            return result;
        }
        public T Peekback()
        {
            return Tail.Data;
        }
        public void Pushfront(DoubyLinkedListNode<T> node)
        {
            Head.Next = node;
            node.Previos = Head;
            Head = node;
            Count++;
        }
        public void Pushfront(T data)
        {
            var node = new DoubyLinkedListNode<T>(data);
            Pushback(node);
        }
        public T Popfront()
        {
            var result = Head.Data;
            Head = Head.Previos;
            Head.Next = null;
            Count--;
            return result;
        }
        public T PeekFront()
        {
            return Head.Data;
        }
        private void SetClearList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
    }
}
