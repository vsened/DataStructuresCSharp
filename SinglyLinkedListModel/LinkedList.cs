using System;
using System.Collections;
using System.Collections.Generic;


namespace DataStructures.SinglyLinkedListModel
{
    /// <summary>
    /// Singly Linked List
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Started element of List
        /// </summary>
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }
        public LinkedList()
        {
            SetClearList(); 
        }
        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }
        public void Add(T data)
        {
            
            if (Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
            
        }
        public void AppendHead(T data)
        {
            if (Head != null)
            {
                var item = new Item<T>(data);
                item.Next = Head;
                Head = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }  
        }
        public void AppendTail(T data)
        {
            if (Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        public void Clear()
        {
            SetClearList();
        }
        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T data)
        {
            var item = new Item<T>(data);
            if (index == 0)
            {
                item.Next = Head;
                Head = item;
                Count++;
            }
            else if (index > Count || index < 0)
            {
                throw new IndexOutOfRangeException($"{index} is invalid index value");
            }
            {
                var current = Head;
                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }
                item.Next = current.Next;
                current.Next = item;
                Count++;
            }
        }

        public void InsertAfter(T target, T data)
        {
            if (Head == null)
            {
                throw new Exception("List is empty!");
            }
            else
            {
                var item = new Item<T>(data);
                var elem = new Item<T>(target);
                var current = Head;
                while (current != null)
                {
                    if (current.Data.Equals(elem.Data))
                    {
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    current = current.Next;
                }
            }
            throw new Exception("Target element not found.");
        }

        public void RemoveAt(int index)
        {
            if (Count == 0)
            {
                throw new Exception("List is empty");
            }
            if (index == 0 && Count > 1)
            {
                Head = Head.Next;
                Tail = Head.Next;
                Count--;
            }
            else if (Count == 1)
            {
                Head = null;
                Tail = null;
                Count--;
            }
            else if (index > Count || index < 0)
            {
                throw new IndexOutOfRangeException($"{index} is invalid index value");
            }
            else
            {
                var current = Head;
                var prev = Head;
                for (int i = 1; i <= index; i++)
                {
                    prev = current;
                    current = current.Next;
                }
                current = current.Next;
                prev.Next = current;
                Count--;
            }
        }

        public void Delete(T data)
        {
            bool flag = false;
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                
                var current = Head.Next;
                var prev = Head; 

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        prev.Next = current.Next;
                        Count--;
                        flag = true;
                        return;
                    }
                    prev = current;
                    current = current.Next;
                }
            }
            if (!flag)
                Console.WriteLine($"Object {data} not found ");
        }

        public void Reverse()
        {
            var current = Head;
            Item<T> prev = null;
            var next = Head.Next;
            while (current.Next != null)
            {
                current.Next = prev;
                prev = current;
                current = next;
                next = next.Next;
            }
            current.Next = prev;
            (Head, Tail) = (Tail, Head);
        }
        public T GetMiddleElement()
        {
            var mid = Head;
            var current = Head;
            var tempCount = 1;
            while(current != null)
            {
                if (tempCount % 2 == 0 && tempCount > 2)
                {
                    mid = mid.Next;
                }
                current = current.Next;
                if (current != null)
                    tempCount++;
            }
            if (tempCount % 2 == 1)
            {
                mid = mid.Next;
            }
            return mid.Data;
        }

        public override string ToString()
        {
            return $"Linked List | Count elements: {Count}";
        }

        private void SetClearList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
    }
}
