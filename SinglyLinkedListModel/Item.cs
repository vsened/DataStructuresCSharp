using System;
using System.Collections.Generic;


namespace DataStructures.SinglyLinkedListModel
{
    /// <summary>
    /// Element of Linked List
    /// </summary>
    public class Item<T>
    { 
        private T data = default(T);
        /// <summary>
        /// stored information in the element
        /// </summary>
        public T Data
        {
            get { return data; }
            set {
                if (value == null)
                    throw new ArgumentNullException("value");
                this.data = value;
            }
        }
        /// <summary>
        /// Еhe next element
        /// </summary>
        public Item<T> Next { get; set; }

        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
