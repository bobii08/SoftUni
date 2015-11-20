using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.BitArray
{
    public class BitArray
    {
        private const int MaxSize = 100000;
        private int[] bits;

        public BitArray(int numberOfBits)
        {
            if (numberOfBits > MaxSize)
            {
                throw new ArgumentOutOfRangeException("numberOfBits", "Number of bits cannot be bigger than " + MaxSize);
            }
            this.bits = new int[numberOfBits];
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > this.bits.Length)
                {
                    throw new ArgumentOutOfRangeException("index", "Index is out of range!");
                }
                return this.bits[index];
            }
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid bit value!");
                }
                if (index < 0 || index >= this.bits.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range!");
                }
                this.bits[index] = value;
            }
        }

        public override string ToString()
        {
            BigInteger number = 0;
            int position = 0;
            for (int i = 0; i < this.bits.Length; i++)
            {
                if (this.bits[i] == 1 && position > 0)
                {
                    BigInteger powerOf2 = 2;
                    for (int j = 0; j < position - 1; j++)
                    {
                        powerOf2 *= 2;
                    }
                    number += this.bits[i] * powerOf2;
                }
                
                position++;
            }

            return number.ToString();
        }
    }
}
