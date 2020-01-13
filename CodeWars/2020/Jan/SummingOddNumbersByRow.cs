using Xunit;

namespace CodeWars
{

	public partial class Kata_2020_Jan
	{

		/// <summary>
		/// Kata # <a href="https://www.codewars.com/kata/55fd2d567d94ac3bc9000064">Given the triangle of consecutive odd numbers:</a>
		/// </summary>
		[Theory]
		[InlineData(1, 1)]
		[InlineData(2, 8)]
		[InlineData(3, 27)]
		[InlineData(42, 74088)]
		public void SummingOddNumbersByRow(long row, long expected)
		{
			long sum = 0;
			for (long n = row * (row - 1) + 1, iter = 0; iter < row; n += 2, iter++)
				sum += n;
			Assert.Equal(expected, sum);
		}

	}

}
