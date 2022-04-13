using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorOnWF;

namespace UnitTestProject1
{
	[TestClass]
	public class NumbersTests
	{
		[TestMethod]
		public void Numbers_WriteNegativeNumber_1()
		{
			Numbers ns = new Numbers();

			ns.WriteNumber(-1);

			Assert.AreEqual(-1, ns[0]);
		}

		[TestMethod]
		public void Numbers_WritePositiveNumber_1()
		{
			Numbers ns = new Numbers();

			ns.WriteNumber(1);

			Assert.AreEqual(1, ns[0]);
		}

		[TestMethod]
		public void Numbers_WriteZero()
		{
			Numbers ns = new Numbers();

			ns.WriteNumber(0);

			Assert.AreEqual(0, ns[0]);
		}

		[TestMethod]
		public void Numbers_WriteNegativeNumbers_100()
        {
			Numbers ns = new Numbers();

			for(int k = -1, l = 0; l < 100; l++, k -= 7)
            {
				ns.WriteNumber(k);
			}

			for (int k = -1, l = 0; l < 100; l++, k -= 7)
			{
				Assert.AreEqual(k, ns[l]);
			}
		}

		[TestMethod]
		public void Numbers_WritePositiveNumbers_100()
		{
			Numbers ns = new Numbers();

			for (int k = 1, l = 0; l < 100; l++, k += 7)
			{
				ns.WriteNumber(k);
			}

			for (int k = 1, l = 0; l < 100; l++, k += 7)
			{
				Assert.AreEqual(k, ns[l]);
			}
		}

		[TestMethod]
		public void Numbers_WriteNumbers_100()
		{
			Numbers ns = new Numbers();

			for (int k = -100, l = 0; l < 100; l++, k += 7)
			{
				ns.WriteNumber(k);
			}

			for (int k = -100, l = 0; l < 100; l++, k += 7)
			{
				Assert.AreEqual(k, ns[l]);
			}
		}

		[TestMethod]
		public void Numbers_RemoveLastNumber()
		{
			Numbers ns = new Numbers();

			ns.WriteNumber(1);
			ns.RemoveLastNumber();

			Assert.AreEqual(0, ns.Count);
		}

		[TestMethod]
		public void Numbers_RemoveItems1_10_11_12_of_20()
		{
			Numbers ns = new Numbers();

			for (int k = -1, l = 0; l < 20; l++, k -= 7)
			{
				ns.WriteNumber(k);
			}

			double? n10 = ns[10];
			double? n11 = ns[11];
			double? n12 = ns[12];

			ns.RemoveItem(12);
			ns.RemoveItem(11);
			ns.RemoveItem(10);

			Assert.AreNotEqual(n10, ns[10]);
			Assert.AreNotEqual(n11, ns[11]);
			Assert.AreNotEqual(n12, ns[12]);
		}

		[TestMethod]
		public void Numbers_Count()
		{
			Numbers ns = new Numbers();
			int[] nums = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

			for (int k = 0; k < nums.Length; k++) ns.WriteNumber(nums[k]);

			Assert.AreEqual(nums.Length, ns.Count);
		}

		[TestMethod]
		public void CheckEnterOperations()
		{
			Numbers ns = new Numbers();
			int[] nums = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

			for (int k = 0; k < nums.Length; k++) ns.WriteNumber(nums[k]);

			for (int k = 0; k < nums.Length; k++) Assert.AreEqual(nums[k], ns[k]);
		}

	}
}
