using System;

namespace MaxSubarray
{
	/// <summary>
	/// Задача найти наибольший подмассив сумма элементов которого максимальна.
	/// Наибольший – значит: если есть 2 массива с одинаковой суммой предпочтение нужно отдать масссиву который больше
	/// </summary>
	public class SumArrayDivider
	{
		public SumArrayDivider()
		{
		}

		/// <summary>
		/// Time O(n). Space: O(n)
		/// </summary>
		public void Divide1(int[] array, out int l, out int r, out int optimum)
		{
			if(array.Length == 0)
			{
				l = r = optimum = -1;
				return;
			}

			int[] subSums = new int[array.Length];

			l = r = 0;
			subSums[0] = array[0];

			int minSum = 0;
			int sum = 0;

			int j = -1;

			for(int i = 0; i < array.Length; i++)
			{
				sum += array[i];
				int sum_j_i = sum - minSum;

				if(i > 0)
				{
					if(sum_j_i > subSums[i - 1])
					{
						l = j != -1 ? j + 1 : 0;
						r = i;
						subSums[i] = sum_j_i;
					}
					else
					{
						subSums[i] = subSums[i - 1];
					}
				}

				if(sum < minSum)
				{
					minSum = sum;
					j = i;
				}
			}

			optimum = subSums[array.Length - 1];
		}
	}
}

