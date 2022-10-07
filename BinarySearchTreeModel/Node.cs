using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchTreeModel
{
    internal class Node<T>:IComparable
        where T : IComparable<T>
    {
        public T Data { get; private set; }
        public Node<T> LeftChild { get; private set; }
        public Node<T> RightChild { get; private set; }
        public Node(T data)
        {
            Data = data;
        }
        public Node(T data, Node<T> leftChild, Node<T> rightChild) : this(data)
        {
            LeftChild = leftChild;
            RightChild = rightChild;
        }

        public int CompareTo(object? obj)
        {
            if (obj is Node<T> item)
            {
                return Data.CompareTo(item.Data);
            }
            else
            {
                throw new ArgumentException("Не совпадение типов");
            }
        }
        public void AddLeftChild(Node<T> node)
        {
            LeftChild = node;
        }
        public void AddRightChild(Node<T> node)
        {
            RightChild = node;
        }

        public bool AddRecurcion(T data)
        {
            var node = new Node<T>(data);

            if (node.Data.CompareTo(Data) < 0)
            {
                if (LeftChild == null)
                {
                    LeftChild = node;
                    return true;
                }
                else
                {
                    LeftChild.AddRecurcion(data);
                }
            }
            else if (node.Data.CompareTo(Data) > 0)
            {
                if(RightChild == null)
                {
                    RightChild = node;
                    return true;
                }
                else
                {
                    RightChild.AddRecurcion(data);
                }
            }
            return false;
        }
    }
}
