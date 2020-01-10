using System;
using System.Linq;
using Xunit;

namespace CodeWars
{

	public partial class CodeWars
	{

		/// <summary>
		/// Kata #52f3149496de55aded000410 <a href="https://www.codewars.com/kata/52f3149496de55aded000410">Summing a number's digits</a>
		/// </summary>
		[Theory]
		[InlineData("99", 18)]
		public int SummingNumbersDigits(string digits, int expected)
		{
			var v = digits.ToCharArray().Where(c => char.IsDigit(c));
			int g = Convert.ToInt32('9'.ToString());
			int sum = v.Sum(c => Convert.ToInt32(c));
			Assert.Equal(expected, sum);
			return 0;
		}

	}

}
