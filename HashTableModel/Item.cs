using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashTableModel
{
    public class Item<T>
    {
        public int Key { get; set; }
        public List<T> Items { get; set; }

        public Item(int key)
        {
            Key = key;
            Items = new List<T>();
        }
    }
}
