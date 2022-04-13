using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorOnWF;

namespace UnitTestProject1
{
	[TestClass]
	public class OperationsTests
	{
		[TestMethod]
		public void Numbers_WriteOperation_plus()
		{
			Operations os = new Operations();

			os.WriteOperation('+');

			Assert.AreEqual('+', os[0]);
		}

		[TestMethod]
		public void Numbers_WriteOperation_minus()
		{
			Operations os = new Operations();

			os.WriteOperation('-');

			Assert.AreEqual('-', os[0]);
		}

		[TestMethod]
		public void Numbers_WriteOperation_div()
		{
			Operations os = new Operations();

			os.WriteOperation('/');

			Assert.AreEqual('/', os[0]);
		}

		[TestMethod]
		public void Numbers_WriteOperation_mul()
		{
			Operations os = new Operations();

			os.WriteOperation('*');

			Assert.AreEqual('*', os[0]);
		}

		[TestMethod]
		public void Numbers_WriteOperation_NOTOPERATION()
		{
			Operations os = new Operations();

			os.WriteOperation('1');

			Assert.AreNotEqual('1', os[0]);
		}

		[TestMethod]
		public void Operations_RemoveLastOperation()
		{
			Operations os = new Operations();

			os.WriteOperation('-');
			os.RemoveLastOperation();

			Assert.AreEqual(0, os.Count);
		}

		[TestMethod]
		public void Operations_RemoveOperation()
		{
			Operations os = new Operations();

			for (int k = -1, l = 0; l < 20; l++, k -= 7)
			{
				os.WriteOperation('+');
			}

			char o10 = os[10];

			os.RemoveItem(10);

			Assert.AreEqual(19, os.Count);
		}

		[TestMethod]
		public void Operations_ReplaceLastOperation_minus_on_plus()
		{
			Operations os = new Operations();

			os.WriteOperation('-');
			os.ReplaceLastOperation('+');

			Assert.AreEqual('+', os[0]);
		}

		[TestMethod]
		public void Operations_Count()
		{
			Operations os = new Operations();
			char[] ss = new char[] { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' };

			for (int k = 0; k < ss.Length; k++) os.WriteOperation(ss[k]);

			Assert.AreEqual(ss.Length, os.Count);
		}

		[TestMethod]
		public void CheckEnterOperations()
		{
			Operations os = new Operations();
			char[] ss = new char[] { '+', '+', '+', '+', '+', '-', '*', '+', '/', '/', '-', '*', '*' };

			for (int k = 0; k < ss.Length; k++) os.WriteOperation(ss[k]);

			for (int k = 0; k < ss.Length; k++) Assert.AreEqual(ss[k], os[k]);
		}

	}
}
