# Xamarin Forms: Github Actions DEMO (incl. CommunityToolkit.MVVM source generators)

Sample project that demonstrates using github actions to run CI builds whenever a commit is pushed to main, or a pull request happens

The Sample project includes
- Android and iOS Xamarin Forms projects
- Shared .NET 2 Standard library, with a dependency on CommunityToolkit.MVVM, which makes use of source generators
- .NET 6 NUnit Test project

### Getting it to run
- we need a dedicated solution file that doesn't include the test project when retoring nugets for the mobile projects, else build fails looking for .NET 6.x SDK (even if it's installed by an action command)

### Current Issues
- it seems the the current version of mono only includes Roslyn 3.x compiler, but source generators require 4.x
  This only fails using msbuild though. The .NET 6 Test project builds just fine [link](https://github.com/actions/runner-images/issues/5782)

### External Links
[Official Github Documentation](https://docs.github.com/en/actions/automating-builds-and-tests/building-and-testing-xamarin-applications)

[Basic Quickstart](https://levelup.gitconnected.com/using-github-actions-with-ios-and-android-xamarin-apps-693a93b48a61)
