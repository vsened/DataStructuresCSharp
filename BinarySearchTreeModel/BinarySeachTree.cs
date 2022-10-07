using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchTreeModel
{
    internal class BinarySeachTree<T>
        where T : IComparable<T>
    {
        public Node<T>? Root { get; private set; }
        public int Count {get; private set; }

        public BinarySeachTree()
        {
            Count = 0;
        }
        public BinarySeachTree(T data)
        {
            var root = new Node<T>(data);
            Root = root;
            Count = 1;
        }
        public BinarySeachTree(Node<T> node)
        {
            Root = node;
            Count = 1;
        }
        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (Root == null)
            {
                Root = node;
                Count++;
                return;
            }
            var current = Root;
            while (current != null)
            {
                if (current.CompareTo(node) > 0)
                {
                    if (current.LeftChild == null)
                    {
                        current.AddLeftChild(node);
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.LeftChild;
                    }
                }
                else if (current.CompareTo(node) < 0)
                {
                    if (current.RightChild == null)
                    {
                        current.AddRightChild(node);
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.RightChild;
                    }
                }
                else
                    throw new ArgumentException("Значение уже присутствует в дереве");
            }
        }
        public void AddRecursion(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count++;
                return;
            }
            if (Root.AddRecurcion(data))
            {
                Count++;
            }
            else
            {
                Console.WriteLine("Элемент уже присутствует в списке!");
            }
        }
        public List<T> GetValues(BinaryTreeTraversals option)
        {
            var result = new List<T>();
            switch (option)
            {
                case BinaryTreeTraversals.Preorder:
                    result = PreorderTraversal();
                    break;
                case BinaryTreeTraversals.Inorder:
                    result = InorderTraversal();
                    break;
                case BinaryTreeTraversals.Postorder:
                    result = PostorderTraversal();
                    break;  
            }
            return result;
        }
        private List<T> PreorderTraversal()
        {
            var list = new List<T>();
            var current = Root;
            if (current != null)
            {
                list.Add(current.Data);
                if (current.LeftChild != null)
                {
                    list.AddRange(PreorderTraversal(current.LeftChild));
                }
                if (current.RightChild != null)
                {
                    list.AddRange(PreorderTraversal(current.RightChild));
                }
            }
            return list;
        }
        private List<T> PreorderTraversal(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                list.Add(node.Data);

                if (node.LeftChild != null)
                {
                    list.AddRange(PreorderTraversal(node.LeftChild));
                }
                if (node.RightChild != null)
                {
                    list.AddRange(PreorderTraversal(node.RightChild));
                }
            }
            return list;
        }
        private List<T> InorderTraversal()
        {
            var list = new List<T>();
            var current = Root;

            if (current != null)
            {
                if (current.LeftChild != null)
                {
                    list.AddRange(InorderTraversal(current.LeftChild));
                }
                list.Add(current.Data);
                if (current.RightChild != null)
                {
                    list.AddRange(InorderTraversal(current.RightChild));
                }
            }
            return list;
        }
        private List<T> InorderTraversal(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.LeftChild != null)
                {
                    list.AddRange(InorderTraversal(node.LeftChild));
                }
                list.Add(node.Data);
                if (node.RightChild != null)
                {
                    list.AddRange(InorderTraversal(node.RightChild));
                }
            }
            return list;
        }
        private List<T> PostorderTraversal()
        {
            var list = new List<T>();
            var current = Root;
            if (current != null)
            {
                if (current.LeftChild != null)
                {
                    list.AddRange(PostorderTraversal(current.LeftChild));
                }
                if (current.RightChild != null)
                {
                    list.AddRange(PostorderTraversal(current.RightChild));
                }
                list.Add(current.Data);
            }
            return list;
        }
        private List<T> PostorderTraversal(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.LeftChild != null)
                {
                    list.AddRange(PostorderTraversal(node.LeftChild));
                }
                if (node.RightChild != null)
                {
                    list.AddRange(PostorderTraversal(node.RightChild));
                }
                list.Add(node.Data);
            }
            return list;
        }
    }
    enum BinaryTreeTraversals
    {
        Preorder,
        Inorder,
        Postorder
    }
}
