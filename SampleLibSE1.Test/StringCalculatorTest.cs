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
            StringCalculator sc = new StringCalculator();
            
            Assert.AreEqual(0, sc.Add(""));
        }
    }
}
