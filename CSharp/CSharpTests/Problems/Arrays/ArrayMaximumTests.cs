using CSharp.Problems.Arrays;

namespace CSharpTests
{
    [TestClass]
    public sealed class ArrayMaximumTests
    {
        [TestMethod]
        public void FindMaximum_SingleElement_ReturnsThatElement()
        {
            int result = ArrayMaximum.FindMaximum(new[] { 42 });
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void FindMaximum_AllNegativeNumbers_ReturnsMaximum()
        {
            int result = ArrayMaximum.FindMaximum(new[] { -3, -1, -7, -4 });
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void FindMaximum_MaxAtStart_ReturnsFirstElement()
        {
            int result = ArrayMaximum.FindMaximum(new[] { 10, 0, -5, -10 });
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void FindMaximum_MaxAtEnd_ReturnsLastElement()
        {
            int result = ArrayMaximum.FindMaximum(new[] { -10, -5, 0, 20 });
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void FindMaximum_WithDuplicates_ReturnsMaximum()
        {
            int result = ArrayMaximum.FindMaximum(new[] { 2, 2, 3, 1, 3 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void FindMaximum_WithIntMaxValue_ReturnsIntMax()
        {
            int result = ArrayMaximum.FindMaximum(new[] { int.MinValue, int.MaxValue, 0 });
            Assert.AreEqual(int.MaxValue, result);
        }

        [TestMethod]
        public void FindMaximum_EmptyArray_ThrowsArgumentException()
        {
            try
            {
                ArrayMaximum.FindMaximum(new int[0]);
                Assert.Fail("Expected ArgumentException was not thrown.");
            }
            catch (ArgumentException)
            {
                // expected
            }
        }
    }
}