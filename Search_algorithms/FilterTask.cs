﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace Search_Algorithms
{
	public static class FilterTask
    {
        /// <summary>
        /// Returns new array of elements that contain expected digit from source array.
        /// </summary>
        /// <param name="source">Source array.</param>
        /// <param name="digit">Expected digit.</param>
        /// <returns>Array of elements that contain expected digit.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when digit value is out of range (0..9).</exception>
        /// <example>
        /// {1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17}  => { 7, 70, 17 } for digit = 7.
        /// </example>
        public static int[] FilterByDigit(int[] source, int digit)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source == Array.Empty<int>())
            {
                throw new ArgumentException("Array can not be empty.");
            }

            if (digit < 0 || digit > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(digit));
            }

            List<int> result = new List<int>();
            string d = digit.ToString("D", CultureInfo.CurrentCulture);

            for (int i = 0; i < source.Length; i++)
            {
                string s = source[i].ToString("D", CultureInfo.CurrentCulture);
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == d[0])
                    {
                        result.Add(source[i]);
                        break;
                    }
                }
            }

            return result.ToArray();
        }
    }
}
