using System.Linq;
using Xunit;

namespace CodeWars
{

	public partial class Kata_2020
	{

		/// <summary>
		/// Kata #57cebe1dc6fdc20c57000ac9 <a href="https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9">Shortest word</a>
		/// </summary>
		[Theory]
		[InlineData("a bc def", 1)]
		[InlineData("bitcoin take over the world maybe who knows perhaps", 3)]
		[InlineData("turns out random test cases are easier than writing out basic ones", 3)]
		public void ShortestWord(string value, int expected)
		{
			int result = value.Split(' ').OrderBy(c => c.Length).First().Length;
			Assert.Equal(expected, result);
		}

	}

}
