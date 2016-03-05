namespace _06.BitCarousel
{
    using System;

    internal class BitCarousel
    {
        private static void Main()
        {
            sbyte number = sbyte.Parse(Console.ReadLine());
            sbyte rotations = sbyte.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string direction = Console.ReadLine();

                if (direction == "right")
                {
                    sbyte rightMostBit = (sbyte)(number & 1);
                    number >>= 1;
                    number |= (sbyte)(rightMostBit << 5);
                }
                else if (direction == "left")
                {
                    sbyte leftMostBit = (sbyte)((number >> 5) & 1);
                    number <<= 1;
                    number &= ~(1 << 6);
                    number |= leftMostBit;
                }
            }

            Console.WriteLine(number);
        }
    }
}