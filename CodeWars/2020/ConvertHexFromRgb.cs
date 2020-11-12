using Xunit;

namespace CodeWars
{

	public partial class Kata_2020
	{

		/// <summary>
		/// Kata #513e08acc600c94f01000001 <a href="https://www.codewars.com/kata/513e08acc600c94f01000001">RGB To Hex Conversion</a>
		/// </summary>
		[Theory]
		[InlineData(255, 255, 255, "FFFFFF")]
		[InlineData(255, 255, 300, "FFFFFF")]
		[InlineData(0, 0, 0, "000000")]
		[InlineData(148, 0, 211, "9400D3")]
		public void ConvertHexFromRgb(int r, int g, int b, string exptected)
		{
			int Validator(int value) => value < 0 ? 0 : value > 255 ? 255 : value;
			string RgbToHex(int value) => Validator(value).ToString("X2");
			string result = $"{RgbToHex(r)}{RgbToHex(g)}{RgbToHex(b)}";
			Assert.Equal(exptected, result);
		}

	}

}
