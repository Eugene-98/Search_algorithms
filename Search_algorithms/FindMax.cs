using System;

namespace Search_Algorithms
{
	public static class FindMax
    {
        /// <summary>
        /// Finds the element of the array with the maximum value.
        /// </summary>
        /// <param name="array"> Source array. </param>
        /// <returns>The element of the array with the maximum value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static int FindMaximum(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array == Array.Empty<int>())
            {
                throw new ArgumentException("source cannot be empty.");
            }

            int max = array[0];
            if (array.Length == 1)
            {
                return max;
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }
    }
}
