using System;

namespace LevenshteinDistance
{
	public class WagnerFischerAlgorithmSimple : WagnerFischerAlgorithm
	{
		public WagnerFischerAlgorithmSimple(string first, string second)
			: base(first, second)
		{
		}

		public override int CalcLevenshteinDistance()
		{
			if(_first.Length == 0)
				return _second.Length;

			if(_second.Length == 0)
				return _first.Length;

			// i, j == 1 - mean first char in string
			// i, j == 0 - work field for initialization matrix
			int fDim = _first.Length + 1;
			int sDim = _second.Length + 1;
			int[,] D = new int[fDim, sDim];

			for(int i = 0; i < fDim; i++)
				D[i, 0] = i;

			for(int j = 0; j < sDim; j++)
				D[0, j] = j;

			for(int i = 1; i < fDim; i++)
			{
				for(int j = 1; j < sDim; j++)
				{
					// S1[1:i] -> S2[1:j] <==> S1[1:i-1] -> S2[1:j] + delete S1[i] from S1
					int deleteDist = D[i - 1, j] + 1;

					// S1[1:i] -> S2[1:j] <==> S1[1:i] -> S2[1:j-1] + insert S2[j] to S1
					int insertDist = D[i, j - 1] + 1;

					int cost = _first[i - 1] == _second[j - 1] ? 0 : 1; // i,j = 1 mean first char
					int replaceDist = D[i - 1, j - 1] + cost;

					int min = Math.Min(deleteDist, insertDist);
					min = Math.Min(min, replaceDist);

					D[i, j] = min;
				}
			}

			return D[fDim - 1, sDim - 1];
		}
	}
}

