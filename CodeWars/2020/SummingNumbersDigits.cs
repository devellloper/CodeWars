using System.Linq;
using Xunit;

namespace CodeWars
{

	public partial class Kata_2020
	{

		/// <summary>
		/// Kata #52f3149496de55aded000410 <a href="https://www.codewars.com/kata/52f3149496de55aded000410">Summing a number's digits</a>
		/// </summary>
		[Theory]
		[InlineData(10, 1)]
		[InlineData(99, 18)]
		[InlineData(-32, 5)]
		public void SummingNumbersDigits(int number, int expected)
		{
			int sum = number.ToString().Replace("-", string.Empty).ToCharArray().Select(c => int.Parse(c.ToString())).Sum();
			Assert.Equal(expected, sum);
		}

	}

}
