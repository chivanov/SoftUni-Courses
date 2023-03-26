using System;
using System.Collections.Generic;
using System.Text;

namespace E01.ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> colection;
        private int currIndex;

        public ListyIterator(params T[] data)
        {
            colection = new List<T>(data);
            currIndex = 0;
        }

        public bool HasNext() => currIndex < colection.Count - 1;

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
            if (colection.Count == 0)
            {
                throw new ArgumentException("Invalid operation");
            }
            Console.WriteLine($"{colection[currIndex]}");
        }

    }
}
