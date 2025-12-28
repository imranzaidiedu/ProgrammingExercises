using CSharp.Problems.Arrays;

namespace CSharpTests
{
    [TestClass]
    public sealed class ArrayMinimumTests
    {
        [TestMethod]
        public void FindMinimum_SingleElement_ReturnsThatElement()
        {
            int result = ArraysMinimum.FindMinimum(new[] { 42 });
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void FindMinimum_AllNegativeNumbers_ReturnsMinimum()
        {
            int result = ArraysMinimum.FindMinimum(new[] { -3, -1, -7, -4 });
            Assert.AreEqual(-7, result);
        }

        [TestMethod]
        public void FindMinimum_MinAtStart_ReturnsFirstElement()
        {
            int result = ArraysMinimum.FindMinimum(new[] { -10, 0, 5, 10 });
            Assert.AreEqual(-10, result);
        }

        [TestMethod]
        public void FindMinimum_MinAtEnd_ReturnsLastElement()
        {
            int result = ArraysMinimum.FindMinimum(new[] { 10, 5, 0, -20 });
            Assert.AreEqual(-20, result);
        }

        [TestMethod]
        public void FindMinimum_WithDuplicates_ReturnsMinimum()
        {
            int result = ArraysMinimum.FindMinimum(new[] { 2, 2, 3, 1, 1 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FindMinimum_WithIntMinValue_ReturnsIntMin()
        {
            int result = ArraysMinimum.FindMinimum(new[] { int.MaxValue, int.MinValue, 0 });
            Assert.AreEqual(int.MinValue, result);
        }

        [TestMethod]
        public void FindMinimum_EmptyArray_ThrowsArgumentException()
        {
            try
            {
                ArraysMinimum.FindMinimum(new int[0]);
                Assert.Fail("Expected ArgumentException was not thrown.");
            }
            catch (ArgumentException)
            {
                // expected
            }
        }

        [TestMethod]
        public void FindMinimum_NullInput_ThrowsArgumentNullException()
        {
            try
            {
                ArraysMinimum.FindMinimum(null);
                Assert.Fail("Expected ArgumentNullException was not thrown.");
            }
            catch (ArgumentNullException)
            {
                // expected
            }
        }
    }
}