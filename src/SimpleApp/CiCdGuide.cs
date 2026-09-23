namespace SimpleApp;

public static class CiCdGuide
{
    public static string[] GetSteps() =>
    [
        "1. Push code or open a pull request to trigger GitHub Actions.",
        "2. CI restores dependencies, builds the .NET app, and runs tests.",
        "3. CD publishes the app artifact from the main branch after CI passes."
    ];
}
