using System;
using System.Collections.Generic;
using System.Linq;

namespace Website.Infrastructure
{
	public static class ListExtensions
	{
		public static List<T> RandomPermutation<T>(this IEnumerable<T> list)
		{
			return RandomPermutation(list.ToArray<T>()).ToList<T>();
		}

		public static T[] RandomPermutation<T>(T[] array)
		{
			var retArray = new T[array.Length];
			array.CopyTo(retArray, 0);

			var random = new Random();
			for (int i = 0; i < array.Length; i += 1)
			{
				int swapIndex = random.Next(i, array.Length);
				
				if (swapIndex != i)
				{
					T temp = retArray[i];
					retArray[i] = retArray[swapIndex];
					retArray[swapIndex] = temp;
				}
			}

			return retArray;
		}

	}
}