using Xunit;
using fullDotNet.Pages;

public class testclass
{
    private readonly myMethods _myMethods;

    [Fact]
    public void PassingIndexValTest()
    {
        var resulta = new myMethods.getVal("cb");
        var resultb = new myMethods.getVal("");

        Assert.Equal("This is a function code-behind", result);
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
