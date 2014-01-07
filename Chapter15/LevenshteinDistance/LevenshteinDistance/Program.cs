using System;

using Wfa = LevenshteinDistance.WagnerFischerAlgorithm;
using WfaSimple = LevenshteinDistance.WagnerFischerAlgorithmSimple;
using WfaSpaceSafe = LevenshteinDistance.WagnerFischerAlgorithmSpaceSafe;

namespace LevenshteinDistance
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			CalcAndPrintLevenshteinDistance("kitten", "sitting");
			CalcAndPrintLevenshteinDistance("sunday", "saturday");
			CalcAndPrintLevenshteinDistance("CONNECT", "CONEHEAD");
			CalcAndPrintLevenshteinDistance("Orchestra", "Carthorse");
		}

		private static void CalcAndPrintLevenshteinDistance(string first, string second)
		{
			Wfa alg = new WfaSpaceSafe(first, second);
			int dist = alg.CalcLevenshteinDistance();

			Console.WriteLine(string.Format("{0} -> {1}\t\t distance: {2}", first, second, dist));
		}
	}
}
