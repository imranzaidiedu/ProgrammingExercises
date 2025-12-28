namespace CSharpTests.Problems.Arrays
{
    using CSharp.Problems.Arrays;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class SumOfArrayTests
    {
        [TestMethod]
        public void Sum_PositiveNumbers_ReturnsCorrectSum()
        {
            int result = SumOfArray.Sum(new[] { 1, 2, 3, 4, 5 });
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Sum_NegativeNumbers_ReturnsCorrectSum()
        {
            int result = SumOfArray.Sum(new[] { -1, -2, -3, -4, -5 });
            Assert.AreEqual(-15, result);
        }

        [TestMethod]
        public void Sum_MixedNumbers_ReturnsCorrectSum()
        {
            int result = SumOfArray.Sum(new[] { -1, 2, -3, 4, -5 });
            Assert.AreEqual(-3, result);
        }

        [TestMethod]
        public void Sum_EmptyArray_ReturnsZero()
        {
            int result = SumOfArray.Sum(new int[0]);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Sum_SingleElement_ReturnsThatElement()
        {
            int result = SumOfArray.Sum(new[] { 42 });
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void Sum_LargeNumbers_ReturnsCorrectSum()
        {
            int result = SumOfArray.Sum(new[] { int.MaxValue, 1, -1 });
            Assert.AreEqual(int.MaxValue, result);
        }
    }
}