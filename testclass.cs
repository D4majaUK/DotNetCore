using Xunit;

public class testclass
{
    [Fact]
    public void PassingAddTest()
    {
        Assert.Equal(4, fullDotNet.Program.Add(2,2));
    }

    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    [InlineData(10)]
    public void MyTheoryTest(int theoryNumber)
    {
        Assert.True(fullDotNet.Program.IsOdd(theoryNumber));
    }
}
