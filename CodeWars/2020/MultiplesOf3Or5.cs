using System.Linq;
using Xunit;

namespace CodeWars
{

	public partial class Kata_2020
	{

		/// <summary>
		/// Kata #514b92a657cdc65150000006 <a href="https://www.codewars.com/kata/514b92a657cdc65150000006">Multiples of 3 or 5</a>
		/// </summary>
		[Theory]
		[InlineData(10, 23)]
		public void MultiplesOf3Or5(int value, int expected)
		{
			int result = value == 0 ? 0 : Enumerable.Range(1, value - 1).Where(c => c % 3 == 0 || c % 5 == 0).Sum();
			Assert.Equal(expected, result);
		}

	}

}
