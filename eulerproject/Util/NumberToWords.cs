using System;

namespace eulerproject
{
	public static class NumberToWords
	{
		private static readonly string [] firstTwenty =
			new []
			{
				"one", "two", "three", "four", "five", "six",
				"seven", "eight", "nine", "ten", "eleven",
				"twelve", "thirteen", "fourteen", "fifteen",
				"sixteen", "seventeen", "eighteen", "nineteen"
			};
		private static readonly string [] decimals =
			new []
			{
				
				"twenty", "thirty", "forty", "fifty", "sixty",
				"seventy", "eighty", "ninety"
			};

		public static string ToWords (this int n)
		{
			if (n == 0)
				return string.Empty;
			
			if (n < 20)
				return firstTwenty [n - 1];
			
			if (n < 100)
				return decimals [(n / 10) - 2] + (n % 10).ToWords ();

			if (n < 1000)
				return (n % 100 > 0) ?
					(n / 100).ToWords () + "hundredand" + (n % 100).ToWords () :
					(n / 100).ToWords () + "hundred";
			if (n < 1000000)
				return (n / 1000).ToWords () + "thousand" + (n % 1000).ToWords ();

			throw new NotImplementedException ("Not implemented for: " + n);
		}
	}
}

