using System;
using System.Linq;

namespace eulerproject
{
	[Problem (22, "Names scores", 871198282)]
	public class Problem22 : IProblem
	{
		public long Run ()
		{
			return ReadFile ().Split (',')
				.Select (n => n.Replace ("\"", string.Empty))
				.OrderBy (n => n)
				.Select ((n, i) => n.Select (GetCharacterValue).Sum () * (i + 1))
				.Sum ();
		}

		private static int GetCharacterValue (char c)
		{
			return c - 'A' + 1;
		}

		private static string ReadFile ()
		{
			using (var reader = new System.IO.StreamReader (
				System.Reflection.Assembly.GetExecutingAssembly ()
				.GetManifestResourceStream ("eulerproject.Assets.problem22-names.txt")))
				return reader.ReadToEnd ();
		}
	}
}

