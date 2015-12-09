using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericList
{
    [VersionAttribute("2.11")]
    public class GenericList<T> where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;
        
        private T[] elements;
        private int currentIndex;

        public GenericList(int capacity = GenericList<T>.DefaultCapacity)
        {
            this.elements = new T[capacity];
            this.currentIndex = 0;
        }

        public int Capacity
        {
            get { return this.elements.Length; }
        }

        public int Size
        {
            get { return this.currentIndex; }
        }

        public void Add(T element)
        {
            if (this.currentIndex == this.elements.Length)
            {
                this.Resize(this.elements.Length);
            }

            this.elements[currentIndex] = element;
            this.currentIndex++;
        }

        public T AccessElementByIndex(int index)
        {
            if (index < 0 || index >= this.currentIndex)
            {
                throw new ArgumentOutOfRangeException("index", "Index must be non-negative and less than the size of the collection");
            }

            return this.elements[index];
        }

        public void RemoveElementByIndex(int index)
        {
            if (index < 0 || index >= this.currentIndex)
            {
                throw new ArgumentOutOfRangeException("index", "Index must be non-negative and less than the size of the collection");
            }

            for (int i = index; i < this.currentIndex - 1; i++)
            {
                this.elements[index] = this.elements[index + 1];
            }

            this.currentIndex--;
        }

        public void InsertElementAtGivenPosition(int index, T value)
        {
            if (index < 0 || index > this.currentIndex)
            {
                throw new ArgumentOutOfRangeException("index", "Index must be within the bounds of the list");
            }

            if (this.currentIndex == this.elements.Length)
            {
                this.Resize(this.elements.Length);
            }

            for (int i = this.currentIndex; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.elements[index] = value;
            this.currentIndex++;
        }

        public void Clear()
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                this.elements[i] = default(T);
            }

            this.currentIndex = 0;
        }

        public int FindElementIndexByGivenValue(T value)
        {
            for (int index = 0; index < this.currentIndex; index++)
            {
                if (this.elements[index].Equals(value))
                {
                    return index;
                }
            }

            return -1;
        }

        public bool ContainsValue(T value)
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (this.elements[i].Equals(value))
                {
                    return true;
                }
            }

            return false;
        }

        public T this[int index]
        {
            set
            {
                if (index < 0 || index >= this.currentIndex)
                {
                    throw new ArgumentOutOfRangeException("index", "Index must be non-negative and less than the size of the collection");
                }

                this.elements[index] = value;
            }
        }

        public T Min()
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentException("The list is empty");
            }

            T min = this.elements[0];
            for (int i = 1; i < this.currentIndex; i++)
            {
                if (min.CompareTo(this.elements[i]) > 0)
                {
                    min = this.elements[i];
                }
            }

            return min;
        }

        public T Max()
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentException("The list is empty");
            }

            T max = this.elements[0];
            for (int i = 1; i < this.currentIndex; i++)
            {
                if (max.CompareTo(this.elements[i]) < 0)
                {
                    max = this.elements[i];
                }
            }

            return max;
        }

        public override string ToString()
        {
            var list = new StringBuilder();
            for (int i = 0; i < this.currentIndex; i++)
            {
                list.Append(this.elements[i] + " ");
            }

            return list.ToString();
        }

        private void Resize(int currentCapacity)
        {
            T[] newArray = new T[currentCapacity * 2];
            for (int i = 0; i < this.elements.Length; i++)
            {
                newArray[i] = this.elements[i];
            }

            this.elements = newArray;
        }
    }
}
