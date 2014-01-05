using System;
using System.Collections.Generic;

namespace AnonymousLetter
{
	public class LetterHelper
	{
		private Dictionary<char, int> _charCountMap;

		public LetterHelper(string letter)
		{
			_charCountMap = new Dictionary<char, int>();
			FillMap(letter);
		}

		private void FillMap(string letter)
		{
			foreach(char c in letter)
				if (_charCountMap.ContainsKey(c))
					_charCountMap[c] += 1;
				else
					_charCountMap[c] = 1;
		}

		public bool IsWritableWith(string magazine)
		{
			if(_charCountMap.Count == 0)
				return true;

			foreach(char c in magazine)
			{
				if(!_charCountMap.ContainsKey(c))
					continue;

				_charCountMap[c] -= 1;

				if(_charCountMap[c] == 0)
					_charCountMap.Remove(c);

				if(_charCountMap.Count == 0)
					return true;
			}

			return false;
		}
	}
}

