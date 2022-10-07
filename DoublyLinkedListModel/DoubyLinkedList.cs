using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DoublyLinkedListModel
{
    internal class DoubyLinkedList<T>: IEnumerable
    {
        public Item<T> Head { get; set; }
        public Item<T> Tail { get; set; }
        public int Count { get; set; }

        public DoubyLinkedList()
        {
            SetClearList(); 
        }
        public DoubyLinkedList(Item<T> item)
        {
            SetHeadAndTail(item);
        }
        public DoubyLinkedList(T data)
        {
            var item = new Item<T>(data);
            SetHeadAndTail(item);
        }

        public void Add(T data)
        {
            var item = new Item<T>(data);
            if (Count == 0)
                SetHeadAndTail(item);
            else
                AddElement(item);
        }
        public void Add(Item<T> item)
        {
            if (Count == 0)
                SetHeadAndTail(item);
            else
                AddElement(item);
        }
        public void AppendHead(Item<T> item)
        {
            Head.Previous = item;
            item.Next = Head;
            Head = item;
            Count++;
        }
        public void AppendTail(Item<T> item)
        {
            AddElement(item);
        }
        public void Clear()
        {
            SetClearList();
        }
        public void Insert(int index, T data)
        {
            var insertElem = new Item<T>(data);
            if (Count == 0)
            {
                SetHeadAndTail(insertElem);
            }
            else if(index == 0)
            {
                AppendHead(insertElem);
            }
            else
            {
                var current = Head.Next;
                for(int i = 1; i < index; i++)
                {
                    current = current.Next;
                }
                insertElem.Previous = current;
                insertElem.Next = current.Next;
                current.Next = insertElem;
                Count++;
            }
        }
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while(current != null)
            {
                yield return current;
                current = current.Next;
            }
        }
        public override string ToString()
        {
            return $"Douby Linked List | {Count} : elements";
        }
        private void SetHeadAndTail(Item<T> item)
        {
            Head = item;
            Tail = item;
            Count = 1;
        }
        private void SetClearList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        private void AddElement(Item<T> item)
        {
            item.Previous = Tail;
            Tail.Next = item;
            Tail = item;
            Count++;
        }
    }
}
