using System;

using NUnit.Framework;

using AnonymousLetter;

namespace UnitTest
{
	[TestFixture]
	public class TestCase
	{
		[Test]
		public void WritableTest()
		{
			CheckWritability("говно с дымом", "с новым годом", true);
			CheckWritability("привет", "ппррииввеетт", true);
		}

		[Test]
		public void NotWritableTest()
		{
			CheckWritability("q", "w", false);
			CheckWritability("qwerty", "йцукен", false);
			CheckWritability("abbcc", "abc", false);
		}

		private void CheckWritability(string letter, string magazine, bool expected)
		{
			LetterHelper helper = new LetterHelper(letter);
			bool isWritable = helper.IsWritableWith(magazine);

			Assert.AreEqual(expected, isWritable);
		}
	}
}

