using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.QueueModel
{
    public class LinkedListQueueNode<T>
    {
        public T Data { get; private set; }
        public LinkedListQueueNode<T> Previos { get; set; }
        public LinkedListQueueNode<T> Next { get; set; }
        public LinkedListQueueNode(T data)
        {
            Data = data;
            Previos = null;
            Next = null;
        }
        public LinkedListQueueNode(T data, LinkedListQueueNode<T> previos) : this(data)
        {
            Previos = previos;
        }
        public LinkedListQueueNode(T data, LinkedListQueueNode<T> previos, LinkedListQueueNode<T> next) : this(data, previos)
        {
            Next = next;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
