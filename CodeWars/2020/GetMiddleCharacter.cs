using Xunit;

namespace CodeWars
{

	public partial class Kata_2020
	{

		/// <summary>
		/// Kata #56747fd5cb988479af000028 <a href="https://www.codewars.com/kata/56747fd5cb988479af000028>Get the Middle Character</a>
		/// </summary>
		[Theory]
		[InlineData("test", "es")]
		[InlineData("testing", "t")]
		[InlineData("middle", "dd")]
		[InlineData("A", "A")]
		public void GetMiddleCharacter(string word, string expected)
		{
			string result = word.Length % 2 == 0 ? word.Substring(word.Length / 2 - 1, 2) : word.Substring(word.Length / 2, 1);
			Assert.Equal(expected, result);
		}

	}

}
