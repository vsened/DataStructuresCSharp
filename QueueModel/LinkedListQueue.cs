using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.QueueModel
{
    public class LinkedListQueue<T>
    {
        public LinkedListQueueNode<T> Head { get; set; }
        public LinkedListQueueNode<T> Tail { get; set; }
        public int Count { get; set; }
        public LinkedListQueue()
        {
            SetClearQueue();
        }
        public LinkedListQueue(T data)
        {
            var item = new LinkedListQueueNode<T>(data);
            SetHeadAndTail(item);
        }
        public LinkedListQueue(LinkedListQueueNode<T> item)
        {
            SetHeadAndTail(item);
        }
        public void Enqueue(LinkedListQueueNode<T> node)
        {
            if (Count == 0)
                SetHeadAndTail(node);
            else
            {
                Head.Next = node;
                node.Previos = Head;
                Head = node;
                Count++;
            }
        }
        public void Enqueue(T data)
        {
            var node = new LinkedListQueueNode<T>(data);
            Enqueue(node);
        }
        public T Dequeue()
        {
            var result = Head;
            Head = Head.Previos;
            Head.Next = null;
            Count--;
            return result.Data;
        }
        public T Peek()
        {
            return Head.Data;
        }
        private void SetHeadAndTail(LinkedListQueueNode<T> node)
        {
            Head = node;
            Tail = node;
            Count = 1;
        }
        private void SetClearQueue()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
    }
}
