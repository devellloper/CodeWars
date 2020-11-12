using Xunit;

namespace CodeWars
{

	public partial class Kata_2020
	{

		/// <summary>
		/// Kata #5270d0d18625160ada0000e4 <a href="https://www.codewars.com/kata/5270d0d18625160ada0000e4">Greed is Good</a>
		/// </summary>
		[Theory]
		[InlineData(0, new int[] { 2, 3, 4, 6, 2 })]
		[InlineData(400, new int[] { 4, 4, 4, 3, 3 })]
		[InlineData(450, new int[] { 2, 4, 4, 5, 4 })]
		public void GreedIsGood(int score, int[] dice)
		{
			int result = 0;
			int[] vv = new int[] { 0, 0, 0, 0, 0, 0 };
			foreach (int v in dice)
				vv[v - 1]++;
			for (int i = 0; i < vv.Length; i++)
			{
				if (vv[i] == 0)
					continue;

				//3x
				if (vv[i] - 3 >= 0)
				{
					result += (i + 1) * (i == 0 ? 1000 : 100);
					vv[i] -= 3;
				}

				//1x
				if (i == 0)
					result += vv[i] * 100;
				if (i == 4)
					result += vv[i] * 50;
			}
			Assert.Equal(score, result);
		}

	}

}
