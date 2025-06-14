using TwoSumProblem;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void TwoSumDictionary_ShouldReturnCorrectIndices()
        {
            // Arrange
            var twoSum = new TwoSum();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            // Act
            var result = twoSum.TwoSumDictionary(nums, target);

            // Assert
            Assert.Contains(0, result);
            Assert.Contains(1, result);
        }

        [Fact]
        public void TwoSumHashSet_ShouldReturnCorrectIndices()
        {
            var twoSum = new TwoSum();
            int[] nums = { 3, 2, 4 };
            int target = 6;

            var result = twoSum.TwoSumHashSet(nums, target);

            Assert.Contains(1, result);
            Assert.Contains(2, result);
        }
    }
}