using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01
{
    internal class FixedSizeList<T>
    {
        #region Attributes
        private T[] list;
        private int Count;
        private int Capacity;

        #endregion

        #region Properties
        public int GetCapacity
        {
            get { return Capacity; }
        }

        #endregion

        #region Constructor
        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be bigger than zero");
            }
            Capacity = capacity;
            list = new T[capacity];
            Count = 0;
        }

        #endregion

        #region Methods
        public void Add(T item)
        {
            if (Count >= Capacity)
            {
                throw new ArgumentException("The list is already full");
            }
            list[Count] = item;
            Count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentException("Inavlid Index");
            }
            return list[index];
        } 

        #endregion

    }
}
