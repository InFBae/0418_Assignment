using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class List<T>
    {
        private const int DefaultSize = 10;
        private T[] items;
        private int size;

        public int Count { get { return size; } }
        public int Capacity { get { return items.Length; } }
        public List() {
            size = 0;
            items = new T[DefaultSize];
        }

        public T this[int index] 
        { 
            get { return items[index]; }
            set { items[index] = value; }
        }
        public void Add(T item)
        {
            if(items.Length <= size)
            {
                Grow();
            }
            items[size++] = item;
        }
        private void Grow()
        {
            T[] newList = new T[items.Length * 2];
            Array.Copy(items, 0, newList, 0, size);
            items = newList;
        }
        public void Clear()
        {
            T[] newList = new T[DefaultSize];
            items = newList;
        }
    }
}
