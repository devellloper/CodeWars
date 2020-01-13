using Xunit;

namespace CodeWars
{

	public partial class Kata_2020_Jan
	{

		/// <summary>
		/// Kata #55acfc59c3c23d230f00006d <a href="https://www.codewars.com/kata/55acfc59c3c23d230f00006d">Get ascii value of character</a>
		/// </summary>
		[Theory]
		[InlineData('A', 65)]
		[InlineData(' ', 32)]
		[InlineData('!', 33)]
		[InlineData('\"', 34)]
		public void GetASCIINumberFromChar(char c, int expected)
		{
			Assert.Equal(expected, (int)c);
		}

	}

}
