using System;
using System.Collections.Generic;

namespace Search_Algorithms
{
	public static class FilterByPalindromicTask
    {
        /// <summary>
        /// Returns new array that contains only palindromic numbers from source array.
        /// </summary>
        /// <param name="source">Source array.</param>
        /// <returns>Array of elements that are palindromic numbers.</returns>
        /// <exception cref="ArgumentNullException">Throw when array is null.</exception>
        /// <exception cref="ArgumentException">Throw when array is empty.</exception>
        /// <example>
        /// {12345, 1111111112, 987654, 56, 1111111, -1111, 1, 1233321, 70, 15, 123454321}  => { 1111111, 123321, 123454321 }
        /// {56, -1111111112, 987654, 56, 890, -1111, 543, 1233}  => {  }.
        /// </example>
        public static int[] FilterByPalindromic(int[] source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source == Array.Empty<int>())
            {
                throw new ArgumentException("Array can not be empty.");
            }

            List<int> result = new List<int>();
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == 0 || source[i] == source[i].Revers())
                {
                    result.Add(source[i]);
                }
            }

            return result.ToArray();
        }

        public static int Revers(this int sourse)
        {
            int reverse = 0;
            while (sourse > 0)
            {
                reverse = (reverse * 10) + (sourse % 10);
                sourse /= 10;
            }

            return reverse;
        }
    }
}
