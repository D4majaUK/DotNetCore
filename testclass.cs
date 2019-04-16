using Xunit;
using fullDotNet.Pages;

public class testclass
{
    [Fact]
    public void PassingIndexValTest()
    {
        var resulta = myMethods.getVal("cb");
        var resultb = myMethods.getVal("");

        Assert.Equal("This is a function code-behind", resulta);
        Assert.Equal("This is a response that I do as default", resultb);
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
