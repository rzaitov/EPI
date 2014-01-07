using System;

namespace LevenshteinDistance
{
	public abstract class WagnerFischerAlgorithm 
	{
		protected string First { get; private set; }
		protected string Second { get; private set; }

		public WagnerFischerAlgorithm(string first, string second)
		{
			First = first;
			Second = second;
		}

		public abstract int CalcLevenshteinDistance();
	}
}

