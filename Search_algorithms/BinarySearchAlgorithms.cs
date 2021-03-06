using System;

namespace Search_Algorithms
{
	public static class BinarySearchAlgorithms
    {
        /// <summary>
        /// </summary>
        /// <param name="source">Source sorted array.</param>
        /// <param name="value">Value to search.</param>
        /// <returns>
        /// The position of an element with a given value in sorted array.
        /// If element is not found returns null.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <example>
        /// source = {1, 3, 4, 6, 8, 9, 11}, value = 11 => 6,
        /// source = {1, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 634}, value = 144 => 9,
        /// source = {1, 3, 4, 6, 8, 9, 11}, value = 0 => null,
        /// source = {1, 3, 4, 6, 8, 9, 11}, value = 14 => null.
        /// source = { }, value = 14 => null.
        /// </example>
        public static int? BinarySearch(int[] source, int value)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            int? result = null;
            int first = 0;
            int last = source.Length;
            while (first <= last && first < source.Length)
            {
                int middle = (first + last) / 2;
                if (source[middle] == value)
                {
                    return middle;
                }
                else if (value < source[middle])
                {
                    last = middle - 1;
                }
                else
                {
                    first = middle + 1;
                }
            }

            return result;
        }
    }
}
