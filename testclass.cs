using Xunit;

public class testclass
{
    [Fact]
    public void PassingIndexValTest()
    {
        Assert.Equal("This is a function code-behind", fullDotNet.getVal("cb"));
        Assert.Equal("This is a response that I do as default", fullDotNet.getVal(""));
    }

    [Fact]
    public void PassingAddTest()
    {
        Assert.Equal(4, fullDotNet.Program.Add(2,2));
    }

    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    public void MyTheoryTest(int theoryNumber)
    {
        Assert.True(fullDotNet.Program.IsOdd(theoryNumber));
    }
}
