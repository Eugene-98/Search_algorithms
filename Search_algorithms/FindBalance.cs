using System;

namespace Search_Algorithms
{
	public static class FindBalance
    {
        /// <summary>
        /// Finds an index of element in an integer array for which the sum of the elements
        /// on the left and the sum of the elements on the right are equal.
        /// </summary>
        /// <param name="array">Source array.</param>
        /// <returns>The index of the balance element, if it exists, and null otherwise.</returns>
        /// <exception cref="ArgumentNullException">Thrown when source array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when source array is empty.</exception>
        public static int? FindBalanceElement(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array == Array.Empty<int>())
            {
                throw new ArgumentException("Array can not be empty.");
            }

            int? result = null;

            for (int i = 1; i < array.Length - 1; i++)
            {
                long sumL = 0;
                long sumR = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    sumL += array[j];
                }

                for (int l = i + 1; l < array.Length; l++)
                {
                    sumR += array[l];
                }

                if (sumR == sumL)
                {
                    result = i;
                }
            }

            return result;
        }
    }
}
