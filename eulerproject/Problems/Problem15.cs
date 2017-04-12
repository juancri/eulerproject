namespace eulerproject
{
	[Problem (15, "Next Lattice paths", 137846528820)]
	public class Problem15 : IProblem
	{
		public long Run ()
		{
			return LatticePaths.Get (20);
		}
	}
}

