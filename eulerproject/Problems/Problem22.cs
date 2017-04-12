using System.Linq;

namespace eulerproject
{
	[Problem (22, "Names scores", 871198282)]
	public class Problem22 : IProblem
	{
		private const string filename = "eulerproject.Assets.problem22-names.txt";

		public long Run ()
		{
			return ReadFile ().Split (',')
				.Select (n => n.Replace ("\"", string.Empty))
				.OrderBy (n => n)
				.Select ((n, i) => n.Select (c => c - 'A' + 1).Sum () * (i + 1))
				.Sum ();
		}

		private static string ReadFile ()
		{
			using (var reader = new System.IO.StreamReader (
				System.Reflection.Assembly.GetExecutingAssembly ()
					.GetManifestResourceStream (filename)))
				return reader.ReadToEnd ();
		}
	}
}

