using challenges_and_data_structures.Challenges.Common_Elements;
namespace ChallengesTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_CommonElements_Case1()
        {
            // Arrange
            int[] arr1 = { 1, 2, 3, 0 };
            int[] arr2 = { 2, 3, 4, 9 };
            List<int> expected = new List<int> { 2, 3 };

            // Act
            List<int> result = CommonElement.CommonElements(arr1, arr2);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_CommonElements_Case2()
        {
            // Arrange
            int[] arr1 = { 79, 8, 15 };
            int[] arr2 = { 23, 79, 8 };
            List<int> expected = new List<int> { 79, 8 };

            // Act
            List<int> result = CommonElement.CommonElements(arr1, arr2);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}