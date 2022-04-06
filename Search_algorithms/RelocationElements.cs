using System;

namespace Search_Algorithms
{
	public static class RelocationElements
    {
        /// <summary>
        /// Moves all of the elements with set value to the end, preserving the order of the other elements.
        /// </summary>
        /// <param name="source"> Source array. </param>
        /// <param name="value">Source value.</param>
        /// <exception cref="ArgumentNullException">Thrown when source array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when source array is empty.</exception>
        public static void MoveToTail(int[] source, int value)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source == Array.Empty<int>())
            {
                throw new ArgumentException("Array cannot be empty.");
            }

            for (int i = source.Length - 1; i >= 0; i--)
            {
                if (source[i] == value)
                {
                    for (int j = i; j < source.Length - 1; j++)
                    {
                        source[j] = source[j + 1];
                    }

                    source[^1] = value;
                }
            }
        }
    }
}
