using SimpleApp;

namespace SimpleApp.Tests;

public class UnitTest1
{
    [Fact]
    public void GetSteps_ReturnsExpectedCiCdFlow()
    {
        var steps = CiCdGuide.GetSteps();

        Assert.Equal(
            [
                "1. Push code or open a pull request to trigger GitHub Actions.",
                "2. CI restores dependencies, builds the .NET app, and runs tests.",
                "3. CD publishes the app artifact from the main branch after CI passes."
            ],
            steps);
    }
}
