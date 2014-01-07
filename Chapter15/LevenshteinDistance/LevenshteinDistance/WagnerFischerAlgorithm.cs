using System;

namespace LevenshteinDistance
{
	public abstract class WagnerFischerAlgorithm 
	{
		protected string _first;
		protected string _second;

		public WagnerFischerAlgorithm(string first, string second)
		{
			_first = first;
			_second = second;
		}

		public abstract int CalcLevenshteinDistance();
	}
}

