using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArrayList<T>
    {
        private T[] items;
        private const int Initial_Capacity = 2;
        public int Count { get; private set; }
        public ArrayList()
        {
            this.items = new T[Initial_Capacity];
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.items[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                this.items[index] = value;
            }
        }
        public void Add(T item) 
        {
            if (this.Count == this.items.Length)
            {
                Resize();
            }
            this.items[this.Count] = item;
            this.Count++;
        }

        private void Resize()
        {
            T[] newArray = new T[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                newArray[i] = this.items[i];
            }
            this.items = newArray;
        }

        public T RemoveAt(int index) 
        { 
        if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
        T item = this.items[index];
            this.items[index] = default(T);
            this.Shift(index);
            this.Count--;

            if (this.Count <= this.items.Length/4 && this.items.Length /2 >= Initial_Capacity)
            {
                this.Shrink();
            }

            return item;
        }
        private void Shift(int index)
        {
            for (int i = index; i < this.Count-1; i++)
            {
                this.items[i] = this.items[i+1];
            }
        }

        private void Shrink()
        {
            T[] newArray = new T[this.items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.items[i];
            }
            this.items = newArray;
        }

        public int Capacity
        {
            get { return this.items.Length; }
        }
    }
}
