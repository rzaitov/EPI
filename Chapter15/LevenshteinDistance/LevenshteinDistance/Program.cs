using System;
using Wfa = LevenshteinDistance.WagnerFischerAlgorithm;
namespace LevenshteinDistance
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Wfa alg1 = new Wfa("kitten", "sitting");
			PrintResult(alg1);
		
			Wfa alg2 = new Wfa("sunday", "saturday");
			PrintResult(alg2);

			Wfa alg3 = new Wfa("CONNECT", "CONEHEAD");
			PrintResult(alg3);

			Wfa alg4 = new Wfa("Orchestra", "Carthorse");
			PrintResult(alg4);
		}

		private static void PrintResult(Wfa alg)
		{
			int dist = alg.CalcLevenshteinDistance();
			Console.WriteLine(string.Format("{0} -> {1}\t\tdistance: {2}", alg.First, alg.Second, dist));
		}
	}
}
