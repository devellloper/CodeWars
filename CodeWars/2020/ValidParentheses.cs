using Xunit;

namespace CodeWars
{

	public partial class Kata_2020
	{

		/// <summary>
		/// Kata #52774a314c2333f0a7000688 <a href="https://www.codewars.com/kata/52774a314c2333f0a7000688>Valid Parentheses</a>
		/// </summary>
		[Theory]
		[InlineData("", true)]
		[InlineData("()", true)]
		[InlineData(")(", false)]
		[InlineData(")(()))", false)]
		[InlineData("(", false)]
		[InlineData("(())((()())())", true)]
		[InlineData("(a(sS@)d)ddds((sSDD(sdsad)(fdsfF#F))ds())", true)]
		public void ValidParentheses(string input, bool expected)
		{
			bool Validator()
			{
				if (string.IsNullOrEmpty(input))
					return true;

				int semaphore = 0;
				foreach (char c in input.ToCharArray())
				{
					semaphore += c == '(' ? 1 : c == ')' ? -1 : 0;
					if (semaphore < 0)
						return false;
				}
				return semaphore == 0;
			}
			bool result = Validator();
			Assert.Equal(expected, result);
		}

	}

}
