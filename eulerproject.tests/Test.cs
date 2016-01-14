using NUnit.Framework;
using System;

namespace eulerproject.tests
{
	[TestFixture]
	public class Test
	{
		[Test]
		public void TestProblem1 ()
		{
			Assert.AreEqual (new Problem1 ().Run (), 234168);
		}

		[Test]
		public void TestProblem2 ()
		{
			Assert.AreEqual (new Problem2 ().Run (), 4613732);
		}

		[Test]
		public void TestProblem3 ()
		{
			Assert.AreEqual (new Problem3 ().Run (), 6857);
		}

		[Test]
		public void TestProblem4 ()
		{
			Assert.AreEqual (new Problem4 ().Run (), 906609);
		}

		[Test]
		public void TestProblem5 ()
		{
			Assert.AreEqual (new Problem5 ().Run (), 232792560);
		}

		[Test]
		public void TestProblem6 ()
		{
			Assert.AreEqual (new Problem6 ().Run (), 25164150);
		}

		[Test]
		public void TestProblem7 ()
		{
			Assert.AreEqual (new Problem7 ().Run (), 104743);
		}

		[Test]
		public void TestProblem8 ()
		{
			Assert.AreEqual (new Problem8 ().Run (), 23514624000);
		}

		[Test]
		public void TestProblem9 ()
		{
			Assert.AreEqual (new Problem9 ().Run (), 31875000);
		}

		[Test]
		public void TestProblem10 ()
		{
			Assert.AreEqual (new Problem10 ().Run (), 142913828922);
		}
	}
}

