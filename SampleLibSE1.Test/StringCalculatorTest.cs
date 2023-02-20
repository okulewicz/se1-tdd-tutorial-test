using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleLibSE1;

namespace SampleLibSE1.Test
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
        public void EmptyStringReturnZero()
        {
            string emptyInput = "";
            int expectedOutputForEmptyInput = 0;
            StringCalculator sc = new StringCalculator();
            int result = sc.Add(emptyInput);
            Assert.AreEqual(expectedOutputForEmptyInput, result);
        }
    }
}
