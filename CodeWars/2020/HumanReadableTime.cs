using System;
using System.Linq;
using Xunit;

namespace CodeWars
{

	public partial class Kata_2020
	{

		/// <summary>
		/// Kata #52685f7382004e774f0001f7 <a href="https://www.codewars.com/kata/52685f7382004e774f0001f7">Human Readable Time</a>
		/// </summary>
		[Theory]
		[InlineData(0, "00:00:00")]
		[InlineData(5, "00:00:05")]
		[InlineData(60, "00:01:00")]
		[InlineData(86399, "23:59:59")]
		[InlineData(359999, "99:59:59")]
		public void HumanReadableTime(int seconds, string expected)
		{
			int hours = seconds / 3600;
			int minutes = seconds % 3600 / 60;
			int secs = seconds % 60;
			string result = $"{hours.ToString("00")}:{minutes.ToString("00")}:{secs.ToString("00")}";
			Assert.Equal(expected, result);
		}

	}

}
