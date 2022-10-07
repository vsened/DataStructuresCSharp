using DataStructures.HashTableModel;
using System;

namespace DataStructures
{
    public class Programm
    {
        static void Main(string[] args)
        {
            var hashtable = new HashTable<int, string>(100);
            hashtable.Add(5, "hello");
            hashtable.Add(100, "by");
            hashtable.Add(18, "good");
            Console.WriteLine(hashtable.Search(5, "hello"));
            Console.WriteLine(hashtable.Search(12, "by"));
        }    
    }
}