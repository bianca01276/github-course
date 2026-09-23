# github-course

Repository for learning GitHub CI/CD with a simple .NET app.

## What's in this repository

- `src/SimpleApp` - a small console app that prints the GitHub CI/CD flow
- `tests/SimpleApp.Tests` - focused xUnit tests for the sample app
- `.github/workflows/dotnet-ci-cd.yml` - GitHub Actions workflow for CI and CD

## GitHub CI/CD flow

1. Push code or open a pull request to `main`.
2. GitHub Actions runs the **build-test** job:
   - restore NuGet packages
   - build the .NET solution
   - run the xUnit tests
3. When code is pushed to `main` and CI passes, the **publish** job runs:
   - publishes the console app
   - uploads the published output as a workflow artifact

## Run locally

Run these commands from the repository root:

```bash
dotnet test tests/SimpleApp.Tests/SimpleApp.Tests.csproj
dotnet run --project src/SimpleApp/SimpleApp.csproj
```
