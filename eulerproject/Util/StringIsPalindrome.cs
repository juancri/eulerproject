using System;

namespace eulerproject
{
	public static class StringIsPalindrome
	{
		public static bool IsPalindrome (this string n)
		{
			var characters = n.ToCharArray ();
			int a = 0;
			int b = characters.Length - 1;
			while (a < b)
			{
				if (characters [a] != characters [b])
					return false;
				a++;
				b--;
			}

			return true;
		}
	}
}

