using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DequeModel
{
    public class DoubyLinkedListNode<T>
    {
        public T Data { get; set; }
        public DoubyLinkedListNode<T> Previos { get; set; }
        public DoubyLinkedListNode<T> Next { get; set; }
        public DoubyLinkedListNode(T data)
        {
            Data = data;
            Previos = null;
            Next = null;
        }
        public DoubyLinkedListNode(T data, DoubyLinkedListNode<T> previos) : this(data)
        {
            Previos = previos;
        }
        public DoubyLinkedListNode(T data, DoubyLinkedListNode<T> previos, DoubyLinkedListNode<T> next) : this(data, previos)
        {
            Next = next;
        }
    }
}
