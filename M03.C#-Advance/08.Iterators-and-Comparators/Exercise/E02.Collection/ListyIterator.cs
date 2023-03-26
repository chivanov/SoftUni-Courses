using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace E01.ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> collection;
        private int currIndex;

        public ListyIterator(params T[] data)
        {
            collection = new List<T>(data);
            currIndex = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T elementtem in collection)
            {
                yield return elementtem;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool HasNext() => currIndex < collection.Count - 1;

        public bool Move()
        {
            bool canMove = HasNext();
            if (canMove)
            {
                currIndex++;
            }
            return canMove; 
        }

        public void Print()
        {
            if (collection.Count == 0)
            {
                throw new ArgumentException("Invalid operation");
            }
            Console.WriteLine($"{collection[currIndex]}");
        }

        public void PrintAll() => Console.WriteLine(String.Join(' ', collection));       
    }
}
