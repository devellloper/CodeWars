using Xunit;

namespace CodeWars
{

	public partial class Kata_2020
	{

		/// <summary>
		/// Kata #534ea96ebb17181947000ada <a href="https://www.codewars.com/kata/534ea96ebb17181947000ada">Breaking chocolate problem</a>
		/// </summary>
		[Theory]
		[InlineData(1, 1, 0)]
		[InlineData(5, 5, 24)]
		public void BreakingChocolate(int n, int m, int expected)
		{
			int result = n * m - 1;
			result = result < 0 ? 0 : result;
			Assert.Equal(expected, result);
		}

	}

}
