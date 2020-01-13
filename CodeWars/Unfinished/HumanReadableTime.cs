using System;
using System.Linq;
using Xunit;

namespace CodeWars
{

	public partial class Kata_2020_Jan
	{

		/// <summary>
		/// Kata #52685f7382004e774f0001f7 <a href="https://www.codewars.com/kata/52685f7382004e774f0001f7">Human Readable Time</a>
		/// </summary>
		[Theory]
		[InlineData(369999, "99:59:59")]
		public void HumanReadableTime(int seconds, string expected)
		{
			TimeSpan ts = TimeSpan.FromSeconds(seconds);
			int hours = seconds / 3600;
			int minutes = (seconds - seconds % 3600) / 60;
			string result = "";
			Assert.Equal(expected, result);
		}

	}

}
