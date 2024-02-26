namespace Solution.Tests;

public class UnitTest
{
    [Theory]
    [InlineData(new[] { "flower","flow","flight" }, "fl")]
    [InlineData(new[] { "dog","racecar","car" }, "")]
    public void Test(string[] strs, string expected)
    {
        var result = Solution.LongestCommonPrefix(strs);

        Assert.Equal(expected, result);
    }
}