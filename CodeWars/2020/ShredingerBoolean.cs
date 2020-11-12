using Xunit;

namespace CodeWars
{

	public partial class Kata_2020
	{

		/// <summary>
		/// Kata #5a5f9f80f5dc3f942b002309 <a href="https://www.codewars.com/kata/5a5f9f80f5dc3f942b002309">Schrödinger's Boolean</a>
		/// </summary>
		[Fact]
		public void ShredingerBoolean()
		{
			Assert.True(KataShredingerBool.omnibool);
			Assert.False(KataShredingerBool.omnibool);
		}

		public class KataShredingerBool
		{
			private static bool _temp;
			public static bool omnibool
			{
				get => _temp = !_temp;
				set => _temp = value;
			}
		}

	}

}
