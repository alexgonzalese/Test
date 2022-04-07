using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] Arra1;
            int[] Arra2;
            Arra1 = new[] { 1, 2, 3, 4, 5, 6 };
            Arra2 = new[] { 1, 2, 3, 4, 5 };

            var result = TestAbril2022.testArray.SumArray(Arra1, Arra2);

            var eval = (result != "OK" ? false : true);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(eval);
        }
    }
}
