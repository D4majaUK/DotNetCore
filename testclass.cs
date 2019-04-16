using Xunit;
using fullDotNet.Pages;

public class testclass1
{
    [Fact]
    public void PassingValTest()
    {
        var resulta = myMethods.getVal("cb");
        var resultb = myMethods.getVal("");

        Assert.Equal("This is a function code-behind", resulta);
        Assert.Equal("This is a response that I do as default", resultb);
    }
}

public class testclass2
{
    [Fact]
    public void PassingCalcTest()
    {
        double result = myMethods.getCalc(17);
        Assert.Equal(402.9, result);
    }
}
public class testclass3
{
    [Fact]
    public void PassingAddTest()
    {
        Assert.Equal(4, fullDotNet.Program.Add(2,2));
    }
}
public class testclass4
{

    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    public void MyTheoryTest(int theoryNumber)
    {
        Assert.True(fullDotNet.Program.IsOdd(theoryNumber));
    }
}
