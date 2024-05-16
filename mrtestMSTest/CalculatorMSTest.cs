using mrTester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mrtestMSTest
{
	[TestClass]
	public class CalculatorMSTest
	{
		[TestMethod]
		public void AddNumbers_InputTwoInt_GetCorrectAddition()
		{
			//Arrange
			Calculator calc = new();

			//Act
			int result = calc.AddNumbers(10, 20);

			//Assert 
			Assert.AreEqual(30, result);

		}
	}
}
