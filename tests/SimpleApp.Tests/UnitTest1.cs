using SimpleApp;

namespace SimpleApp.Tests;

public class UnitTest1
{
    [Fact]
    public void GetSteps_ReturnsExpectedCiCdFlow()
    {
        var steps = CiCdGuide.GetSteps();

        Assert.Equal(3, steps.Length);
        Assert.Contains("GitHub Actions", steps[0]);
        Assert.Contains("CI", steps[1]);
        Assert.Contains("CD", steps[2]);
    }
}
