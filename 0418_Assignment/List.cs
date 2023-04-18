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

        public int Count { get { return size; } }   // 카운트 변수
        public int Capacity { get { return items.Length; } }    // 캐퍼시티 변수
        public List() {     // 기본 생성자
            size = 0;
            items = new T[DefaultSize];
        }
        public List(IEnumerable<T> values)  // 생성자로 배열을 받았을 때 구현
        {
            size = 0;
            items = new T[DefaultSize];
            foreach (T item in values)
            {
                if (items.Length <= size)
                {
                    Grow();
                }
                items[size++] = item;
            }
        }
        public List(int listSize)   // 받은 정수의 크기로 리스트 생성
        {
            size = 0;
            items = new T[listSize];
        }

        public T this[int index]    // 인덱서 구현
        { 
            get { return items[index]; }
            set { items[index] = value; }
        }
        public void Add(T item)     // Add 함수 구현
        {
            if(items.Length <= size)
            {
                Grow();
            }
            items[size++] = item;
        }

        public int IndexOf(T item)      // IndexOf 함수 구현
        {
            return Array.IndexOf(items, item);
        }
        public bool Remove(T item)      // Remove 함수 구현
        {
            int index = IndexOf(item);

            if (index >= 0)
            {
                RemoveAt(index);
            }else { return false; }
            return true;
        }

        public void RemoveAt(int index)     // RemoveAt 함수 구현
        {
            IndexCheck(index);
            size--;
            Array.Copy(items, index + 1, items, index, size - index);
        }
        private void IndexCheck(int index)      // IndexOutOfRangeException을 감지하는 내부용 함수 구현
        {
            if (index < 0 || index >= size)
                throw new IndexOutOfRangeException();
        }

        private void Grow()     // 리스트의 크기를 두배로 늘리는 내부 함수 Grow 구현
        {
            T[] newList = new T[items.Length * 2];
            Array.Copy(items, 0, newList, 0, size);
            items = newList;
        }
        public void Clear()     // 리스트를 빈 리스트로 바꾸는 Clear 함수 구현
        {
            T[] newList = new T[DefaultSize];
            items = newList;
        }
    }
}
