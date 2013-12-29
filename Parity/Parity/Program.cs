using System;

namespace Parity
{
	class MainClass
	{
		private static Int16[] _parityCache;

		public static void Main(string[] args)
		{
			Int64[] test = new Int64[] { 0, 1, 2, 3, 5, 6, 7, 8, 9, 10};
			for(int i = 0; i < test.Length; i++)
			{
				Int64 num = test[i];
				Int16 parity = CalcParityWithInt64(num);
				Console.WriteLine(string.Format("{0}\t\tparity: {1}", num, parity));
			}

			InitParityCache();
			for(int i = 0; i < test.Length; i++)
			{
				Int64 num = test[i];
				Int16 parity = CalcParity3(num);
				Console.WriteLine(string.Format("{0}\t\tparity: {1}", num, parity));
			}
		}

		// bad version
		private static Int16 CalcParityWithInt64(Int64 number)
		{
			Int64 mask = 1;
			Int16 result = 0;

			do
			{
				result += (mask & number) == mask ? (Int16)1 : (Int16)0;
				mask <<= 1;
			}
			while(mask != 0);
			
			result %= 2;
			return result;
		}

		private static Int16 CalcParity(Int64 number)
		{
			Int16 result = 0;

			while(number != 0)
			{
				result ^= (short)(number & 1);
				number >>= 1;
			}

			return result;
		}

		private static Int16 CalcParity2(Int64 number)
		{
			Int16 result = 0;

			while(number != 0)
			{
				result ^= 1;
				number &= number - 1;
			}

			return result;
		}

		private static void InitParityCache()
		{
			_parityCache = new Int16[256];

			for(int i = 0; i < 256; i++)
			{
				_parityCache[i] = CalcParity2(i);
			}
		}

		private static Int16 CalcParity3(Int64 number)
		{
			return (short)(_parityCache[(number >> 48) & 0xFFFF] ^
			               _parityCache[(number >> 32) & 0xFFFF] ^
			               _parityCache[(number >> 16) & 0xFFFF] ^
			               _parityCache[number & 0xFFFF]);
		}
	}
}
