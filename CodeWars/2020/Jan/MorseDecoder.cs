using System.Text;
using Xunit;

namespace CodeWars
{

	public partial class Kata_2020_Jan
	{

		/// <summary>
		/// Kata #54b724efac3d5402db00065e <a href="https://www.codewars.com/kata/54b724efac3d5402db00065e">Decode the Morse code </a>
		/// </summary>
		[Theory]
		[InlineData(".... . -.--   .--- ..- -.. .", "HEY JUDE")]
		public void MorseDecoder(string morseCode, string expected)
		{
			StringBuilder sb = new StringBuilder();
			morseCode.Split(new string[] { "   " }, System.StringSplitOptions.RemoveEmptyEntries);
			string[] GetWords() => morseCode.Split(new string[] { "   " }, System.StringSplitOptions.RemoveEmptyEntries);
			string[] GetChars(string code) => morseCode.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
			foreach (string word in GetWords())
			{
				if (sb.Length > 0)
					sb.Append(' ');
				//foreach(string c in GetChars(word))
					//sb.Append(MorseCode.Get(c)); //STATIC CLASS FROM KATA EDITOR
			}
			string result = sb.ToString();
			Assert.Equal(expected, result);
		}

	}

}
