using System;
using System.Threading;

namespace LevenshteinDistance
{
	public class WagnerFischerAlgorithmSpaceSafe : WagnerFischerAlgorithm
	{
		public WagnerFischerAlgorithmSpaceSafe(string first, string second)
			: base(first, second)
		{
		}

		public override int CalcLevenshteinDistance()
		{
			if(_first.Length < _second.Length)
				_second = Interlocked.Exchange(ref _first, _second);

			int[] D = new int[_second.Length + 1];

			for(int j = 0; j < _second.Length + 1; j++)
				D[j] = j;

			for(int i = 1; i < _first.Length + 1; i++)
			{
				int d_i_1_j_1 = D[0];
				D[0] = i;
				for(int j = 1; j < _second.Length + 1; j++)
				{
					int min = Math.Min(D[j - 1] + 1, D[j] + 1);

					int cost = _first[i - 1] == _second[j - 1] ? 0 : 1;
					min = Math.Min(min, d_i_1_j_1 + cost);

					d_i_1_j_1 = D[j];
					D[j] = min;
				}
			}

			return D[_second.Length];
		}
	}
}

